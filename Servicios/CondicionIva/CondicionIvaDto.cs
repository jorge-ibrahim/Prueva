using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.CondicionIva
{
    public class CondicionIvaDto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public bool EstaEliminado { get; set; }
    }
}
