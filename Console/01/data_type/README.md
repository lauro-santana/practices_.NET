### Create a project

```
dotnet new console -n Console -o src/Console
```

### Create tests

```
dotnet new xunit -n Console.Tests -o tests/.Console.Tests
```
> xuint is a test framework

### Create service lib

```
dotnet new classlib -n Utils -o src/Utils
```

### Add a project to solution

```
dotnet sln add tests/Console.Tests/Console.Tests.csproj
```

#### Add project reference

```
dotnet add src/Console/Console.csproj reference src/Utils/Utils.csproj
```

### Remove a project from solution

```
dotnet sln list
```

```
dotnet sln remove
```

### Add a package to project

```
dotnet add benchmark/Utils package BenchmarkDotNet
```

### Running the project

```
dotnet run --project src/Console/
```

### Running tests

```
dotnet test
```

### Running benchmark

```
dotnet run -c Release
```
> In the benchmark project

```
dotnet run -c Release -- --method AsDecimal
```
> Run only one method