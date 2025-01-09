using Microsoft.AspNetCore.Mvc.RazorPages;
using Cinema.DataAccess;
using Cinema.Models;

namespace CinemaScheduleApp.Pages;

public class ScheduleModel : PageModel
{
    private readonly IMovieRepository _movieRepository;

    public List<Movie> Movies { get; set; } = new();

    public ScheduleModel(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public void OnGet()
    {
        Movies = _movieRepository.GetAllMovies().ToList();
    }
}
