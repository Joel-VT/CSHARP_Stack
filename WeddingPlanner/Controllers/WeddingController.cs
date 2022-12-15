using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{
    private readonly ILogger<WeddingController> _logger;
    private MyContext _context;

    public WeddingController(ILogger<WeddingController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [SessionCheck]
    [HttpGet("weddings")]
    public IActionResult Weddings()
    {
        List<Wedding> EveryWedding = _context.Weddings.Include(w => w.RSVPedGuests).ToList();
        ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
        return View(EveryWedding);
    }

    [SessionCheck]
    [HttpGet("weddings/new")]
    public IActionResult NewWedding()
    {
        return View();
    }

    [HttpPost("weddings/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newWedding);
            _context.SaveChanges();
            return Redirect($"/weddings/{newWedding.WeddingId}");
        }
        else
        {
            return View("NewWedding");
        }
    }

    [SessionCheck]
    [HttpGet("weddings/{id}")]
    public IActionResult OneWedding(int id)
    {
        Wedding? onewedding = _context.Weddings.Include(w => w.RSVPedGuests).ThenInclude(r => r.User).FirstOrDefault(w => w.WeddingId == id);
        return View(onewedding);
    }

    [HttpPost("weddings/{id}/destroy")]
    public IActionResult DestroyWedding(int id)
    {
        Wedding? WedToDelete = _context.Weddings.SingleOrDefault(w => w.WeddingId == id);
        _context.Weddings.Remove(WedToDelete);
        _context.SaveChanges();
        return RedirectToAction("Weddings");
    }

    [HttpPost("reservations/{id}/destroy")]
    public IActionResult DestroyReservation(int id)
    {
        Reservation? ReservationToDelete = _context.Reservations.SingleOrDefault(r => r.ReservationId == id);
        _context.Reservations.Remove(ReservationToDelete);
        _context.SaveChanges();
        return RedirectToAction("Weddings");
    }

    [HttpPost("reservations/create")]
    public IActionResult CreateReservation(Reservation newReserve)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newReserve);
            _context.SaveChanges();
            return RedirectToAction("Weddings");
        }
        else
        {
            List<Wedding> EveryWedding = _context.Weddings.Include(w => w.RSVPedGuests).ToList();
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            return View("Weddings", EveryWedding);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? UserId = context.HttpContext.Session.GetInt32("UserId");
        if (UserId == null)
        {
            context.Result = new RedirectToActionResult("Index", "Home", null);
        }
    }
}