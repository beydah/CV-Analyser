<h1 align="center">CV Analyser</h1>

<p align="center">
  <strong>Keyword-based resume ranking and analysis for recruiters</strong>
</p>

<p align="center">
  <a href="https://github.com/beydah/CV-Analyser/actions"><img src="https://github.com/beydah/CV-Analyser/actions/workflows/dotnet-desktop.yml/badge.svg" alt="Build Status" /></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-green.svg" alt="License" /></a>
  <img src="https://img.shields.io/badge/.NET_Framework-4.8-purple.svg" alt=".NET Framework 4.8" />
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6.svg" alt="Windows" />
</p>

---

## Overview

CV Analyser is a Windows desktop application that processes PDF resumes, ranks candidates by keyword relevance, and exports filtered results. Built for recruiters and HR professionals who need to quickly identify top candidates from large applicant pools.

### Key Features

| Feature                | Description                                              |
| ---------------------- | -------------------------------------------------------- |
| **Batch PDF Analysis** | Process an entire folder of PDF resumes in one operation |
| **Keyword Ranking**    | Score and rank CVs based on user-defined keyword lists   |
| **Top 3 Spotlight**    | Visual display of the three highest-scoring candidates   |
| **Result Export**      | Copy top-ranked CVs to a named output folder             |
| **User Accounts**      | Login, registration, and password recovery via email     |
| **University Filter**  | Optional weighting for university-related keywords       |

---

## Project Structure

```
CV-Analyser/
├── backend/                    # Business logic & data layer
│   ├── auth/                   # Authentication queries
│   │   └── query_account.cs    # Account CRUD operations
│   ├── core/                   # Shared utilities
│   │   ├── app.cs              # App-level helpers & error handling
│   │   ├── check.cs            # Input validation
│   │   └── mail.cs             # Email dispatch (SMTP)
│   └── resume/                 # Resume processing
│       ├── resume.cs           # PDF parsing & keyword matching
│       └── query_resume.cs     # Resume DB operations
├── frontend/                   # UI layer (Atomic Design)
│   ├── atoms/                  # Shared UI components
│   │   └── ui_helper.cs        # Password toggle helper
│   └── pages/                  # Application forms
│       ├── entry.*             # Login / Sign-up
│       ├── account.*           # Account creation
│       ├── password.*          # Password recovery
│       └── analyser.*          # Main analysis workspace
├── asset/                      # Static resources
│   ├── Icon/                   # Application icons
│   └── Image/                  # UI images
├── docs/                       # Extended documentation
│   ├── architecture.md         # System architecture
│   ├── naming_conventions.md   # Coding standards
│   ├── deployment_guide.md     # Build & distribution
│   ├── environment_setup.md    # Dev environment setup
│   ├── refactor_roadmap.md     # Future improvements
│   └── code_examples.md        # Before/After examples
├── Properties/                 # Assembly metadata
├── Program.cs                  # Application entry point
├── App.config                  # Runtime configuration
└── CV_Analyser.csproj          # MSBuild project file
```

---

## Quick Start

### Prerequisites

- **Windows 10** or later
- **Visual Studio 2019+** with *.NET Desktop Development* workload
- **SQL Server Express LocalDB** (included with Visual Studio)

### Build & Run

```bash
# Clone the repository
git clone https://github.com/beydah/CV-Analyser.git
cd CV-Analyser

# Restore NuGet packages
nuget restore CV_Analyser.sln

# Build
msbuild CV_Analyser.csproj /p:Configuration=Release

# Run
.\bin\Release\CV_Analyser.exe
```

Or open `CV_Analyser.sln` in Visual Studio and press **F5**.

---

## Architecture

```
┌─────────────────────────────────────────────────┐
│                  Frontend (WinForms)             │
│  ┌──────────┐ ┌──────────┐ ┌──────────────────┐ │
│  │  Entry   │ │ Account  │ │    Analyser      │ │
│  │  Page    │ │  Page    │ │  (Main Form)     │ │
│  └────┬─────┘ └────┬─────┘ └────────┬─────────┘ │
│       │             │                │           │
│  ┌────┴─────────────┴────────────────┴─────────┐ │
│  │             UI Atoms (Shared)               │ │
│  └─────────────────────┬───────────────────────┘ │
├────────────────────────┼─────────────────────────┤
│                  Backend                         │
│  ┌─────────┐  ┌────────┴──────┐  ┌────────────┐ │
│  │  Auth   │  │    Core       │  │   Resume   │ │
│  │ Queries │  │ (App, Check,  │  │ (Parse,    │ │
│  │         │  │  Mail)        │  │  Rank, DB) │ │
│  └────┬────┘  └───────────────┘  └─────┬──────┘ │
├───────┼────────────────────────────────┼─────────┤
│       └──────────┐      ┌─────────────┘          │
│            SQL Server LocalDB (.mdf)             │
└─────────────────────────────────────────────────┘
```

> See [docs/architecture.md](docs/architecture.md) for a detailed breakdown.

---

## Naming Conventions

This project uses **enterprise naming conventions** enforced across all source files:

| Element    | Convention     | Example                               |
| ---------- | -------------- | ------------------------------------- |
| Classes    | `C_Snake_Case` | `C_Analyser`, `C_Check`               |
| Functions  | `F_Snake_Case` | `F_Browser_Start`, `F_Is_Valid_Email` |
| Parameters | `p_snake_case` | `p_email`, `p_password`               |
| Constants  | `SNAKE_CASE`   | `APP_NAME`, `DB_PATH`                 |
| Local vars | `snake_case`   | `digit_count`, `base_path`            |
| Files      | `snake_case`   | `query_account.cs`, `ui_helper.cs`    |

> See [docs/naming_conventions.md](docs/naming_conventions.md) for the full guide including region and comment rules.

---

## Dependencies

| Package                                                           | Version  | Purpose              |
| ----------------------------------------------------------------- | -------- | -------------------- |
| [iTextSharp](https://www.nuget.org/packages/iTextSharp)           | 5.5.13.3 | PDF text extraction  |
| [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) | 13.0.4   | JSON serialization   |
| [BouncyCastle](https://www.nuget.org/packages/BouncyCastle)       | 1.8.9    | Cryptography support |

---

## Documentation

| Document                                         | Description                 |
| ------------------------------------------------ | --------------------------- |
| [Architecture](docs/architecture.md)             | System design and data flow |
| [Naming Conventions](docs/naming_conventions.md) | Enterprise coding standards |
| [Environment Setup](docs/environment_setup.md)   | Developer onboarding        |
| [Deployment Guide](docs/deployment_guide.md)     | Build and distribution      |
| [Refactor Roadmap](docs/refactor_roadmap.md)     | Future improvement plan     |
| [Logging Strategy](docs/logging_strategy.md)     | Error handling and logging  |
| [Code Examples](docs/code_examples.md)           | Before/After refactoring    |
| [Contributing](CONTRIBUTING.md)                  | How to contribute           |
| [Security Policy](SECURITY.md)                   | Vulnerability reporting     |

---

## Contributing

We welcome contributions! Please read our [Contributing Guide](CONTRIBUTING.md) for coding standards, branch naming, and PR process.

## License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

## Contact

- **Developer**: [Beydah Sağlam](https://beydahsaglam.com)
- **Email**: [info.beydahsaglam@gmail.com](mailto:info.beydahsaglam@gmail.com)
- **LinkedIn**: [beydah](https://linkedin.com/in/beydah)
- **GitHub**: [beydah](https://github.com/beydah)