using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Base.Clases
{
    public enum TipoComprobante
    {
        A = 1,//responsable inscripto a un igual
        B = 2,//responsable incriptp para consumidor final
        C = 3,//entrega el monotributista
        Remito = 4,
        Presupuesto = 5,
        Nota_Credito = 6
    }
}
