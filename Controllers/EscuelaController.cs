using System;
using ASP_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index(){
            var escuela =new Models.Escuela();
            escuela.AñoDeCreacion =2005;
            escuela.Nombre = "ASP School";
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Direccion = "Calle Falsa 123";
            escuela.Ciudad = "Bogotá";
            escuela.Pais= "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}