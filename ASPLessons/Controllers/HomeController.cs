using ASPLessons.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPLessons.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Create() => View();

        [HttpPost]
        public string Create(Person person)
        {
            if (ModelState.IsValid)
            {
                return $"Person name:{person.Name} Person Age {person.Age}";
            }
            return "Data isn't valid...";
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;

            ViewData["result"] = result;

            return View();
        }
        public IActionResult PrintDetail()
        {
            int age = 23;
            string name = "German";
            var user = new { Name = name, Age = age};

            return View(age);
        }
        public IActionResult PrintInfo()
        {
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
