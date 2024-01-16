using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // Dependency injection for logging

        public HomeController(ILogger<HomeController> logger) // Constructor to inject the dependency
        {
            _logger = logger;
        }

        /// <summary>
        /// Displays the home page.
        /// </summary>
        /// <returns>An IActionResult object that represents the view.</returns>
        public IActionResult Index()
        {
            // Use logging to record an info message.
            _logger.LogInformation("Rendering Home page.");

            return View();
        }

        /// <summary>
        /// Displays the privacy policy page.
        /// </summary>
        /// <returns>An IActionResult object that represents the view.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Handles errors that occur in the application.
        /// </summary>
        /// <returns>An IActionResult object that represents the view.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Get the request ID from either the current activity or the trace identifier.
            string requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            // Create an `ErrorViewModel` object to pass data to the view.
            return View(new ErrorViewModel
            {
                RequestId = requestId
            });
        }
    }
}