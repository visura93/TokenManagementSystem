using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TokenManagement.Models;
using TokenManagement.Models.DomainObjects;
using TokenManagement.ServiceManagement;

namespace TokenManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LocationService locationService;
        public HomeController(ILogger<HomeController> logger, LocationService locationService)
        {
            _logger = logger;
            this.locationService = locationService;
        }

        public IActionResult Index()
        {
            var model = new ViewModel();

            model.Locations = locationService.GetLocations();
            return View(model);
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