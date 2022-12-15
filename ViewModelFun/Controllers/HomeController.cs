using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        string Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras tincidunt, urna a tincidunt faucibus, neque nulla consectetur mi, vel euismod nisl velit facilisis urna. Ut id velit turpis. Sed eget feugiat lacus, ut maximus nisl. Pellentesque ut rhoncus ex. Pellentesque rhoncus orci dolor, gravida luctus ipsum tempor non. In tincidunt mattis arcu, eget consequat arcu vulputate eu. Vivamus venenatis elit velit, in cursus dui venenatis vel. Morbi ultricies sem sit amet eleifend facilisis. Cras dapibus, lorem ut tristique imperdiet, tellus nisl gravida tortor, nec porttitor odio nunc eu augue. Nullam eu augue eu enim rhoncus vehicula. Aliquam molestie egestas tellus, sit amet consequat nisi porttitor vel. Cras condimentum ipsum at aliquet aliquet. Interdum et malesuada fames ac ante ipsum primis in faucibus. Etiam ex quam, hendrerit ac sodales imperdiet, imperdiet quis dolor. Nulla et metus laoreet, porta felis vel, efficitur nisi. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
        return View("Index", Message);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        int[] arr = {1,2,3,4,5};
        return View(arr);
    }

    [HttpGet("user")]
    public IActionResult AUser()
    {
        User OneUser = new User() 
        {
            FirstName = "Joel",
            LastName = "Varghese"
        };
        return View(OneUser);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> AllUsers = new List<User>()
        {
            {
                new User() 
                {
                    FirstName = "Joel",
                    LastName = "Varghese"
                }
            },
            {
                new User() 
                {
                    FirstName = "Joshua",
                    LastName = "StMarie"
                }
            },
            {
                new User() 
                {
                    FirstName = "Michael",
                    LastName = "Gonzalez"
                }
            },
            {
                new User() 
                {
                    FirstName = "Colby",
                    LastName = "Leed"
                }
            }
        };
        return View(AllUsers);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
