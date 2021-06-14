using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using ASP_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index(){
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno(){
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Alumnos);
        }
        
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;               
        }

    }
}