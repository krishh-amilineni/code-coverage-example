# Code Coverage Tools Examples

This document provides an overview of the various code coverage tools that have been set up as example workflows in this repository. Each workflow automatically runs on a weekly schedule and generates coverage badges that are displayed on this page.

## Available Examples

All example workflows are located in the `.github/workflows/examples/` directory and automatically deploy reports to GitHub Pages.

### 1. Coverlet (With ReportGenerator)

**File**: [coverlet-example.yml](./.github/workflows/examples/coverlet-example.yml)

**Description**: Coverlet is built into .NET SDK and is the most straightforward option for .NET Core projects. This example demonstrates collecting coverage with Coverlet and generating HTML reports with ReportGenerator.

**Coverage Badge**: ![Coverlet Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/coverlet/badge.svg)

**Key Features**:
- Native .NET Core integration
- Minimal configuration required
- HTML report generation

### 2. OpenCover

**File**: [opencover-example.yml](./.github/workflows/examples/opencover-example.yml)

**Description**: OpenCover is a traditional .NET Framework coverage tool that's been adapted to work with .NET Core. It runs on Windows and provides detailed coverage metrics.

**Coverage Badge**: ![OpenCover Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/opencover/badge.svg)

**Key Features**:
- Branch and sequence coverage support
- Fine-grained filtering options
- Compatible with both .NET Framework and .NET Core

### 3. Codecov

**File**: [codecov-example.yml](./.github/workflows/examples/codecov-example.yml)

**Description**: Codecov is a third-party service that provides coverage reporting, visualization, and PR integration.

**Coverage Badge**: ![Codecov Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/codecov/badge.svg)

**Key Features**:
- GitHub Pull Request integration
- Historical coverage trending
- Coverage impact analysis for PRs

**Note**: Requires a `CODECOV_TOKEN` secret to be configured for full functionality.

### 4. SonarQube

**File**: [sonarqube-example.yml](./.github/workflows/examples/sonarqube-example.yml)

**Description**: SonarQube is a comprehensive code quality platform that includes coverage reporting as part of its analysis.

**Coverage Badge**: ![SonarQube Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/sonarqube/badge.svg)

**Key Features**:
- Complete code quality analysis beyond just coverage
- Technical debt tracking
- Security vulnerability detection

**Note**: Requires `SONAR_TOKEN` and `SONAR_HOST_URL` secrets to be configured for full functionality.

### 5. Code Climate

**File**: [codeclimate-example.yml](./.github/workflows/examples/codeclimate-example.yml)

**Description**: Code Climate is a code quality platform that provides automated code reviews and test coverage monitoring.

**Coverage Badge**: ![Code Climate Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/codeclimate/badge.svg)

**Key Features**:
- Code quality metrics
- Security vulnerability detection
- Maintainability tracking

**Note**: Requires a `CC_TEST_REPORTER_ID` secret to be configured for full functionality.

### 6. AltCover

**File**: [altcover-example.yml](./.github/workflows/examples/altcover-example.yml)

**Description**: AltCover is designed specifically for .NET Core with support for edge cases that other tools might miss.

**Coverage Badge**: ![AltCover Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/altcover/badge.svg)

**Key Features**:
- Strong support for .NET Core and new .NET features
- Command-line driven workflow
- Flexible output format options

### 7. Coveralls

**File**: [coveralls-example.yml](./.github/workflows/examples/coveralls-example.yml)

**Description**: Coveralls is a web service to help track code coverage over time, and ensure that all new code is fully covered.

**Coverage Badge**: ![Coveralls Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/coveralls/badge.svg)

**Key Features**:
- Historical coverage trending
- GitHub Pull Request annotations
- Team collaboration features

### 8. dotCover

**File**: [dotcover-example.yml](./.github/workflows/examples/dotcover-example.yml)

**Description**: JetBrains dotCover is a .NET coverage tool that integrates well with other JetBrains products.

**Coverage Badge**: ![dotCover Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/dotcover/badge.svg)

**Key Features**:
- Integration with JetBrains ecosystem
- Statement, branch, and method coverage
- Customizable HTML reports

### 9. Cobertura Format

**File**: [cobertura-example.yml](./.github/workflows/examples/cobertura-example.yml)

**Description**: While Cobertura itself is a Java tool, its report format is widely adopted. This workflow demonstrates generating coverage in the Cobertura XML format.

**Coverage Badge**: ![Cobertura Coverage](https://krishh-amilineni.github.io/code-coverage-example/tools/cobertura/badge.svg)

**Key Features**:
- Widely supported format for integration with various tools
- Compatible with many CI systems
- Standardized reporting schema

## Viewing Coverage Reports

All coverage reports are automatically deployed to GitHub Pages and can be accessed at:

- [Coverage Tools Comparison](https://krishh-amilineni.github.io/code-coverage-example/tools/index.html)
- Individual tool reports are available at `https://krishh-amilineni.github.io/code-coverage-example/tools/{tool-name}/`

## Comparison of Coverage Tools

| Tool | Primary Language | Cloud/Self-hosted | PR Integration | Special Features | Auto-Run Schedule |
|------|-----------------|-------------------|---------------|------------------|-------------------|
| Coverlet + ReportGenerator | .NET | Self-hosted | No | Native .NET integration | Weekly (Sunday 0:00) |
| OpenCover | .NET | Self-hosted | No | Legacy .NET Framework support | Weekly (Sunday 1:00) |
| Codecov | Any | Cloud | Yes | PR comments, badge generation | Weekly (Sunday 2:00) |
| SonarQube | Any | Both | Yes | Full code quality suite | Weekly (Sunday 3:00) |
| Code Climate | Any | Cloud | Yes | Maintainability metrics | Weekly (Sunday 4:00) |
| AltCover | .NET | Self-hosted | No | Strong .NET Core support | Weekly (Sunday 5:00) |
| Coveralls | Any | Cloud | Yes | Coverage trending | Weekly (Sunday 6:00) |
| dotCover | .NET | Self-hosted | Via TeamCity | JetBrains integration | Weekly (Sunday 7:00) |
| Cobertura (format) | Java/.NET | N/A | No | Standard format | Weekly (Sunday 8:00) |
