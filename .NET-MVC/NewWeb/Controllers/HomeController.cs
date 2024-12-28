using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewWeb.Models;

namespace NewWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
