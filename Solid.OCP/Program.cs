using Solid.OCP.Library;
using Solid.OCP.Library.Modelos;
using System;
using System.Collections.Generic;

namespace Solid.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPostulante> personas = new List<IPostulante>(){
                new Persona{ Nombre= "Gian", Apellidos="Gomez"},
                new Ingeniero{ Nombre= "Keith", Apellidos="Wallen"},
                new Tecnico{ Nombre= "Shaun", Apellidos="Foist"}
            };

            List<Empleado> empleados = new List<Empleado>();
            foreach (var persona in personas)
            {
                //empleados.Add(new ReclutamientoServicio().Contratar(persona));
                empleados.Add(persona.Procesador.Contratar(persona));
            }
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Bienvenido {empleado.Nombre} {empleado.Apellidos}, {empleado.Email}");
                //Console.WriteLine($"Es Ingeniero {(empleado.Rol == Rol.Ingeniero ? "SI" :  "NO")}");
                //Console.WriteLine($"Es Tecnico {(empleado.Rol == Rol.Tecnico ? "SI" : "NO")}");
            }
            Console.ReadLine();
        }
    }
}
