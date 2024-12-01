using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PersonnelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
