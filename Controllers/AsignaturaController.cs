using System;
using ASP_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index(){
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programacion"
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View(asignatura);
        }

    }
}