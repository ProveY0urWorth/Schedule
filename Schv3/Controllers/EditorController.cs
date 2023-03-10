using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schv3.Models;
using System.Diagnostics;
using Schv3.Query;

namespace Schv3.Controllers
{
    public class EditorController : Controller
    {
        private readonly ILogger<EditorController> _logger;

        public EditorController(ILogger<EditorController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Authorize]

        public IActionResult Editor()
        {
            return View();
        }

        [Authorize]
        public IActionResult AddSched()
        {
            return View();
        }

        [Authorize]
        public IActionResult AddGroup()
        {
            return PartialView("AddGroup");
        }

        [Authorize]
        public IActionResult AddSubj()
        {
            return PartialView("AddSubj");
        }

        [Authorize]
        public IActionResult AddTeacher()
        {
            return PartialView("AddTeacher");
        }

        [Authorize]
        public IActionResult AddClassroom()
        {
            return PartialView("AddClassroom");
        }

        [Authorize]
        public IActionResult ViewSched()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult SchedulePost()
        {
            //var g = new Group { GroupCode = "ИС/б-20-1-о", course = 2, education = 1, Institute = "ИИТ", Quantity = 25, study_form = 1};
            //EditorQueries.CreateAny(g);
            //var t = new Teacher { Id = 0, LName = "Абрамович", FName = "Александра",  MName = "Юрьевна", Post = "Старший преподаватель"};
            //EditorQueries.CreateAny(t);
            //var s = new Subject { Id = 0, Hours = 54, Id_teacher = 0, Name = "Web-технологии" };
            //EditorQueries.CreateAny(s);
            //var c = new Class { Id = 0, Id_Classroom = 0,Id_Subject = 0, Id_Teacher = 0, Group_Code = "ИС/б-20-1-о", ClassType = 1 };
            //EditorQueries.CreateAny(c);
            var sch = new Schedule {Id = 0, date = "23.12.2022", Group_id = "ИС/б-20-1-о", Id_1Class = 0, Id_2Class = 0, Id_6Class = 0, week = 18 };
            return View("SchedSucces");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
