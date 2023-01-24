using Microsoft.AspNetCore.Mvc;

namespace LawOfficeAdvertisement.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
