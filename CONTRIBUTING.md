# Contributing to CV Analyser

Thank you for your interest in contributing! This guide covers the coding standards, workflow, and conventions used in this project.

## Table of Contents

- [Getting Started](#getting-started)
- [Development Workflow](#development-workflow)
- [Coding Standards](#coding-standards)
- [File & Region Structure](#file--region-structure)
- [Commit Messages](#commit-messages)
- [Pull Requests](#pull-requests)
- [Reporting Issues](#reporting-issues)

---

## Getting Started

1. **Fork** this repository on GitHub
2. **Clone** your fork:
   ```bash
   git clone https://github.com/your-username/CV-Analyser.git
   cd CV-Analyser
   ```
3. **Add upstream remote**:
   ```bash
   git remote add upstream https://github.com/beydah/CV-Analyser.git
   ```
4. **Create a feature branch**:
   ```bash
   git checkout -b feature/your-feature-name
   ```
5. Follow the [Environment Setup](docs/environment_setup.md) guide to configure your development environment.

---

## Development Workflow

1. Sync your fork with upstream before starting work
2. Create a branch from `main` using the naming convention below
3. Make focused, atomic commits
4. Ensure the project builds with **0 errors** before submitting
5. Submit a Pull Request with a clear description

### Branch Naming

| Type     | Pattern                      | Example                    |
| -------- | ---------------------------- | -------------------------- |
| Feature  | `feature/short-description`  | `feature/password-hashing` |
| Bugfix   | `fix/short-description`      | `fix/email-validation`     |
| Docs     | `docs/short-description`     | `docs/deployment-guide`    |
| Refactor | `refactor/short-description` | `refactor/async-queries`   |

---

## Coding Standards

### Naming Conventions

All code must follow the enterprise naming conventions:

| Element                 | Convention      | Example                               |
| ----------------------- | --------------- | ------------------------------------- |
| **Classes**             | `C_Snake_Case`  | `C_Analyser`, `C_Check`               |
| **Functions/Methods**   | `F_Snake_Case`  | `F_Browser_Start`, `F_Is_Valid_Email` |
| **Parameters**          | `p_snake_case`  | `p_email`, `p_password`               |
| **Constants / Globals** | `SNAKE_CASE`    | `APP_NAME`, `DB_PATH`                 |
| **Local variables**     | `snake_case`    | `digit_count`, `base_path`            |
| **Files**               | `snake_case.cs` | `query_account.cs`, `ui_helper.cs`    |

### Comment Rules

- **Single-line English comments only** — no multi-line `/* */` blocks
- Comments must be placed **under** regions, classes, or functions
- Every function and class must have a comment describing its purpose

```csharp
#region FUNCTIONS
// Validates email format using a standard regex
public static bool F_Is_Valid_Email(string p_email)
{
    if (string.IsNullOrWhiteSpace(p_email)) return false;
    return Regex.IsMatch(p_email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
}
#endregion
```

---

## File & Region Structure

Every source file must contain **5–10 global regions** in this order:

```csharp
#region HEADER
// File: filename.cs
// Project: CV_Analyser
// Description: Brief file description
#endregion

#region LIBRARIES
using System;
// ... other using statements
#endregion

#region CONSTANTS
// Global constants for this module
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
            // implementation
        }
        #endregion
    }
    #endregion
}
```

### Directory Rules

| Rule                             | Limit |
| -------------------------------- | ----- |
| Max root directories             | 5     |
| Max subdirectories per directory | 10    |
| Max files per directory          | 15    |

---

## Commit Messages

Follow the [Conventional Commits](https://www.conventionalcommits.org/) specification:

```
<type>(scope): <description>

[optional body]
```

### Types

| Type       | Description                                             |
| ---------- | ------------------------------------------------------- |
| `feat`     | New feature                                             |
| `fix`      | Bug fix                                                 |
| `docs`     | Documentation changes                                   |
| `refactor` | Code change that neither fixes a bug nor adds a feature |
| `perf`     | Performance improvement                                 |
| `style`    | Formatting, whitespace (no logic change)                |
| `chore`    | Build process, tooling, dependencies                    |

### Example

```
feat(resume): add university keyword weighting

Add optional boolean flag to weight university-related
keywords during CV analysis scoring.
```

---

## Pull Requests

1. Ensure the project builds with **0 errors** (`msbuild CV_Analyser.csproj /p:Configuration=Debug`)
2. Follow all naming conventions and region rules
3. Update documentation if your change affects the architecture or API
4. Write a clear PR description explaining **what** and **why**
5. Reference any related issues using `Closes #123` or `Fixes #456`

---

## Reporting Issues

### Bug Reports

Use the [Bug Report template](.github/ISSUE_TEMPLATE/bug_report.md) and include:
- Steps to reproduce
- Expected vs actual behavior
- OS and .NET Framework version
- Screenshots if applicable

### Feature Requests

Use the [Feature Request template](.github/ISSUE_TEMPLATE/feature_request.md) and describe:
- The problem your feature solves
- Your proposed solution
- Alternative approaches considered

---

## License

By contributing to CV Analyser, you agree that your contributions will be licensed under the project's [MIT License](LICENSE).

---

**Developer Contact:**
- **Website**: [beydahsaglam.com](https://beydahsaglam.com)
- **Email**: [info.beydahsaglam@gmail.com](mailto:info.beydahsaglam@gmail.com)
- **LinkedIn**: [beydah](https://linkedin.com/in/beydah)
- **GitHub**: [beydah](https://github.com/beydah)
