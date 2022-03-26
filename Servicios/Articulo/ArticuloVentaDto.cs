using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Articulo
{
    public class ArticuloVentaDto
    {
        public long Id { get; set; }
        public long CodigoArticulo { get; set; }
        public string CodigoBarraArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public string DetalleArticulo { get; set; }
        public string IvaStr { get; set; }
        public decimal Stock { get; set; }
        public decimal PrecioArticulo { get; set; }
        public long IvaId { get; set; }//agregados 2 prop
        public decimal MontoIva105 { get; set; }
        public decimal MontoIva21 { get; set; }
        public bool EstaEliminado { get; set; }
    }
}
