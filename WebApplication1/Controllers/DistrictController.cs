using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class DistrictController : Controller
{

    private readonly List<District> Districts = new List<District>()
    {
        new District{CityCode="IST",Name="Ataşehir"},
        new District{CityCode="IST",Name="Kadıköy"},
        new District{CityCode="IZM",Name="Karşıyaka"}
    };



    [HttpGet]
    public IActionResult GetDistrictByCityCode(string citycode)
    {
        var result = Districts.Where(s => s.CityCode == citycode).ToList();
        return Ok(result);
    }
}
