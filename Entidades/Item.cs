using Entidades.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Items")]
    [MetadataType(typeof(IItem))]
    public class Item : EntidadBase
    {
        // Propiedades
        public long FacturaId { get; set; }

        public long ArticuloId { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Iva { get; set; }

        public decimal SubTotal { get; set; }

        // Propiedades de Navegacion
        public virtual Factura Factura { get; set; }
    }
}
