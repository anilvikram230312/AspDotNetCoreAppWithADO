using FirstDotNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstDotNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IConfiguration _configuration;
        private readonly EmployeeDAL _employeeDAL;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _employeeDAL = new EmployeeDAL();
            
        }

        public IActionResult Index()
        {
            var result = _employeeDAL.GetAllEmployees();
            return View(result);
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
