using Microsoft.AspNetCore.Mvc;

namespace LawOfficeAdvertisement.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
