using Microsoft.AspNetCore.Mvc;

using Web.DomainLayer;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : Controller
{
    public readonly List<City> Cities = new List<City>() {
        new City()
        {
            Name="Istanbul",
            Code="IST"
        },
        new City()
        {
            Name="Izmir",
            Code="IZM"
        }

    };


    [HttpGet]
    public IActionResult GetCityList()
    {
        return Ok(Cities);
    }
}
