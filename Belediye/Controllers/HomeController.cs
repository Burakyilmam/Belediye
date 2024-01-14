using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Belediye.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult HomePage()
        {
            return View();
        }
    }
}