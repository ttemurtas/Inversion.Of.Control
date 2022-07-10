using Inversion.Of.Control.Models;
using Inversion.Of.Control.Services;
using Inversion.Of.Control.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Inversion.Of.Control.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILog _log;

        //public HomeController(ILog log)
        //{
        //    _log = log;
        //}

        public IActionResult Index([FromServices]ILog log)
        {
            log.Log();
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