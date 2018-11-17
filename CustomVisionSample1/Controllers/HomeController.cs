using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomVisionSample1.Models;

namespace CustomVisionSample1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string imageUrl = "https://www.akc.org/wp-content/themes/akc/component-library/assets//img/health.jpg";
            PredictVision p = new PredictVision();
            var res = p.PredictByUrl(imageUrl);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
