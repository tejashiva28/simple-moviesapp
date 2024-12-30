// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using MvcMovieApp.Models;
// using System.Text.Encodings.Web;

// namespace MvcMovieApp.Controllers;

// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;

//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }

//     public IActionResult Index()
//     {
//         return View();
//     }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     // GET: /Home/Welcome?name=Teja&numtimes=4
//     // Requires using System.Text.Encodings.Web;
//     public string Welcome(string name, int numTimes = 1)
//     {
//         return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
//     }

//     // GET: /Home/Welcome/101?name=Teja
//     public string Welcome2(string name, int ID = 1)
//     {
//         return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovieApp.Models;
using System.Text.Encodings.Web;

namespace MvcMovieApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // GET: /Home/Welcome?name=Teja&numtimes=4
    public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }

    // GET: /Home/Welcome/101?name=Teja
    public string Welcome2(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }

    // GET: /Home/About
    public IActionResult About()
    {
        return View();
    }

    // GET: /Home/Contact
    public IActionResult Contact()
    {
        return View();
    }

    // GET: /Home/Greet?name=John&age=30
    public IActionResult Greet(string name, int age)
    {
        ViewBag.Name = name;
        ViewBag.Age = age;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
