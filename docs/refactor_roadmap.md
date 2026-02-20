# Refactor Roadmap

A prioritized improvement plan for CV Analyser, organized by effort and impact.

---

## Quick Wins

Low-effort, high-impact improvements that can be done immediately.

| #   | Improvement                                                 | File(s)                                    | Impact                               |
| --- | ----------------------------------------------------------- | ------------------------------------------ | ------------------------------------ |
| 1   | **Add `using` blocks** for `SqlConnection` and `SqlCommand` | `query_account.cs`, `query_resume.cs`      | Prevents connection leaks            |
| 2   | **Move email credentials** to `App.config`                  | `mail.cs`, `App.config`                    | Security — removes hardcoded secrets |
| 3   | **Add null checks** on all public method parameters         | All backend files                          | Prevents `NullReferenceException`    |
| 4   | **Read connection string** from `App.config`                | `query_account.cs`, `query_resume.cs`      | Configurable database path           |
| 5   | **Add input length limits** to UI textboxes                 | `entry.designer.cs`, `account.designer.cs` | Prevents excessive input             |

### Example: Connection String from App.config

```diff
- string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;...";
+ string connection = ConfigurationManager.ConnectionStrings["CV_Analyser"].ConnectionString;
```

---

## Mid-Term Improvements

Structural cleanup requiring moderate effort.

| #   | Improvement                                    | Scope                               | Impact                                    |
| --- | ---------------------------------------------- | ----------------------------------- | ----------------------------------------- |
| 1   | **Add async/await** for database queries       | All query files                     | Non-blocking UI during DB operations      |
| 2   | **Implement password hashing** (BCrypt/PBKDF2) | `query_account.cs`, `account.cs`    | Security — eliminates plaintext passwords |
| 3   | **Extract interfaces** for data access         | Backend layer                       | Enables mocking and unit testing          |
| 4   | **Split large methods** (>50 lines)            | `analyser.cs` `F_Button_Sort_Click` | Readability and testability               |
| 5   | **Add a unit test project**                    | New `CV_Analyser.Tests` project     | Regression prevention                     |
| 6   | **Replace JSON file store** with DB-only       | `resume.cs`, `query_resume.cs`      | Single source of truth                    |
| 7   | **Localization support**                       | Frontend pages                      | Multi-language readiness                  |

### Example: Async Database Query

```diff
- public static DataTable F_Get_Resumes(string p_query)
+ public static async Task<DataTable> F_Get_Resumes_Async(string p_query)
  {
-     using (var connection = new SqlConnection(CONNECTION))
+     using (var connection = new SqlConnection(CONNECTION))
      {
-         connection.Open();
+         await connection.OpenAsync();
          // ...
      }
  }
```

---

## Major Architectural Refactors

Large-scale transformations for long-term sustainability.

| #   | Improvement                                   | Effort     | Impact                                                       |
| --- | --------------------------------------------- | ---------- | ------------------------------------------------------------ |
| 1   | **Migrate to .NET 6/8+**                      | High       | Modern runtime, cross-platform potential, better performance |
| 2   | **Replace WinForms with WPF or MAUI**         | Very High  | Modern UI toolkit, MVVM pattern, data binding                |
| 3   | **Add Dependency Injection**                  | Medium     | Loose coupling, testability, configurable services           |
| 4   | **Implement Repository Pattern**              | Medium     | Abstraction over data access, swappable stores               |
| 5   | **Add logging framework** (Serilog/NLog)      | Low-Medium | Structured logging, multiple sinks (file, console, cloud)    |
| 6   | **Replace iTextSharp** with iText 7 or PdfPig | Medium     | Active maintenance, MIT licensing                            |

### Migration Path (.NET 6+)

```
Phase 1: Upgrade csproj to SDK-style format
Phase 2: Replace packages.config with PackageReference
Phase 3: Retarget to net6.0-windows
Phase 4: Update APIs (System.Drawing → SkiaSharp, etc.)
Phase 5: Add nullable reference types
```

---

## Priority Matrix

```
Impact
  ▲
  │  ┌─────────────┐  ┌─────────────┐
  │  │ Password     │  │ Migrate to  │
  │  │ Hashing      │  │ .NET 6+     │
  │  └─────────────┘  └─────────────┘
  │  ┌─────────────┐  ┌─────────────┐
  │  │ Move creds   │  │ Replace     │
  │  │ to config    │  │ WinForms    │
  │  └─────────────┘  └─────────────┘
  │  ┌─────────────┐
  │  │ Add using    │
  │  │ blocks       │
  │  └─────────────┘
  └──────────────────────────────────▶ Effort
      Low              Medium          High
```
