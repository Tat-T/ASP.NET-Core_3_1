using Microsoft.AspNetCore.Mvc.RazorPages;
using Cinema.DataAccess;
using Cinema.Models;

namespace CinemaScheduleApp.Pages;

public class ScheduleModel : PageModel
{
    private readonly MovieRepository _repository;

    public List<Movie> Movies { get; set; } = new();

    public ScheduleModel()
    {
        _repository = new MovieRepository();
    }

    public void OnGet()
    {
        Movies = _repository.GetAllMovies().ToList();
    }
}
