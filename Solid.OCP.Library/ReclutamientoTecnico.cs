using Solid.OCP.Library.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Library
{
    public class ReclutamientoTecnico : IReclutamientoServicio
    {
        public Empleado Contratar(IPostulante persona)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = persona.Nombre;
            empleado.Apellidos = persona.Apellidos;
            empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.tranzact-tecnico.net";
            return empleado;
        }
    }
}
