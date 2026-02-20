# Deployment Guide

## Build from Source

### Prerequisites

- **Visual Studio 2019+** or **MSBuild 15+**
- **.NET Framework 4.8 SDK**
- **NuGet CLI** (for command-line restore)

### Debug Build

```bash
# Restore NuGet packages
nuget restore CV_Analyser.sln

# Build in Debug mode
msbuild CV_Analyser.csproj /p:Configuration=Debug

# Output: bin\Debug\CV_Analyser.exe
```

### Release Build

```bash
# Build in Release mode (optimized)
msbuild CV_Analyser.csproj /p:Configuration=Release

# Output: bin\Release\CV_Analyser.exe
```

---

## Distribution

### Standalone Executable

The Release build produces a self-contained output in `bin\Release\`:

```
bin\Release\
├── CV_Analyser.exe              # Main executable
├── CV_Analyser.exe.config       # Runtime configuration
├── itextsharp.dll               # PDF processing
├── Newtonsoft.Json.dll           # JSON serialization
└── BouncyCastle.Crypto.dll      # Cryptography
```

To distribute:
1. Build in Release configuration
2. Copy the entire `bin\Release\` directory
3. Ensure the target machine has **.NET Framework 4.8** installed

### End-User Prerequisites

| Requirement        | Version | Notes                                                                    |
| ------------------ | ------- | ------------------------------------------------------------------------ |
| Windows            | 10+     | Earlier versions may work with .NET 4.8 installed                        |
| .NET Framework     | 4.8     | [Download](https://dotnet.microsoft.com/download/dotnet-framework/net48) |
| SQL Server LocalDB | 2019+   | Required for user accounts and resume data                               |

---

## Database Setup

The application uses SQL Server Express LocalDB with an `.mdf` file stored in the application's data directory.

### First Run

1. Ensure LocalDB is installed (included with Visual Studio or downloadable separately)
2. The application will connect to the database on startup
3. If the database does not exist, create it using SQL Server Management Studio or `sqlcmd`

### Connection String

The default connection is configured in `App.config`. Modify the `Data Source` if your LocalDB instance name differs:

```xml
<connectionStrings>
  <add name="CV_Analyser"
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Analyser_DB.mdf;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

---

## CI/CD

The project includes a GitHub Actions workflow (`.github/workflows/dotnet-desktop.yml`) that:

1. Triggers on `push` and `pull_request` to `main`
2. Restores NuGet packages
3. Builds in both Debug and Release configurations
4. Uploads build artifacts

See the workflow file for configuration details.
