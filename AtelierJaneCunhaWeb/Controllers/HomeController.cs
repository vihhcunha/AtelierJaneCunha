using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierJaneCunhaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("contato")]
        public IActionResult Contato()
        {
            return View();
        }

        [Route("sobre-nos")]
        public IActionResult SobreNos()
        {
            return View();
        }

        [Route("catalogo")]
        public IActionResult Catalogo()
        {
            return View();
        }
    }
}
