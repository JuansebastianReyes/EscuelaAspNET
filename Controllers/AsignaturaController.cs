using System;
using System.Linq;
using System.Collections.Generic;
using ASP_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET.Controllers
{
    public class AsignaturaController : Controller
    {
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if(!string.IsNullOrWhiteSpace(asignaturaId))
            {
                        var asignatura = from asig in _context.Asignaturas
                                        where asig.Id == asignaturaId
                                        select asig;

                        return View(asignatura.SingleOrDefault());
            }
            else
            {
               return View("MultiAsignatura", _context.Asignaturas); 
            }
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