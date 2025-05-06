# Clean Architecture Boilerplate

A .NET 8 Web API project template following Clean Architecture principles and Domain-Driven Design (DDD) practices.

## Project Structure

The solution is organized into the following projects:

- **CleanArchitectureBoilerplate.API**: Web API project (Startup project)
- **CleanArchitectureBoilerplate.Domain**: Domain layer containing entities and business rules
- **CleanArchitectureBoilerplate.Application**: Application layer containing business logic and interfaces
- **CleanArchitectureBoilerplate.Infrastructure**: Infrastructure layer containing implementations
- **CleanArchitectureBoilerplate.Tests**: Test project for all layers

## Architecture

This solution follows Clean Architecture principles:

1. **Domain Layer**: Contains enterprise business rules and entities
2. **Application Layer**: Contains business use cases and interfaces
3. **Infrastructure Layer**: Implements interfaces defined in the Application layer
4. **API Layer**: Entry point for the application, contains controllers and API endpoints

## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code

### Running the Application

1. Clone the repository
2. Open the solution in Visual Studio or VS Code
3. Restore NuGet packages
4. Run the application

```bash
dotnet restore
dotnet run --project CleanArchitectureBoilerplate.API
```

The API will be available at `https://localhost:5001` and `http://localhost:5000`.

## Testing

Run the tests using:

```bash
dotnet test
```

## License

This project is licensed under the MIT License. 