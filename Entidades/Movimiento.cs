using Entidades.MetaData;
using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Movimientos")]
    [MetadataType(typeof(IMovimiento))]
    public class Movimiento : EntidadBase
    {
        public long? CajaId { get; set; }
        public long? UsuarioId { get; set; }
        public long? FacturaId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public decimal Monto { get; set; }

        //NAVEGACION
        public virtual Caja Caja { get; set; }
        public virtual  Usuario Usuario { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
