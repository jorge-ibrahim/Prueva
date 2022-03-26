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
    [Table("Venta")]
    [MetadataType(typeof(IVenta))]
    public class Venta : EntidadBase
    {
        //PROPIEDADES
        public int Codigo { get; set; }
        public long? EmpleadoId { get; set; }
        public long? ClienteId { get; set; }
        public long? ArticuloId { get; set; }
        public string NombreVendedor { get; set; }
        public string NombreCliente { get; set; }
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal NuevoStock { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal PrecioArticulo { get; set; }
        public string PrecioArticuloStr { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal MontoTotal { get; set; }
        public string MontoTotalStr { get; set; }
        public decimal Vuelto { get; set; }

        //NAVEGACION
        public virtual Empleado Empleado { get; set; }
        public virtual Cliente Cliente { get; set; }
        public ICollection<Articulo> Articulos { get; set; }
    }
}
