using Entidades.MetaData;
using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Facturas")]
    [MetadataType(typeof(IFactura))]
    public class Factura : EntidadBase
    {
        // Propiedades
        public long ClienteId { get; set; }

        public long EmpleadoId { get; set; }

        public long UsuarioId { get; set; }

        public DateTime Fecha { get; set; }

        public int Numero { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Descuento { get; set; }

        public decimal Total { get; set; }
        public decimal MontoPagado { get; set; }

        public decimal Iva21 { get; set; }

        public decimal Iva105 { get; set; }

        public TipoComprobante TipoComprobante { get; set; }

        public EstadoComprobante EstadoComprobante { get; set; }

        // Propiedades de Navegacion 
        public Empleado Empleado { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
