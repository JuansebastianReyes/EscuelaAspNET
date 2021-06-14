using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP_.NET.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Evaluacion> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela =new Models.Escuela();
            escuela.AñoDeCreacion =2005;
            escuela.Nombre = "ASP School";
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Direccion = "Calle Falsa 123";
            escuela.Ciudad = "Bogotá";
            escuela.Pais= "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(escuela);

            modelBuilder.Entity<Asignatura>().HasData(
                            new Asignatura{Nombre="Matemáticas",  Id = Guid.NewGuid ().ToString ()} ,
                            new Asignatura{Nombre="Educación Física",  Id = Guid.NewGuid ().ToString ()},
                            new Asignatura{Nombre="Castellano",  Id = Guid.NewGuid ().ToString ()},
                            new Asignatura{Nombre="Ciencias Naturales",  Id = Guid.NewGuid ().ToString ()},
                            new Asignatura{Nombre="Programación", Id = Guid.NewGuid ().ToString ()}
            );

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ 
                                    Nombre=$"{n1} {n2} {a1}" ,
                                    Id = Guid.NewGuid ().ToString (),
                                    };
            
            return listaAlumnos.OrderBy( (al)=> al.Id ).ToList();
        }


    }
}