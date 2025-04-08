# .NET Code Coverage Example

![Coverage](https://krishh-amilineni.github.io/code-coverage-example/branches/main/coverage-badge.svg) [![.NET Test and Coverage Deployment](https://github.com/krishh-amilineni/code-coverage-example/actions/workflows/dotnet-test-and-deploy-coverage.yml/badge.svg)](https://github.com/krishh-amilineni/code-coverage-example/actions/workflows/dotnet-test-and-deploy-coverage.yml)

## Description
This is a project to highlight best practices for code coverage in .NET pipelines. It is composed of two simple projects, Demo-App to house our apps code and Demo-App-Tests to house our tests code.

## Implemented Coverage Features

- **Local-only Coverage Analysis**: Coverage reports are generated without source linking to GitHub
- **Deterministic Builds**: Consistent coverage results across builds
- **Visual Reporting**: HTML reports and coverage badge integration
- **GitHub Pages Integration**: Published reports for easy access
- **Branch-Specific Reports**: Each branch has its own coverage report
- **Combined Workflow**: Single workflow handling both testing and reporting

## CI/CD Pipeline Integration

The GitHub workflow includes these coverage features:

- Collection of coverage in multiple formats (JSON, LCOV, Cobertura)
- Direct XML parsing to extract accurate coverage percentages
- Coverage badge generation based on actual line coverage
- Branch-specific report deployment to GitHub Pages
- Single unified workflow for testing and report deployment

## Alternative Coverage Tools

This repository includes examples of multiple code coverage tools for .NET and other platforms:

- **Coverlet**: Native .NET Core integration (our primary example)
- **OpenCover**: Traditional .NET coverage tool
- **Codecov**: Cloud-based coverage platform with PR integration
- **SonarQube**: Complete code quality platform
- **Code Climate**: Code quality and coverage analysis
- **AltCover**: .NET Core specific coverage tool
- **Coveralls**: Cloud-based coverage trending
- **dotCover**: JetBrains' coverage solution
- **Cobertura**: Format-based coverage reporting

See [Coverage Tools Examples](./coverage-tools-examples.md) for detailed information on each tool.

## Local Development

To run tests with coverage locally:

```
dotnet test --settings coverage.runsettings
```

## View Coverage Reports

Reports are published to GitHub Pages with each branch build:
- [View Main Branch Coverage Report](https://krishh-amilineni.github.io/code-coverage-example/branches/main/index.html)
- [View All Branch Reports](https://krishh-amilineni.github.io/code-coverage-example/)

> Note: It may take a few minutes for GitHub Pages to build and deploy after a workflow run. If you encounter a 404 error, please wait a moment and try again.
