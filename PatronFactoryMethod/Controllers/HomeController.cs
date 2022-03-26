using Microsoft.AspNetCore.Mvc;
using PatronFactoryMethod.Models;
using System.Diagnostics;
using Tools.Factory;

namespace PatronFactoryMethod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(decimal total)
        {
            // Factory
            GananciaLocalFactory gananciaLocalFactory = new GananciaLocalFactory(0.20m);
            GananciaExtranjeroFactory gananciaExtranjeroFactory = new GananciaExtranjeroFactory(0.30m, 20);

            // Productos
            IGanancia gananciaLocal = gananciaLocalFactory.GetGanancia();
            IGanancia gananciaExtranjero = gananciaExtranjeroFactory.GetGanancia();

            // Total
            ViewBag.totalLocal = total + gananciaLocal.Ganancia(total);
            ViewBag.totalLocalExtranjero = total + gananciaExtranjero.Ganancia(total);

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