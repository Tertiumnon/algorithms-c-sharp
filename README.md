# C# algorithms

## Preparations

### Create new project

Don't do it if you're already did it.

```bash
dotnet new console -o algorithms-csharp
```

## Installation

Please watch the [video](https://channel9.msdn.com/Blogs/dotnet/Get-started-VSCode-Csharp-NET-Core-Windows)

Install [.Net Core SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

### Get packages

```bash
dotnet restore
```

### Run program

```bash
dotnet run
```

## Usage

### Create a new class library

```bash
dotnet new classlib -o ./libs/LibName
dotnet sln add ./libs/LibName/LibName.csproj
```

### Create tests

```bash
dotnet new xunit -o ./libs/LibName.Tests
dotnet sln add ./libs/LibName.Tests/LibName.Tests.csproj
#dotnet add ./libs/LibName.Tests/LibName.Tests.csproj reference ./libs/LibName/LibName.csproj
```
