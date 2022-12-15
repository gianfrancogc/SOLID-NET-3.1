using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Library
{
    public interface IPostulante
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        IReclutamientoServicio Procesador { get; set; }


    }
}
