using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Talha_Project.Models;

namespace Talha_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public IActionResult about()
        {
            return View();
        }
        [Route("contact")]
        public IActionResult contact()
        {
            return View();
        }
        [Route("course")]
        public IActionResult course()
        {
            return View();
        }
        [Route("detail")]
        public IActionResult detail()
        {
            return View();
        }
        [Route("feature")]
        public IActionResult feature()
        {
            return View();
        }
        [Route("team")]
        public IActionResult team()
        {
            return View();
        }
        [Route("testimonial")]
        public IActionResult testimonial()
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
