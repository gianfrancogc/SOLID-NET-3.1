using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Library.Modelos
{
    public class Transaccion
    {
        public int IdServicio { get; set; }
        public decimal Monto { get; set; }
        public Cliente Cliente { get; set; }
    }
}
