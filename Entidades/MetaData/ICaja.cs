using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
   public interface ICaja
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long UsuarioAperturaId { get; set; }

        [StringLength(50, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string NEmpleadoApertura { get; set; }

        [StringLength(50, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string AEmpleadoApertura { get; set; }


        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal MontoInicial { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        DateTime FechaApertura { get; set; }

        [DataType(DataType.DateTime)]
        DateTime? FechaCierre { get; set; }
        long? UsuarioCierreId { get; set; }

        [StringLength(50, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string NEmpleadoCierre { get; set; }

        [StringLength(50, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string AEmpleadoCierre { get; set; }



        [DataType(DataType.Currency)]
        decimal? MontoCierre { get; set; }

        [DataType(DataType.Currency)]
        decimal? TotalEfectivo { get; set; }

        [DataType(DataType.Currency)]
        decimal? TotalEgresos { get; set; }
   
        [DataType(DataType.Currency)]
        decimal? TotalTarjeta { get; set; }

        [DataType(DataType.Currency)]
        decimal? TotalCheque { get; set; }

        [DataType(DataType.Currency)]
        decimal? TotalCuentaCorriente { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        bool EstadoCaja { get; set; }
    }
}
