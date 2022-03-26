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
    [Table("Cajas")]
    [MetadataType(typeof(ICaja))]
    public class Caja : EntidadBase
    {
        // Apertura

        [ForeignKey("UsuarioApertura")]
        public long UsuarioAperturaId { get; set; }
        public string NEmpleadoApertura { get; set; }
        public string AEmpleadoApertura { get; set; }
        public decimal MontoInicial { get; set; }
        public DateTime FechaApertura { get; set; }

        // Cierre

        public DateTime? FechaCierre { get; set; }

        [ForeignKey("UsuarioCierre")]
        public long? UsuarioCierreId { get; set; }
        public string NEmpleadoCierre { get; set; }
        public string AEmpleadoCierre { get; set; }
        public decimal? MontoCierre { get; set; } //toma el monto de cierre anterior como caja de inicio
        public decimal? TotalVentaEfectivo { get; set; }
        public decimal? TotalEfectivo { get; set; }
        public decimal? TotalEgresos { get; set; }
        public decimal? TotalTarjeta { get; set; }
        public decimal? TotalCheque { get; set; }
        public decimal? TotalCuentaCorriente { get; set; }
        public bool EstadoCaja { get; set; }



        // Propiedades de Navegacion
        public Usuario UsuarioApertura { get; set; }

        public Usuario UsuarioCierre { get; set; }

        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
