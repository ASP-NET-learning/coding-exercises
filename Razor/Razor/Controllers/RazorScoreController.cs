using Razor.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class RazorScoreController : Controller
    {
        protected List<Student> students = new List<Student>
        {
            new Student {Id = 1, Name="Joe", Chinese=88, English=95, Math=71},
            new Student {Id = 21, Name="Marry", Chinese=60, English=100, Math=100},
            new Student {Id = 39, Name="Harry", Chinese=77, English=30, Math=30},
            new Student {Id = 17, Name="Ally", Chinese=40, English=95, Math=5}
        };
        // GET: RazorScore
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Scores()
        {
            return View(students);
        }

        public ActionResult ScoresRazor()
        {
            int topId = 0;
            int topScore = 0;

            foreach(var student in students)
            {
                student.Total = student.Chinese + student.English + student.Math;
                if(student.Total > topScore)
                {
                    topScore = student.Total;
                    topId = student.Id;
                }
            }
            ViewBag.TopId = Convert.ToInt32(topId);
            return View(students);
        }

        public ActionResult RazorPure()
        {
            int topId = 0;
            int topScore = 0;

            foreach (var student in students)
            {
                student.Total = student.Chinese + student.English + student.Math;
                if (student.Total > topScore)
                {
                    topScore = student.Total;
                    topId = student.Id;
                }
            }
            ViewBag.TopId = Convert.ToInt32(topId);
            return View(students);
        }

        public ActionResult ScoreRazorHelper()
        {
            int topId = 0;
            int topScore = 0;

            foreach (var student in students)
            {
                student.Total = student.Chinese + student.English + student.Math;
                if (student.Total > topScore)
                {
                    topScore = student.Total;
                    topId = student.Id;
                }
            }
            ViewBag.TopId = Convert.ToInt32(topId);
            return View(students);
        }

        public ActionResult GlobalHtmlHelper()
        {
            int topId = 0;
            int topScore = 0;

            foreach (var student in students)
            {
                student.Total = student.Chinese + student.English + student.Math;
                if (student.Total > topScore)
                {
                    topScore = student.Total;
                    topId = student.Id;
                }
            }
            ViewBag.TopId = Convert.ToInt32(topId);
            return View(students);
        }

    }
}