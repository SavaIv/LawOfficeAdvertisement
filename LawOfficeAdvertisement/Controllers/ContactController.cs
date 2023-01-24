using Microsoft.AspNetCore.Mvc;

namespace LawOfficeAdvertisement.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
