using Solid.OCP.Library.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Library
{
    public class ReclutamientoServicio : IReclutamientoServicio
    {
        public Empleado Contratar(IPostulante persona)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = persona.Nombre;
            empleado.Apellidos = persona.Apellidos;
            empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.tranzact.net";

            //switch (persona.Rol)
            //{
            //    case Rol.Ingeniero:
            //        empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.aforo255-ingeniero.com";
            //        break;
            //    case Rol.Tecnico:
            //        empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.aforo255-tecnico.com";
            //        break;
            //}


            //empleado.Rol = persona.Rol;

            return empleado;

        }
    }
}
