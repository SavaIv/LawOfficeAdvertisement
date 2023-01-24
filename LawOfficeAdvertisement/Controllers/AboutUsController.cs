using Microsoft.AspNetCore.Mvc;

namespace LawOfficeAdvertisement.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult ListOfAllActivities()
        {
            return View();
        }
    }
}
