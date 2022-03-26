using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface IArticulo
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long MarcaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long RubroId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long UnidadMedidaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long Codigo { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string CodigoBarra { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Descripcion { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Detalle { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal Stock { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        decimal PrecioCosto { get; set; }

    }
}
