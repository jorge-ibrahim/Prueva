using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Base.Clases
{
    public class Porcentaje
    {
        public static decimal CalcularMontoDescuento(decimal porcentaje, decimal monto)
        {
            return (porcentaje * monto) / 100m;
        }
    }
}
