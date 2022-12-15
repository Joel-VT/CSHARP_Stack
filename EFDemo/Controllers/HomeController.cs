using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EFDemo.Models;

namespace EFDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;

        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("songs")]
    public IActionResult Songs()
    {
        List<Song> AllSongs = _context.Songs.ToList();
        return View("AllSongs", AllSongs);
    }

    [HttpPost("songs/create")]
    public IActionResult CreateSong(Song newSong)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newSong);
            _context.SaveChanges();
            return RedirectToAction("Songs");
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("songs/{id}")]
    public IActionResult ShowSong(int id)
    {
        Song? OneSong = _context.Songs.FirstOrDefault(o => o.MusicId == id);
        return View(OneSong);
    }

    [HttpPost("songs/{id}/destroy")]
    public IActionResult DestroySong(int id)
    {
        Song? SongToDestroy = _context.Songs.SingleOrDefault(s => s.MusicId == id);
        _context.Songs.Remove(SongToDestroy);
        _context.SaveChanges();
        return RedirectToAction("Songs");
    }

    [HttpGet("songs/{id}/edit")]
    public IActionResult EditSong(int id)
    {
        Song? SongToEdit = _context.Songs.FirstOrDefault(s => s.MusicId == id);
        return View(SongToEdit);
    }

    [HttpPost("songs/{id}/update")]
    public IActionResult UpdateSong(int id, Song UpdatedSong)
    {
        Song? SongToUpdate = _context.Songs.FirstOrDefault(s => s.MusicId ==id);
        if(SongToUpdate == null)
        {
            return RedirectToAction("Index");
        }
        if(ModelState.IsValid)
        {
            SongToUpdate.Title = UpdatedSong.Title;
            SongToUpdate.Year = UpdatedSong.Year;
            SongToUpdate.Genre = UpdatedSong.Genre;
            SongToUpdate.Artist = UpdatedSong.Artist;
            SongToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Songs");
        }
        else
        {
            return View("EditSong", SongToUpdate);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
