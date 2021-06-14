using System;
using System.Linq;
using System.Collections.Generic;
using ASP_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index(){
            return View(_context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura(){
            
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;               
        }

    }
}