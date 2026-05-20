using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models;

// View model that backs the movie listing page: the filtered list of movies
// plus the data needed to render the search form (genre dropdown, current
// search string, and the year filter added for the assignment).
public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }

    // Added for the assignment: filter by release year (this year or newer).
    public int? ReleaseYear { get; set; }
}
