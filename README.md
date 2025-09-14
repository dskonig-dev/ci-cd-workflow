# Time.API CI/CD Workflow

This repository manages the Continuous Integration and Continuous Deployment (CI/CD) workflows for the Time.API project.

## Overview

The project leverages automated pipelines to ensure code quality, streamline deployments, and maintain consistency across environments. The CI/CD process is defined using workflow files located in the `.github/workflows` directory.

## Workflow Features

- **Automated Builds:** Every commit or pull request triggers a build process to validate the integrity of the codebase.
- **Testing:** Automated tests are executed as part of the pipeline to ensure reliability and prevent regressions.
- **Deployment:** Successful builds can be automatically deployed to target environments, such as Azure Web Apps.
- **Status Checks:** The workflow provides feedback on build and deployment status directly within pull requests.

## Getting Started

To contribute or trigger the CI/CD workflows:
1. Fork or clone the repository.
2. Push changes or open a pull request.
3. The workflows will run automatically based on the defined triggers.

## Workflow Files

- `.github/workflows/ci-cd.yml`: Defines the main CI/CD pipeline.
- `.github/workflows/ci-cd-azure-webs-apps.yml`: Handles deployment to Azure Web Apps.

## Requirements

- A supported .NET SDK (the project targets .NET 9).
- Appropriate permissions and secrets configured for deployment targets (e.g., Azure credentials).

## Based

This repository follows practices shared by [Milan Jovanovic]( https://github.com/m-jovanovic)

---

*This README focuses on the CI/CD workflow and does not include any source code.*
