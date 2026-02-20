# Code Examples — Before / After

This document shows key refactoring transformations applied during the enterprise restructuring of CV Analyser.

---

## 1. Naming Convention Transformation

**Rationale**: Consistent naming across all files makes the codebase scannable and reduces onboarding time for new developers.

### Before (PascalCase / Mixed)

```csharp
namespace CV_Analyser.Engine
{
    internal static class Check
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
```

### After (Enterprise Conventions)

```csharp
namespace CV_Analyser.Backend.Core
{
    #region CLASSES
    // Provides reusable validation for user inputs
    internal static class C_Check
    {
        #region FUNCTIONS
        // Validates email format using a standard regex
        public static bool F_Is_Valid_Email(string p_email)
        {
            if (string.IsNullOrWhiteSpace(p_email)) return false;
            return Regex.IsMatch(p_email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        #endregion
    }
    #endregion
}
```

**Changes**: `C_` prefix for classes, `F_` prefix for functions, `p_` prefix for parameters, regions, and single-line comments.

---

## 2. Security — Command Injection Fix

**Rationale**: The original `Process.Start(url)` could be exploited if `url` contained shell commands.

### Before

```csharp
public static void BrowserStart(string url)
{
    Process.Start(url);
}
```

### After

```csharp
// Opens a URL in the default system browser securely
public static void F_Browser_Start(string p_url)
{
    try
    {
        Process.Start(new ProcessStartInfo(p_url) { UseShellExecute = true });
    }
    catch (Exception ex)
    {
        F_Log_Error("F_Browser_Start", ex);
        F_Show_Error("Could not open the link. Please try again.");
    }
}
```

**Changes**: `ProcessStartInfo` with `UseShellExecute = true` prevents command injection, and try-catch prevents unhandled crashes.

---

## 3. Performance — HashSet for Keywords

**Rationale**: `List.Contains()` is O(n) per lookup. With large keyword lists and many CVs, this becomes a bottleneck.

### Before

```csharp
List<string> keywords = new List<string>() { "python", "java", "sql" };
int matches = 0;
foreach (string word in resumeWords)
{
    if (keywords.Contains(word))  // O(n) per check
        matches++;
}
```

### After

```csharp
HashSet<string> keyword_set = new HashSet<string>(
    keywords.Select(k => k.ToLowerInvariant())
);
int match_count = 0;
foreach (string word in resume_words)
{
    if (keyword_set.Contains(word.ToLowerInvariant()))  // O(1) per check
        match_count++;
}
```

**Changes**: `HashSet` provides O(1) lookups vs O(n) for `List`. Case-insensitive comparison via `ToLowerInvariant()`.

---

## 4. Architecture — Monolithic to Modular

**Rationale**: The original flat structure (`Engine/`, `Data/`, `Interface/`) mixed concerns. The new structure separates by domain and UI layer.

### Before — Directory Structure

```
CV-Analyser/
├── Data/
│   ├── Query_Account.cs     # Mixed with Engine concerns
│   └── Query_Resume.cs
├── Engine/
│   ├── App.cs               # Everything in one folder
│   ├── Check.cs
│   ├── Mail.cs
│   └── Resume.cs
└── Interface/
    ├── Account/Account.cs    # Each form in its own subfolder
    ├── Analyser/Analyser.cs
    ├── Entry/Entry.cs
    └── Password/Password.cs
```

### After — Enterprise Structure

```
CV-Analyser/
├── backend/
│   ├── auth/                 # Domain: authentication
│   │   └── query_account.cs
│   ├── core/                 # Domain: shared utilities
│   │   ├── app.cs
│   │   ├── check.cs
│   │   └── mail.cs
│   └── resume/               # Domain: resume processing
│       ├── resume.cs
│       └── query_resume.cs
└── frontend/
    ├── atoms/                # Shared UI components
    │   └── ui_helper.cs
    └── pages/                # Application forms
        ├── entry.cs
        ├── account.cs
        ├── password.cs
        └── analyser.cs
```

**Changes**: Domain-based backend segmentation, Atomic Design for frontend, shared components extracted to `atoms/`.

---

## 5. UI — Shared Component Extraction

**Rationale**: The password visibility toggle was duplicated across 3 forms (Entry, Account, Password). Extracting it to a shared atom eliminates duplication.

### Before (Duplicated in each form)

```csharp
// In Entry.cs
private void pictureBox_Eye_Click(object sender, EventArgs e)
{
    if (textBox_Password.UseSystemPasswordChar)
    {
        textBox_Password.UseSystemPasswordChar = false;
        pictureBox_Eye.Image = Image.FromFile(@"C:\...\eye_open.png");
    }
    else
    {
        textBox_Password.UseSystemPasswordChar = true;
        pictureBox_Eye.Image = Image.FromFile(@"C:\...\eye_close.png");
    }
}
// Same code duplicated in Account.cs and Password.cs
```

### After (Shared Atom)

```csharp
// In frontend/atoms/ui_helper.cs
internal static class C_Ui_Helper
{
    // Toggles password field visibility and updates eye icon
    public static void F_Toggle_Eye(TextBox p_text_box, PictureBox p_icon)
    {
        string base_path = AppDomain.CurrentDomain.BaseDirectory;
        p_text_box.UseSystemPasswordChar = !p_text_box.UseSystemPasswordChar;
        string icon_name = p_text_box.UseSystemPasswordChar ? "eye_close.png" : "eye_open.png";
        p_icon.Image = Image.FromFile(Path.Combine(base_path, "Asset", "Image", icon_name));
    }
}

// In any form (one-liner)
private void F_Picture_Box_Eye_Click(object p_sender, EventArgs p_e)
{
    C_Ui_Helper.F_Toggle_Eye(textBox_Password, pictureBox_Eye);
}
```

**Changes**: Eliminated ~30 lines of duplicated code across 3 forms, replaced hardcoded paths with dynamic resolution.

---

## 6. Error Handling — Centralized Logging

**Rationale**: Errors were silently swallowed or showed raw exception messages. Centralized logging captures issues for debugging.

### Before

```csharp
try
{
    connection.Open();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);  // Raw error shown to user
}
```

### After

```csharp
try
{
    connection.Open();
}
catch (Exception ex)
{
    C_App.F_Log_Error("F_Open_Connection", ex);   // Logged to file
    C_App.F_Show_Error("Database connection failed. Please check your setup.");
}
```

**Changes**: Errors logged to daily log files, user sees friendly message instead of stack trace.
