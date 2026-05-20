# Edeson Movies — CSE 325 W02 ASP.NET Core MVC

An ASP.NET Core MVC web app that manages a movie catalog, built by completing the
Microsoft Learn [*Get started with ASP.NET Core MVC*](https://learn.microsoft.com/aspnet/core/tutorials/first-mvc-app/)
tutorial series.

- **Framework:** ASP.NET Core MVC on .NET 10 (current LTS)
- **Database:** Entity Framework Core with SQLite (`MvcMovie.db`, created automatically)
- **Project folder:** [`MvcMovie/`](./MvcMovie)

## Run it

```bash
cd MvcMovie
dotnet run --launch-profile http
```

Then open `http://localhost:5179/Movies`. On first run the app applies the EF Core
migration and seeds the database, so no manual database setup is needed.

## Required additional functionality (beyond the MS tutorial)

| # | Requirement | Where |
|---|-------------|-------|
| 1 | App title changed to **"Edeson Movies"** | `Views/Shared/_Layout.cshtml` (title tag, navbar brand, footer) |
| 2 | Added **4 of my own favorite movies** (Interstellar, The Dark Knight, Spider Man, Inside Out) | `Models/SeedData.cs` |
| 3 | Movie listing heading changed from "Index" to **"My Movies"** | `Views/Movies/Index.cshtml` |
| 4 | **Search by year** — shows movies released that year or newer | `Controllers/MoviesController.cs` (`releaseYear` filter) + `Views/Movies/Index.cshtml` |
| 5 | **Padding added to form inputs** (`input`, `select`, `textarea`) | `wwwroot/css/site.css` |

## Tutorial parts completed

Create web app · Add a controller · Add a view · Add a model · Work with a database ·
Controller actions and views · Add search · Add a new field (`Rating`) · Add validation ·
Examine Details and Delete.
