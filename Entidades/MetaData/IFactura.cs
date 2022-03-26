using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface IFactura
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long ClienteId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long EmpleadoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.DateTime)]
        DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        int Numero { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.Currency)]
        decimal SubTotal { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal Descuento { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.Currency)]
        decimal Total { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.Currency)]
        decimal MontoPagado { get; set; }

        decimal Iva21 { get; set; }

        decimal Iva105 { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        TipoComprobante TipoComprobante { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        EstadoComprobante EstadoComprobante { get; set; }
    }
}
