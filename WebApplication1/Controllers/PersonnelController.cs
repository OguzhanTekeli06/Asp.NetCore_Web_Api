using Microsoft.AspNetCore.Mvc;
using Web.ApplicationLayer.Personnels;
using Web.ViewModel;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonnelController : Controller
    {
        private readonly IPersonnelService _personnelService;
        public PersonnelController(IPersonnelService personnelService)
        {
            _personnelService = personnelService;
        }

        public async Task<IActionResult> AddAsync(AddPersonnelModel model)
        {
            var result = await _personnelService.AddAsync(model);
            return Ok();
        }
    }
}
