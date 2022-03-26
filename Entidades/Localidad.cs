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

    [Table("Localidades")]
    [MetadataType(typeof(ILocalidad))]
    public class Localidad : EntidadBase
    {
        public long? ProvinciaId { get; set; }
       // public string Provincia { get; set; }
        public string Descripcion { get; set; }

        //NAVEGACION

        public virtual Provincia Provincias { get; set; }

    }
}
