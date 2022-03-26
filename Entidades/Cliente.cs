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
    [Table("Clientes")]
    [MetadataType(typeof(ICliente))]
    public class Cliente : EntidadBase
    {
        public long CondicionIvaId { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Cuil { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }


        //NAVEGACION

        public virtual CondicionIva CondicionIva { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }//venta del negocio hacia el cliente

    }
}
