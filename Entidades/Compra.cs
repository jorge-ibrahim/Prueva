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
    [Table("Compra")]
    [MetadataType(typeof(ICompra))]
    public class Compra :  EntidadBase
    {
        //PROPIEDADES
        public int CodigoCompra { get; set; }
        public long? EmpleadoId { get; set; }
        public long? ProveedorId { get; set; }
        public long? ArticuloId { get; set; }
        public string NombreProveedor { get; set; }
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal NuevoStock { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal PrecioArticulo { get; set; }
        public string PrecioArticuloStr { get; set; }
        public decimal MontoTotal { get; set; }
        public string MontoTotalStr { get; set; }

        //NAVEGACION
        public virtual Empleado Empleado { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public ICollection<Articulo> Articulos { get; set; }
    }
}
