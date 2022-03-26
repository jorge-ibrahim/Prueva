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
    [Table("CondicionIva")]
    [MetadataType(typeof(ICondicionIva))]
    public class CondicionIva : EntidadBase
    {
        // Propiedades
        public string Descripcion { get; set; }
        public TipoComprobante TipoComprobante { get; set; }//no estaba

        // Propiedades de Navegacion
        public virtual ICollection<Cliente> Clientes { get; set; }

        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
