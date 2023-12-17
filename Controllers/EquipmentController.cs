using DataBaseWriteAndLoad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Net;

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


        public ActionResult Edit(int? id)
        {
            var existingAi = _context.Ai.Find(id);
            if (existingAi == null)
            {
                return NotFound(); // 若找不到對應的 Ai，返回 NotFound 結果
            }
            Ai LoadNewAi = _context.Ai.Find(id);
            if (LoadNewAi == null)
            {
                return NotFound(); // 若找不到對應的 Ai，返回 NotFound 結果
            }
            return View(LoadNewAi);
        }


        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id,
                [Bind("CreateID", "MachineID", "AlgorithmName", "HyperparameterName", "CrossName")] Ai ai)

        {
            var existingAi = _context.Ai.Find(id);
            if (existingAi == null)
            {
                return NotFound(); // 若找不到對應的 Ai，返回 NotFound 結果
            }

            existingAi.CreateID = ai.CreateID;
            existingAi.MachineID = ai.MachineID;
            existingAi.AlgorithmName = ai.AlgorithmName;
            existingAi.HyperparameterName = ai.HyperparameterName;
            existingAi.CrossName = ai.CrossName;

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

        // GET: Friends/Delete/5
        public ActionResult Delete(int? id)
        {
            var existingAi = _context.Ai.Find(id);
            if (existingAi == null)
            {
                return NotFound(); // 若找不到對應的 Ai，返回 NotFound 結果
            }
            Ai LoadNewAi = _context.Ai.Find(id);
            if (LoadNewAi == null)
            {
                return NotFound(); // 若找不到對應的 Ai，返回 NotFound 結果
            }
            return View(LoadNewAi);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, bool? saveChangesError = false)
        {
            var existingAi = _context.Ai.Find(id);
            if (existingAi == null)
            {
                return RedirectToAction(nameof(Index)); // 若找不到對應的 Ai，返回 NotFound 結果
            }
            try
            {
                _context.Ai.Remove(existingAi);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
    }
}
