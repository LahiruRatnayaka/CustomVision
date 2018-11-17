using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomVisionSample1.Controllers
{
    public class CognitiveServiceController : Controller
    {
        public IActionResult CustomVision()
        {
            return View();
        }
    }
}