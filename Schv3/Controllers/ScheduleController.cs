using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schv3.Models;
using Schv3.Query;
using System.Diagnostics;

namespace Schv3.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ILogger<ScheduleController> _logger;

        public ScheduleController(ILogger<ScheduleController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Teacher()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            var sch = new Schedule { Id = 0, date = "23.12.2022", Group_id = "ИС/б-20-1-о", Id_1Class = 0, Id_2Class = 0, Id_6Class = 0, week = 18 };
            EditorQueries.CreateAny(sch);
            return View();
        }

        public IActionResult Search()
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
