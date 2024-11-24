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
    private readonly IDistrictService _districtService;

    public DistrictController(IDistrictService districtService)
    {
        _districtService = districtService;
    }

    [HttpGet]
    public IActionResult GetDistrictByCityCode(string citycode)
    {
        return Ok(_districtService.GetDistricts(citycode));
    }
}
