using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NasaAPIToExcel.Services.Contracts;
using NasaAPIToExcel.Web.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NasaAPIToExcel.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INASAService asteroidService;

        public HomeController(ILogger<HomeController> logger, INASAService asteroidService)
        {
            _logger = logger;
            this.asteroidService = asteroidService;
        }

        public async Task<IActionResult> Index()
        {
            //var APODData = await this.asteroidService.GetAPODDataAsync(DateTime.Now);
            var asteroidsData = await this.asteroidService.GetAsteroidsFeedDataAsync(DateTime.Now);

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
