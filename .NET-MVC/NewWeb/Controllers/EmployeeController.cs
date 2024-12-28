using Microsoft.AspNetCore.Mvc;
using NewWeb.Models;

namespace NewWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly vehicledbContext _context;

        public EmployeeController(vehicledbContext context) {
        
                _context = context;
        }

        public IActionResult Emp()
        {
            var data = _context.Emp10s.ToList();
            return View(data);
        }
    }
}
