using Microsoft.AspNetCore.Mvc;

namespace oresAndCores.Controllers
{
    [Route("home")]
    public class OreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return Content("This is about page");
        }
    }
}