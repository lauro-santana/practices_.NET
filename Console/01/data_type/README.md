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

### Running the project

```
dotnet run --project src/Console/
```

### Running tests

```
dotnet test
```