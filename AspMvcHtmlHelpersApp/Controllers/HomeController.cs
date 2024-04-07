using AspMvcHtmlHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcHtmlHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        List<string> cities = new List<string>() { "Moscow", "Tula", "Voroneg" };
        List<string> names = new List<string>() { "Bobby", "Sammy", "Tommy", "Jimmy" };
        public IActionResult Index()
        {
            ViewData["Cities"] = cities;
            ViewData["Names"] = names;
            return View();
        }

        [HttpGet]
        public IActionResult Employee() => View();

        [HttpPost]
        public string Employee(string name, int age) => $"Name: {name}, Age: {age}";



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
