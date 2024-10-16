# Test-GitHub-Actions

This is a .NET project that demonstrates how to use GitHub Actions for Continuous Integration (CI) by running NUnit tests on a simple Calculator class. The project is set up to automatically test code whenever changes are pushed to the repository or pull requests are opened.

## Project Structure

- **Calculator.cs**: Contains the `Calculator` class with basic arithmetic methods: `Add`, `Subtract`, `Multiply`, and `Divide`.
- **Program.cs**: Entry point of the application.
- **MyApp.Tests**: Contains NUnit test cases for the `Calculator` class.
- **.github/workflows**: Contains the GitHub Actions workflow (`dotnet.yml`) for running the tests.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed on your machine.
- [NUnit](https://nunit.org/) installed as a testing framework.

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Alimv81/Github-Actions-Run-NunitTest.git
   ```
2. Navigate to the project directory:
   ```bash
   cd Github-Actions-Run-NunitTest
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Build the project:
   ```bash
   dotnet build
   ```

## Running Tests Locally

To run tests locally, use the following command:
```bash
dotnet test
```

This will run all NUnit test cases defined in the `MyApp.Tests` project and display the results.

## GitHub Actions CI

The project is set up to use GitHub Actions for CI. The workflow file (`.github/workflows/dotnet.yml`) is configured to:

- Run on every push or pull request.
- Restore dependencies and build the project.
- Run NUnit tests to verify the correctness of the `Calculator` class methods.

### GitHub Actions Workflow

Here's an overview of the workflow:

1. **Trigger**: The workflow is triggered on push or pull request events.
2. **Environment Setup**: It uses the `.NET 8.0` environment for building and testing.
3. **Steps**:
   - Restore dependencies.
   - Build the solution.
   - Run NUnit tests.

## Calculator Class

The `Calculator` class contains the following methods:

- `Add`: Adds two numbers.
- `Subtract`: Subtracts the second number from the first.
- `Multiply`: Multiplies two numbers.
- `Divide`: Divides the first number by the second (throws an exception if the divisor is zero).

The NUnit tests cover two of these methods to ensure their correctness.
