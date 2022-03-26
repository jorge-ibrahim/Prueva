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
    [Table("Persona_Empleado")]
    [MetadataType(typeof(IEmpleado))]
    public class Empleado : EntidadBase
    {
        public int Legajo { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Dni { get; set; }

        public string Domicilio { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        //NAVEGACION

        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }

    }
}
