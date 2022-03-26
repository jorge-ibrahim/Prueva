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
    [Table("Precios")]
    [MetadataType(typeof(IPrecio))]
    public class Precio : EntidadBase
    {
        // Propiedades
        public long ListaPrecioId { get; set; }

        public long ArticuloId { get; set; }

        public decimal PrecioCosto { get; set; }

        public decimal PrecioPublico { get; set; }

        public DateTime FechaActualizacion { get; set; }

        // Propiedades de Navegacion
        public virtual Articulo Articulo { get; set; }

        public virtual ListaPrecio ListaPrecio { get; set; }
    }
}
