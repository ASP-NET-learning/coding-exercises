using DataBaseWriteAndLoad.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace DataBaseWriteAndLoad.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly masterContext _context;
        private readonly ILogger<EquipmentController> _logger;
        public EquipmentController(ILogger<EquipmentController> logger, masterContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index(IFormCollection post)
        {
            ViewBag.AlgorithmName = post["AlgorithmName"];
            ViewBag.HyperparameterName = post["HyperparameterName"];
            ViewBag.CrossName = post["CrossName"];

            if (!string.IsNullOrEmpty(ViewBag.AlgorithmName) && 
                !string.IsNullOrEmpty(ViewBag.HyperparameterName) &&
                !string.IsNullOrEmpty(ViewBag.CrossName))
            {
                Ai newAi = new Ai
                {
                    CreateID = "A001",
                    MachineID = "Mach001",
                    AlgorithmName = ViewBag.AlgorithmName,
                    HyperparameterName = ViewBag.HyperparameterName,
                    CrossName = ViewBag.CrossName
                };
                _context.Ai.Add(newAi);
                _context.SaveChanges();
            }
            return View();
        }

        



    }
}
