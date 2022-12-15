// Always needed in all Controllers
using Microsoft.AspNetCore.Mvc;
// Needed to access the Controllers file
namespace FirstWeb1.Controllers;
public class HelloController : Controller
{
    // Routing
    // This tells our controller we have a web page we want to see(Get)
    [HttpGet]

    // What is the route?
    // this goes to localhost:5XXX/
    [Route("")]
    public ViewResult Index()
    {
        // ViewBag allows us to passs data from controller to view
        ViewBag.Name = "Joel";
        ViewBag.Number = 7;
        return View("Index");
    }

    // Another get route
    [HttpGet("user/more")]
    public ViewResult AUser()
    {
        return View();
    }

    // Another get route and passing variables to the route
    [HttpGet("user/{name}")]
    public string OneUser(string name)
    {
        return $"Hey {name}!";
    }

    [HttpPost("process")]
    public IActionResult Process(string FavoriteAnimal)
    {
        if(FavoriteAnimal == "dog")
        {
            ViewBag.Error = "Pick Something else";
            return View("Index");
        }
        return RedirectToAction("/");
    }
}