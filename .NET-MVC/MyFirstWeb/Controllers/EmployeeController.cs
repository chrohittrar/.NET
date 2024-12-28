using Microsoft.AspNetCore.Mvc;


namespace MyFirstWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
           

            return View();
        }
    }
}
