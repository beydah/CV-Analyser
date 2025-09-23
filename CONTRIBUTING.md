# Contributing to CV Analyser

Thank you for considering contributing to CV Analyser! We appreciate your interest in helping us improve this project. This document provides guidelines and instructions for contributing to the project.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Getting Started](#getting-started)
- [How to Contribute](#how-to-contribute)
  - [Reporting Bugs](#reporting-bugs)
  - [Suggesting Enhancements](#suggesting-enhancements)
  - [Your First Code Contribution](#your-first-code-contribution)
  - [Pull Requests](#pull-requests)
- [Development Environment Setup](#development-environment-setup)
- [Coding Standards](#coding-standards)
- [Commit Message Guidelines](#commit-message-guidelines)
- [License](#license)

## Code of Conduct

This project and everyone participating in it is governed by our [Code of Conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to info.beydahsaglam@gmail.com.

## Getting Started

1. **Fork** the repository on GitHub
2. **Clone** your fork locally
   ```bash
   git clone https://github.com/your-username/cv_analyser.git
   cd cv_analyser
   ```
3. Add the original repository as a remote
   ```bash
   git remote add upstream https://github.com/beydah/cv_analyser.git
   ```
4. Create a new branch for your changes
   ```bash
   git checkout -b feature/your-feature-name
   ```

## How to Contribute

### Reporting Bugs

1. **Check Existing Issues**: Before creating a new issue, please check if the bug has already been reported.
2. **Create an Issue**: If you're the first to report the bug, create a new issue with a clear title and description.
3. **Bug Report Template**:
   ```markdown
   ## Description
   
   [Detailed description of the bug]
   
   ## Steps to Reproduce
   1. [First Step]
   2. [Second Step]
   3. [And so on...]
   
   **Expected behavior:** [What you expected to happen]
   
   **Actual behavior:** [What actually happened]
   
   **Screenshots:** [If applicable, add screenshots to help explain your problem]
   
   ## System Information
   - OS: [e.g., Windows 10]
   - .NET Version: [e.g., .NET 4.7.2]
   - Application Version: [e.g., 1.0.0]
   ```

### Suggesting Enhancements

1. **Check Existing Suggestions**: Before suggesting an enhancement, please check if it has already been suggested.
2. **Create an Enhancement Issue**: Use the enhancement template to describe your suggestion.
3. **Enhancement Template**:
   ```markdown
   ## Description
   
   [Detailed description of the enhancement]
   
   ## Why is this feature important?
   [Explain why this feature would be valuable]
   
   ## Proposed Solution
   [Describe your proposed solution]
   
   ## Alternative Solutions
   [List any alternative solutions or features you've considered]
   ```

### Your First Code Contribution

1. Find an issue labeled "good first issue" or "help wanted"
2. Comment on the issue to let others know you're working on it
3. Follow the development setup instructions below
4. Make your changes and submit a pull request

### Pull Requests

1. Ensure your code follows the project's coding standards
2. Update the documentation if necessary
3. Add tests for your changes
4. Ensure all tests pass
5. Submit your pull request with a clear title and description

## Development Environment Setup

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- SQL Server Express LocalDB
- Git

### Setup Steps

1. Clone the repository
2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Build the solution (Ctrl+Shift+B)
5. Run the application (F5)

### Running Tests

```bash
dotnet test
```

## Coding Standards

### C# Coding Conventions

- Use PascalCase for class names and method names
- Use camelCase for local variables and method parameters
- Use _camelCase for private fields
- Use UPPER_CASE for constants
- Use meaningful and descriptive names
- Add XML documentation for public members

### Code Formatting

- Use 4 spaces for indentation (no tabs)
- Use braces `{}` even for single-line statements
- Add a space after keywords (e.g., `if (condition)`)
- Add a space before and after operators (e.g., `x = y + z`)
- Place opening braces on the same line

### Naming Conventions

- Prefix interface names with 'I' (e.g., `IResumeParser`)
- Suffix exception classes with 'Exception' (e.g., `InvalidFormatException`)
- Use meaningful and descriptive names
- Avoid abbreviations unless they are well-known

## Commit Message Guidelines

We follow the [Conventional Commits](https://www.conventionalcommits.org/) specification for commit messages:

```
<type>[optional scope]: <description>

[optional body]

[optional footer(s)]
```

### Types

- **feat**: A new feature
- **fix**: A bug fix
- **docs**: Documentation only changes
- **style**: Changes that do not affect the meaning of the code (white-space, formatting, etc.)
- **refactor**: A code change that neither fixes a bug nor adds a feature
- **perf**: A code change that improves performance
- **test**: Adding missing tests or correcting existing tests
- **chore**: Changes to the build process or auxiliary tools and libraries

### Examples

```
feat(parser): add support for PDF/A format

Add support for parsing PDF/A compliant documents in the resume parser.

Closes #123
```

```
fix(ui): correct button alignment in main form

- Fix alignment of the analyze button
- Update button styles for better visibility

Fixes #124
```

## License

By contributing to CV Analyser, you agree that your contributions will be licensed under its MIT License.

---

Thank you for contributing to CV Analyser! Your help is greatly appreciated.

**Developer Contact:**
- **Website**: [beydahsaglam.com](https://beydahsaglam.com)
- **Email**: [info.beydahsaglam@gmail.com](mailto:info.beydahsaglam@gmail.com)
- **LinkedIn**: [beydah](https://linkedin.com/in/beydah)
- **GitHub**: [beydah](https://github.com/beydah)
