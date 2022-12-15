using Microsoft.AspNetCore.Mvc;
namespace Countdown.Controllers;

public class CountdownController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        ViewBag.end = new DateTime(2022, 12, 25, 7, 0, 0);
        return View();
    }
}