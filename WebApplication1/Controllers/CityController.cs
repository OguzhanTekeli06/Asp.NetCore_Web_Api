using Microsoft.AspNetCore.Mvc;
using Web.ApplicationLayer;
using Web.DomainLayer;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : Controller
{
    

    [HttpGet]
    public IActionResult GetCityList()
    {
        var city = new CityService();
        return Ok(city.GetCityList());
    }
}
