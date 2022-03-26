using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface ICompra
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        int CodigoCompra { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long? EmpleadoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long? ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long? ArticuloId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string NombreProveedor { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        int CodigoProducto { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string DescripcionProducto { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal NuevoStock { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.Time)]
        DateTime FechaCompra { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal PrecioArticulo { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string PrecioArticuloStr { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal MontoTotal { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string MontoTotalStr { get; set; }
    }
}
