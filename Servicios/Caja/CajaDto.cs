using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Caja
{
    public class CajaDto : BaseDto
    {
        // Apertura

        //[ForeignKey("UsuarioApertura")]
        public long UsuarioAperturaId { get; set; }
        public string UsuarioApertura { get; set; }
        public string ApellidoEmpleadoApertura { get; set; }
        public string NombreEmpleadoApertura { get; set; }
        public string ApyNomEmpleadoApertura => $"{ApellidoEmpleadoApertura} {NombreEmpleadoApertura}";
        public decimal MontoInicial { get; set; }
        public DateTime FechaApertura { get; set; }

        // Cierre

        public DateTime? FechaCierre { get; set; }

        //[ForeignKey("UsuarioCierre")]
        public long? UsuarioCierreId { get; set; }
        public string UsuarioCierre { get; set; }
        public string ApellidoEmpleadoCierre { get; set; }
        public string NombreEmpleadoCierre { get; set; }

        public string ApyNomEmpleadoCierre => $"{ApellidoEmpleadoCierre} {NombreEmpleadoCierre}";
        public decimal? MontoCierre { get; set; }
        public decimal? TotalEfectivo { get; set; }
        public decimal? TotalEgresos { get; set; }

        //public string EstadoCajaStr => FechaCierre.a
        public decimal? TotalTarjeta { get; set; }
        public decimal? TotalCheque { get; set; }
        public decimal? TotalCuentaCorriente { get; set; }
        public bool EstadoCaja { get; set; }
        //public IEnumerable<DetalleCajaDto> DetalleCajas { get; set; }
    }
}
