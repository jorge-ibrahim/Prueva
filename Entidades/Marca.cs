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
    [Table("Marcas")]
    [MetadataType(typeof(IMarca))]
    public class Marca : EntidadBase
    {
        public string Descripcion { get; set; }

        //NAVEGACION

        public virtual ICollection<Articulo> Articulos { get; set; }
    }

 

    
}
