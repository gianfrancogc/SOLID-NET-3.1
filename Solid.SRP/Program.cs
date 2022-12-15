using Solid.SRP.Library;
using Solid.SRP.Library.Modelos;
using System;

namespace Solid.SRP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new PagoService().Registrar(
                new Transaccion()
                {
                    Cliente = new Cliente()
                    {
                        IdCliente = 1
                    },
                    IdServicio = 30,
                    Monto = 0
                }));
            Console.WriteLine(new PagoService().Registrar(
                 new Transaccion()
                 {
                     Cliente = new Cliente()
                     {
                         IdCliente = 0
                     },
                     IdServicio = 30,
                     Monto = 500
                 }));
            Console.WriteLine(new PagoService().Registrar(
                 new Transaccion()
                 {
                     Cliente = new Cliente()
                     {
                         IdCliente = 2
                     },
                     IdServicio = 30,
                     Monto = 100
                 }));

            Console.ReadLine();



        }
    }
}
