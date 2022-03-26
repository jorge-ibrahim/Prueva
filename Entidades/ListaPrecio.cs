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
    [Table("ListaPrecios")]
    [MetadataType(typeof(IListaPrecio))]
    public class ListaPrecio : EntidadBase
    {
        // Propiedades
        public string Descripcion { get; set; }

        public decimal PorcentajeGanancia { get; set; }

        public bool NecesitaAutorizacion { get; set; }

        // Propiedades de Navegacion
        public virtual ICollection<Precio> Precios { get; set; }
    }
}
