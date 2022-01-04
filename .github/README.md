## Introduction
This folder contains the ***protocols*** CI/CD pipelines for generating and publishing [Nuget](https://www.nuget.org/profiles/perpetualintelligencellc) and [GitHub](https://github.com/orgs/perpetualintelligence/packages?repo_name=protocols) packages. 

The build and deploy include:
1. ***build-test-ci.yml***: The automated CI builds and tests the code changes.
2. ***build-test-publish.yml***: The manual release action publishes the packages to Nuget or GitHub, see [releases](https://github.com/perpetualintelligence/protocols/releases)
3. ***delete-packages.yml***:  The automated action cleans the packages every week and keeps the latest working version. For stable versions, refer to Nuget packages.

> The manual release requires approval.

## Package Versions
All packages within protocols follow [sematic](https://semver.org/) versioning schemes. The env file ***package_version.env*** defines the package versions.

## CI References
The *.csproj* references for CI and local development has the following syntax:
- ***local***: Project references for local development within the same repo
- ***cross***: Project references for local development across repos
- ***package***: Published package references for CI/CD and deployment

> PI_CI_REFERENCE environment variable (***local*** or ***cross***) needs to be set on dev machine . The ***package*** value is not supported on dev machine. 

## Composite Actions
The ***push-package*** composite action builds, tests, packs, and publishes the package to the feed.
