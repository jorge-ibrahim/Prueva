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
    [Table("Articulo")]
    [MetadataType(typeof(IArticulo))]
    public class Articulo : EntidadBase
    {
        // Propiedades
        public long MarcaId { get; set; }
        public long RubroId { get; set; }
        public long ProveedorId { get; set; }
        public long UnidadMedidaId { get; set; }
        public long Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }
        public decimal Stock { get; set; }
        public decimal PrecioCosto { get; set; }



        // Propiedades de Navegacion

        public virtual Marca Marca { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
        public virtual ICollection<Precio> Precios { get; set; }

    }
}
