using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Template.Databases;
using Template.Models;

namespace Template.Controllers;

public class HomeController(ILogger<HomeController> logger, TemplateContext context) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    private readonly TemplateContext _context = context;

    public IActionResult Index()
    {
        return View(_context.myTemplates.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
