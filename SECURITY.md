# Security Policy

## Supported Versions

| Version | .NET Framework | Status                |
| ------- | -------------- | --------------------- |
| 1.x     | 4.8            | ✅ Actively maintained |

## Reporting a Vulnerability

If you discover a security vulnerability in CV Analyser, please report it responsibly.

### How to Report

1. **Email**: Send a detailed report to [info.beydahsaglam@gmail.com](mailto:info.beydahsaglam@gmail.com)
2. **Subject line**: `[SECURITY] CV-Analyser — Brief description`
3. **Include**:
   - Description of the vulnerability
   - Steps to reproduce
   - Potential impact
   - Suggested fix (if any)

### Response Timeline

| Stage              | Timeframe       |
| ------------------ | --------------- |
| Acknowledgment     | Within 48 hours |
| Initial assessment | Within 7 days   |
| Fix or mitigation  | Within 30 days  |

### What to Expect

- We will acknowledge your report within 48 hours
- We will work with you to understand and validate the issue
- A fix will be prioritized based on severity
- You will be credited in the release notes (unless you prefer anonymity)

### Please Do Not

- Open a public GitHub issue for security vulnerabilities
- Exploit the vulnerability beyond what is necessary to demonstrate it
- Share the vulnerability with others before it is resolved

## Known Security Considerations

| Area              | Current State                   | Planned Improvement              |
| ----------------- | ------------------------------- | -------------------------------- |
| Password storage  | Plaintext in database           | Bcrypt/PBKDF2 hashing            |
| Database          | SQL Server LocalDB (local only) | Parameterized queries verified   |
| Email credentials | Hardcoded in source             | Move to App.config / env vars    |
| Input validation  | Regex-based validation          | Already centralized in `C_Check` |
| Process execution | `UseShellExecute = true`        | URL whitelist validation         |

> See the [Refactor Roadmap](docs/refactor_roadmap.md) for the full improvement plan.
