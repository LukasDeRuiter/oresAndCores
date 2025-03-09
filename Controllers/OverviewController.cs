using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace oresAndCores.Controllers;

public class OverviewController : Controller
{
     public IActionResult Index()
        {
            return View();
        }
}