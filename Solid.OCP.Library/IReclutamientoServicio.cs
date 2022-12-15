using Solid.OCP.Library.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Library
{
    public interface IReclutamientoServicio
    {
        Empleado Contratar(IPostulante persona);
    }
}
