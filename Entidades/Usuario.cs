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
    [Table("Usuario")]
    [MetadataType(typeof(IUsuario))]
    public class Usuario : EntidadBase
    {
        public long EmpleadoId { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool EstaBloqueado { get; set; }

        //NAVEGACION
        public virtual Empleado Empleado { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
