# Environment Setup

Step-by-step guide for setting up the CV Analyser development environment.

---

## Prerequisites

| Tool                       | Version       | Required                 |
| -------------------------- | ------------- | ------------------------ |
| Visual Studio              | 2019 or later | ✅                        |
| .NET Framework SDK         | 4.8           | ✅                        |
| SQL Server Express LocalDB | 2019+         | ✅                        |
| Git                        | 2.x           | ✅                        |
| NuGet CLI                  | Latest        | Optional (VS handles it) |

### Visual Studio Workloads

Install the following workloads via the Visual Studio Installer:

- **.NET Desktop Development** — Required for WinForms
- **Data storage and processing** — Required for LocalDB tools

---

## Step-by-Step Setup

### 1. Clone the Repository

```bash
git clone https://github.com/beydah/CV-Analyser.git
cd CV-Analyser
```

### 2. Open in Visual Studio

Open `CV_Analyser.sln` in Visual Studio. The solution contains a single project targeting .NET Framework 4.8.

### 3. Restore NuGet Packages

Visual Studio will automatically prompt to restore packages. If not:

- Right-click the solution in Solution Explorer
- Select **Restore NuGet Packages**

Or from the command line:

```bash
nuget restore CV_Analyser.sln
```

### Packages Restored

| Package         | Version  | Purpose              |
| --------------- | -------- | -------------------- |
| iTextSharp      | 5.5.13.3 | PDF text extraction  |
| Newtonsoft.Json | 13.0.4   | JSON serialization   |
| BouncyCastle    | 1.8.9    | Cryptography support |

### 4. Verify LocalDB

Confirm LocalDB is installed and running:

```bash
sqllocaldb info MSSQLLocalDB
```

If it doesn't exist, create it:

```bash
sqllocaldb create MSSQLLocalDB
sqllocaldb start MSSQLLocalDB
```

### 5. Build the Project

Press **Ctrl+Shift+B** in Visual Studio, or from the command line:

```bash
msbuild CV_Analyser.csproj /p:Configuration=Debug
```

Expected result: **0 errors**.

### 6. Run the Application

Press **F5** in Visual Studio, or:

```bash
.\bin\Debug\CV_Analyser.exe
```

---

## Project Configuration

### App.config

Runtime configuration is stored in `App.config` at the project root. Key settings:

| Setting            | Purpose                    |
| ------------------ | -------------------------- |
| `supportedRuntime` | Targets .NET Framework 4.8 |
| Connection strings | LocalDB database path      |

### Asset Directory

Static resources (icons, images) are stored in `Asset/`:

```
Asset/
├── Icon/       # Application icons (.ico)
└── Image/      # UI images (eye toggle, back arrow, etc.)
```

The application resolves asset paths dynamically using `AppDomain.CurrentDomain.BaseDirectory`.

---

## Troubleshooting

| Problem                      | Solution                                                                                                      |
| ---------------------------- | ------------------------------------------------------------------------------------------------------------- |
| NuGet packages not restoring | Delete `packages/` folder and restore again                                                                   |
| LocalDB connection failed    | Run `sqllocaldb start MSSQLLocalDB`                                                                           |
| Build errors after checkout  | Clean solution (Build → Clean Solution) then rebuild                                                          |
| Missing .NET 4.8 SDK         | Install via VS Installer or [download directly](https://dotnet.microsoft.com/download/dotnet-framework/net48) |
