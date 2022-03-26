using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Articulo
{
    public class ArticuloDto
    {
        public long? Id { get; set; }
        public long MarcaId { get; set; }
        public long RubroId { get; set; }
        public long ProveedorId { get; set; }
        public long UnidadMedidaId { get; set; }
        public long Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }
        public decimal Stock { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioPublico { get; set; }
        public bool EstaEliminado { get; set; }

    }
}
