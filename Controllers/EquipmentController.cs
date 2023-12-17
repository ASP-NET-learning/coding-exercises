using DataBaseWriteAndLoad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

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

        // GET: Ai
        public ActionResult Index()
        {
            return View(_context.Ai.ToList());
        }

        // GET: Ai/Details/5
        public ActionResult Details(int? ID) 
        {
            if (ID == null)
            {
                return new StatusCodeResult(404);
            }

            Ai LoadNewAi = _context.Ai.Find(ID);
            if (LoadNewAi == null)
            {
                return new StatusCodeResult(404);
            }
            return View(LoadNewAi);
        }


        // POST: Ai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ai/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind("CreateID","MachineID","AlgorithmName, HyperparameterName, CrossName")] Ai ai)
        {
                
                _context.Add(ai);
                try 
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    var innerException = ex.InnerException;
                    while (innerException != null)
                    {
                        Console.WriteLine(innerException.Message);
                        innerException = innerException.InnerException;
                    }

                }
                 // 使用 SaveChanges() 以同步方式保存更改
                return RedirectToAction(nameof(Index));
        }
    }
}
