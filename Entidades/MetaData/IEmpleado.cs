using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface IEmpleado
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [Range(1, 99999999, ErrorMessage = "El campo {0} debe estar entre {1} y {2}.")]
        int Legajo { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string Apellido { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string Dni { get; set; }

        [StringLength(300, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string Domicilio { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        string Celular { get; set; }

        [DefaultValue(false)]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        bool EstaEliminado { get; set; }
    }
}
