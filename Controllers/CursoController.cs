using System;
using System.Linq;
using System.Collections.Generic;
using ASP_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET.Controllers
{
    public class CursoController : Controller
    {
        private EscuelaContext _context;
        public IActionResult index(string id){
            if(!string.IsNullOrWhiteSpace(id)){
                var curso = from cur in _context.Cursos
                            where cur.Id == id
                            select cur;

                return View(curso.SingleOrDefault());
            }else {
                return View("MultiCurso", _context.Cursos); 
            }
        }
        
        public IActionResult MultiCurso(){
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Cursos);
        }

        public CursoController(EscuelaContext context)
        {
            _context = context;               
        }
    }
}