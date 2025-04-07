# .NET Code Coverage Example

![Coverage](https://img.shields.io/badge/dynamic/json?url=https://raw.githubusercontent.com/krishh-amilineni/code-coverage-example/gh-pages/coverage-report/summary.json&label=coverage&query=$.coverage[0].value&color=brightgreen&suffix=%25) [![Build and Test](https://github.com/krishh-amilineni/code-coverage-example/actions/workflows/dotnet-build-and-test-flow.yml/badge.svg)](https://github.com/krishh-amilineni/code-coverage-example/actions/workflows/dotnet-build-and-test-flow.yml)

## Description
This is a project to highlight best practices for code coverage in .NET pipelines. It is composed of two simple projects, Demo-App to house our apps code and Demo-App-Tests to house our tests code.

## Optimized Coverage Features

- **Source Linking**: Enhanced report navigation to original GitHub source
- **Deterministic Builds**: Consistent coverage results across builds
- **Comprehensive Test Suite**: Complete branch and line coverage
- **Historical Trends**: Tracking coverage trends over time
- **Quality Gates**: Enforcing high coverage standards (90%+)
- **Visual Reporting**: HTML, Badge, and PR Comment integration
- **Incremental Analysis**: Focus on changes in each PR
- **GitHub Pages Integration**: Published reports for easy access

## CI/CD Pipeline Integration

The GitHub workflow includes advanced coverage features:

- Collection of coverage in multiple formats (JSON, LCOV, Cobertura)
- Historical trend tracking
- Quality gates with threshold enforcement
- Automatic PR feedback

## Local Development

To run tests with coverage locally:

```
dotnet test --settings coverage.runsettings
```

## View Coverage Reports

Reports are published to GitHub Pages with each main branch build: [View Latest Coverage Report](https://krishh-amilineni.github.io/code-coverage-example/coverage-report/)
