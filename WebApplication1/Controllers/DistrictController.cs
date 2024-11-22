using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class DistrictController : Controller
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
