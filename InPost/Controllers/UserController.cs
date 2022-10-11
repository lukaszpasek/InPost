using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InPost.Models;
using System.Xml.Linq;

namespace InPost.Controllers;

public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public UserController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult NadajPaczke()
    {
        return Content("Hello World!");
        return View();
    }

    public IActionResult OdbierzPaczke()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

