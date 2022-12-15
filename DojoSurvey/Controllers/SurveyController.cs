using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string name, string location, string language, string comment)
    {
        if(comment==null)
        {
            ViewBag.Error = "No comment";
            return View("Index");
        }
        Dictionary<string,string> data = new Dictionary<string, string>();
        data.Add("name", name);
        data.Add("location", location);
        data.Add("language", language);
        data.Add("comment", comment);
        return RedirectToAction("Results", new {name=name, location=location, language=language, comment=comment});
    }

    [HttpGet("results")]
    public ViewResult Results(string name, string location, string language, string comment)
    {   
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.comment = comment;
        return View();
    }
}