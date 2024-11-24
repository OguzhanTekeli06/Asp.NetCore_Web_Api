using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Web.ApplicationLayer;
using Web.DomainLayer;


namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class DistrictController : Controller
{

    



    [HttpGet]
    public IActionResult GetDistrictByCityCode(string citycode)
    {
        var district = new DistrictService();
        return Ok(district.GetDistricts(citycode));
    }
}
