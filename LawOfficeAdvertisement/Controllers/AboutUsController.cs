using Microsoft.AspNetCore.Mvc;

namespace LawOfficeAdvertisement.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult ListOfAllActivities()
        {
            return View();
        }
        public IActionResult AdministrativnoPravo()
        {
            return View();
        }

        public IActionResult KorporativnoPravo()
        {
            return View();
        }

        public IActionResult NakazatelnoPravo()
        {
            return View();
        }
        public IActionResult NesastoyatelnostLikvidaciya()
        {
            return View();
        }
        public IActionResult ObligacionnoPravo()
        {
            return View();
        }
        public IActionResult ProcesualnoPredstavitelstvo()
        {
            return View();
        }
        public IActionResult SemeynoNasledstvenoPravo()
        {
            return View();
        }
        public IActionResult TargovskoPravo()
        {
            return View();
        }
        public IActionResult VeshtnoPravo()
        {
            return View();
        }
    }
}
