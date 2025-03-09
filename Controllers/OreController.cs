using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace oresAndCores.Controllers
{
    [Route("ore")]
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