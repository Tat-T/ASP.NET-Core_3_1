using Microsoft.AspNetCore.Mvc.RazorPages;
using CinemaScheduleApp.Models;

namespace CinemaScheduleApp.Pages;

public class ScheduleModel : PageModel
{
    public List<Movie> Movies { get; set; } = new();

    public void OnGet()
    {
        Movies = new List<Movie>
        {
            new Movie
            {
                Title = "Интерстеллар",
                Director = "Кристофер Нолан",
                Genre = "Фантастика",
                Description = "Фильм о космических путешествиях и времени.",
                ShowTimes = new List<string> { "10:00", "14:30", "18:00", "21:30" }
            },
            new Movie
            {
                Title = "Аватар",
                Director = "Джеймс Кэмерон",
                Genre = "Фантастика",
                Description = "Фантастический мир Пандоры.",
                ShowTimes = new List<string> { "11:00", "15:00", "19:00", "22:00" }
            }
        };
    }
}
