using Microsoft.AspNetCore.Mvc;
using GarageMVC.Models;

namespace GarageMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Garage miGaraje;

        public HomeController()
        {
            
            miGaraje = new Garage(
                numeroGaraje: 1,
                descripcion: "Garaje Roberto Diaz",
                capacidadEspacios: 10
            );

            
            var auto1 = new Auto(1, "Toyota", "ROBER-10234");
            var auto2 = new Auto(2, "Hyundai", "Rober-666");
            var auto3 = new Auto(3, "Kia", "Rober-1515");

            miGaraje.ingresarAuto(auto1);
            miGaraje.ingresarAuto(auto2);
            miGaraje.ingresarAuto(auto3);
        }

        public IActionResult Index()
        {
            
            return View(miGaraje);
        }
    }
}