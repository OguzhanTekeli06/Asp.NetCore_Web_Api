using Microsoft.AspNetCore.Mvc;
using Web.ApplicationLayer.Personnels;
using Web.ViewModel;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]   //[Route("[controller]")] ifadesi, ASP.NET Core'a bu controller'ın adını otomatik olarak URL'nin bir parçası olarak kullanmasını söyler.
    public class PersonnelController : Controller
    {
        private readonly IPersonnelService _personnelService;
        public PersonnelController(IPersonnelService personnelService)
        {
            _personnelService = personnelService;
        }
        [HttpPut]
        [Route(nameof(AddAsync))]
        public async Task<IActionResult> AddAsync(AddPersonnelModel model)
        {
            var result = await _personnelService.AddAsync(model);
            return Ok(result);
        }


        [HttpPut]
        [Route(nameof(UpdateAsync))]
        public async Task<IActionResult> UpdateAsync(AddPersonnelModel model)
        {
            var result = await _personnelService.UpdateAsync(model);
            return Ok(result);
        }

        [HttpDelete]
        [Route(nameof(DeleteAsync))]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _personnelService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpPut]
        [Route(nameof(AddPersonnelInfoAsync))]
        public async Task<IActionResult> AddPersonnelInfoAsync(AddPersonnelInfoModel model)
        {
            var result = await _personnelService.AddPersonnelAsync(model);
            return Ok(result);
        }
    }
}
