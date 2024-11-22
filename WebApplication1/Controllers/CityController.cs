using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CityController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
