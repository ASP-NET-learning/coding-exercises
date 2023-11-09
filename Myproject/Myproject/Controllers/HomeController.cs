using Microsoft.AspNetCore.Mvc;
using Myproject.Models;
using System.Diagnostics;

namespace Myproject.Controllers
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

        public IActionResult UserPermissions()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ProductionOrders()
        {
            return View();
        }

        public IActionResult ResourceMonitoring()
        {
            return View();
        }

        public IActionResult ProductionData()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}