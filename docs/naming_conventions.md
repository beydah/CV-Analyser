# Naming Conventions

This document defines the mandatory naming conventions for all source files in CV Analyser.

---

## Identifier Naming

| Element                 | Convention     | Example           | Notes                                           |
| ----------------------- | -------------- | ----------------- | ----------------------------------------------- |
| **Classes**             | `C_Snake_Case` | `C_Analyser`      | Prefix `C_`, then PascalWords joined by `_`     |
| **Functions / Methods** | `F_Snake_Case` | `F_Browser_Start` | Prefix `F_`, then PascalWords joined by `_`     |
| **Parameters**          | `p_snake_case` | `p_email`         | Prefix `p_`, then lowercase words joined by `_` |
| **Constants / Globals** | `SNAKE_CASE`   | `APP_NAME`        | All uppercase, words joined by `_`              |
| **Local variables**     | `snake_case`   | `digit_count`     | All lowercase, words joined by `_`              |

### Examples

```csharp
// Class
internal static class C_Check { }

// Function with parameters
public static bool F_Is_Valid_Email(string p_email)
{
    // Local variable
    bool is_valid = Regex.IsMatch(p_email, PATTERN);
    return is_valid;
}
```

---

## File Naming

| Type           | Convention               | Example                 |
| -------------- | ------------------------ | ----------------------- |
| Source files   | `snake_case.cs`          | `query_account.cs`      |
| Designer files | `snake_case.designer.cs` | `entry.designer.cs`     |
| Resource files | `snake_case.resx`        | `analyser.resx`         |
| Markdown docs  | `snake_case.md`          | `naming_conventions.md` |

---

## Region Rules

Every source file must contain **5–10 global regions** in the following order:

| #   | Region      | Required | Content                           |
| --- | ----------- | -------- | --------------------------------- |
| 1   | `HEADER`    | ✅        | File name, project, description   |
| 2   | `LIBRARIES` | ✅        | `using` statements                |
| 3   | `CONSTANTS` | Optional | Global constants                  |
| 4   | `CLASSES`   | ✅        | Class definitions                 |
| 5   | `FUNCTIONS` | ✅        | Method definitions (inside class) |
| 6   | `UTILITIES` | Optional | Helper/private methods            |

### Template

```csharp
#region HEADER
// File: example.cs
// Project: CV_Analyser
// Description: Brief description
#endregion

#region LIBRARIES
using System;
#endregion

namespace CV_Analyser.Backend.Core
{
    #region CLASSES
    // Description of the class
    internal class C_Example
    {
        #region FUNCTIONS
        // Description of the function
        public static void F_Do_Something(string p_input)
        {
            string result = p_input.Trim();
        }
        #endregion
    }
    #endregion
}
```

---

## Comment Rules

| Rule        | Details                                      |
| ----------- | -------------------------------------------- |
| Language    | English only                                 |
| Style       | Single-line (`//`) only — no `/* */` blocks  |
| Placement   | Under regions, classes, or functions         |
| Requirement | Every class and function must have a comment |

```csharp
// ✅ Correct
// Validates email format using a standard regex
public static bool F_Is_Valid_Email(string p_email)

// ❌ Incorrect — multi-line block
/* Validates email format
   using a standard regex */
public static bool F_Is_Valid_Email(string p_email)
```

---

## Directory Structure Rules

| Rule                             | Limit |
| -------------------------------- | ----- |
| Max root-level directories       | 5     |
| Max subdirectories per directory | 10    |
| Max files per directory          | 15    |
