using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LINQDemo.Models;

namespace LINQDemo.Controllers;

public class HomeController : Controller
{
    public static Game[] AllGames = new Game[]
    {
        new Game {Title = "Elden Ring", Price=59.99, Genre="RPG", Rating="M", Platform="PC"},
        new Game {Title = "Rust", Price=59.99, Genre="Survival", Rating="M", Platform="Mobile"},
        new Game {Title = "League of Legends", Price=0, Genre="FPS", Rating="M", Platform="PC"},
        new Game {Title = "World of Warcraft", Price=69.99, Genre="RPG", Rating="M", Platform="Nintendo Switch"},
        new Game {Title = "Max Payne", Price=29.99, Genre="Adventure", Rating="M", Platform="XBox"},
        new Game {Title = "Tom Clancy", Price=0, Genre="RPG", Rating="M", Platform="PC"},
        new Game {Title = "Rainbow Six", Price=9.99, Genre="RPG", Rating="M", Platform="PC"},
        new Game {Title = "Call Of Duty", Price=0, Genre="RPG", Rating="FPS", Platform="Mobile"},
        new Game {Title = "Fortnite", Price=0, Genre="RPG", Rating="M", Platform="PC"},
    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // All PC Games
        List<Game> AllPCGames = AllGames.Where(pc => pc.Platform != "PC").ToList();
        ViewBag.AllPCGames = AllPCGames;

        // Get one game
        Game? OneGame = AllGames.FirstOrDefault(o => o.Title=="Max Payne");
        ViewBag.OneGame = OneGame;

        // Get the first three free games
        List<Game> AllFreeGames = AllGames.Where(o => o.Price == 0.00).Take(3).ToList();
        // List<Game> Top3Free = AllGames.Where(o => o.Price == 0.00).OrderBy(t => t.Title).Take(3).ToList();
        ViewBag.Top3 = AllFreeGames;

        // Get the price ofthe most expensive game
        double MostExpensive = AllGames.Max(s => s.Price);
        ViewBag.MostExpensive = MostExpensive;

        // The price of all the games together
        double SumPrice = AllGames.Sum(a => a.Price);
        ViewBag.Total = SumPrice;

        // Get  LIST OF ALL Titles
        List<string> AllTitles = AllGames.OrderBy(t => t.Title).Select(s => s.Title).ToList();
        ViewBag.AllTitles = AllTitles;

        // We can get back a boolean whether a condition was met
        bool MatchTitle = AllGames.Any(s => s.Title == "Max Payne");
        ViewBag.MatchTitle = MatchTitle;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
