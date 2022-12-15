using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Library.Modelos
{
    public class Persona : IPostulante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //public bool EsIngeniero { get; set; }
        //public  Rol Rol { get; set; }

        public IReclutamientoServicio Procesador { get; set; } = new ReclutamientoServicio();
    }
}
