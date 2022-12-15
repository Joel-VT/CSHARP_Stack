using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OneToMany.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OneToMany.Controllers;

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
        MyViewModel MyModel = new MyViewModel
        {
            AllMakers = _context.Makers.ToList()
        };
        return View(MyModel);
    }

    [HttpPost("maker/create")]
    public IActionResult CreateMaker(Maker newMaker)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newMaker);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            MyViewModel MyModel = new MyViewModel
            {
                AllMakers = _context.Makers.ToList()
            };
            return View("Index", MyModel);
        }
    }

    [HttpGet("vehicles")]
    public IActionResult Vehicles()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllVehicles = _context.Vehicles.ToList()
        };
        ViewBag.AllMakers = _context.Makers.ToList();
        return View(MyModel);
    }

    [HttpPost("vehicles/create")]
    public IActionResult CreateVehicle(Vehicle newVehicle)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine($"{newVehicle.ModelName} {newVehicle.Color} {newVehicle.Year} {newVehicle.Transmission} {newVehicle.AWD} {newVehicle.MakerId}");
            _context.Add(newVehicle);
            _context.SaveChanges();
            return RedirectToAction("Vehicles");
        }
        else
        {
            MyViewModel MyModel = new MyViewModel
            {
                AllVehicles = _context.Vehicles.ToList()
            };
            ViewBag.AllMakers = _context.Makers.ToList();
            return View("Vehicles",MyModel);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
