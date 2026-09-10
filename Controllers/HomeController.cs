using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebAppInDocker.Models;

namespace FirstWebAppInDocker.Controllers;

public class HomeController : Controller
{
    // Viser skjema-siden
public IActionResult CorrectMap()
{
    return View();
}

// Tar imot dataene fra skjemaet
[HttpPost]
public IActionResult CorrectMap(PositionModel model)
{
    if (ModelState.IsValid)
    {
        positions.Add(model);
        return View("CorrectionOverview", positions);
    }
    return View(model);
}

// Viser oversikts-siden
public IActionResult CorrectionOverview()
{
    return View(positions);
}
    private static List<PositionModel> positions = new List<PositionModel>();
    public IActionResult Index()
    {
        return View();
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
