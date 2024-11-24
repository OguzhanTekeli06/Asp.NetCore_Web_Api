using Microsoft.AspNetCore.Mvc;
using Web.ApplicationLayer;
using Web.DomainLayer;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : Controller
{
    private readonly ICityService _cityService;

    public CityController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet]
    public IActionResult GetCityList()
    {
        return Ok(_cityService.GetCityList());
    }
}
