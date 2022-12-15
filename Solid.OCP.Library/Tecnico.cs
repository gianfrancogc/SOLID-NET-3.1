using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Library
{
    public class Tecnico : IPostulante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public IReclutamientoServicio Procesador { get; set; } = new ReclutamientoTecnico();
    }
}
