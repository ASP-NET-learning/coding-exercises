using ChartMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChartMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LineBasic()
        {
            return View();
        }

        public IActionResult BarTravel()
        {
            return View();
        }
        public IActionResult RadarManagement()
        {
            return View();
        }
        public IActionResult PieDoughunt()
        {
            return View();
        }
       
    }
}
