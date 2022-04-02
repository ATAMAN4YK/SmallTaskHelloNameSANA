using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HelloName.Models;

namespace HelloName.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Hello(Person user)
        {
            return View("Hello", user);
        }
    }
}