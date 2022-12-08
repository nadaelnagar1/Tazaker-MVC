using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tazaker.Models;

namespace Tazaker.Controllers
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

      
    }
}