using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor : EntidadBase
    {
        public string RazonSocial { get; set; }
        public string Cuil { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        //NAVEGACION

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
