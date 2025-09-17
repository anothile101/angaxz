using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //public IActionResult Index()
    //{
    //    return View();
    //}

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    //}
    public IActionResult Index() => View("Login"); // default to login page
    public IActionResult Login() => View();
    public IActionResult SubmitClaim() => View();
    public IActionResult LecturerDashboard() => View();
    public IActionResult MyClaims() => View();
    public IActionResult CoordinatorDashboard() => View();
    public IActionResult ClaimVerification() => View();
    public IActionResult ManagerDashboard() => View();
}