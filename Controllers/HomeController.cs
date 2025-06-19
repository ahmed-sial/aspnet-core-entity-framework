using System.Diagnostics;
using EntityFrameworkCorePractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCorePractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDbContext;

        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        public IActionResult Index()
        {
            var studentData = this.studentDbContext.Student.ToList();
            return View(studentData);
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
