using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Caja
{
    public class MovimientoDto : BaseDto
    {
        public long? CajaId { get; set; }
        public long? UsuarioId { get; set; }
        public long? FacturaId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
    }
}
