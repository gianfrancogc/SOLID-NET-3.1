using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Library
{
    public static class Validacion
    {
        public static ValidacionRespuesta RealizarValidaciones(Modelos.Transaccion transaccion)
        {
            ValidacionRespuesta respuesta = new ValidacionRespuesta();
            respuesta.EsValido = true;
            if (!ValidarClienteActivo(transaccion.Cliente.IdCliente))
            {
                respuesta.Mensaje = respuesta.Mensaje + "El pago no puede ser registrado debido a que el cliente no esta activo" + Environment.NewLine;
                respuesta.EsValido = false;
            }

            if (transaccion.Monto <= 0)
            {
                respuesta.Mensaje = respuesta.Mensaje + "El pago no puede ser registrado debido a que el monto no es mayor a cero" + Environment.NewLine;
                respuesta.EsValido = false;
            }


            return respuesta;
        }

        public static bool ValidarClienteActivo(int idCliente)
        {
            if (idCliente != 0)
                return true;
            else
                return false;
        }
    }
    }
