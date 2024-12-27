# Learn ASP.NET Core 8 MVC

I am learning ASP.NET Core 8 MVC from different sources.

## Reference(s)

> 1. <https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio-code>

## Movie Application

```powershell
dotnet new mvc -o MvcMovieApp
cd MvcMovieApp

dotnet restore
dotnet build

dotnet run
dotnet watch
```

## Route Parameters

> 1. <http://localhost:5262/Home/Welcome?name=Teja&numtimes=4>

## Tools and Packages

```powershell
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## Scaffold

```powershell
dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovie.Data.MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite -f
```

## Database Migrations

```powershell
dotnet ef migrations add InitialCreate
dotnet ef database update
```
