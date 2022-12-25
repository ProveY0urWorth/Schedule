using Microsoft.AspNetCore.Mvc;
using Schv3.Models;
using Schv3.Query;
using System.Diagnostics;

namespace Schv3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        //METHOD TO DISPLAY RANDOM SHIT ON A PAGE
        public IActionResult MainPage()
        {/*
            Teacher test2 = new Teacher();
            test2.LName = "Ivanov";
            test2.FName = "Ivan";
            test2.MName = "Ivanovich";
            test2.Id = 143;
            test2.Post = "St Prepod";
            EditorQueries.CreateAny(test2);

            */
            
            var i = Requests.GetSchedule("01.01.2022", "Ис/б-20-1-о");
            var j = Requests.GetGroupCodeList();
            var k = Requests.GetTeacherList();
            var y = Requests.GetClassList();
            var z = Requests.GetClassRoomList();
            return View();
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
    }

}