using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface IUsuario
    {
        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        long EmpleadoId { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required]
        string NombreUsuario { get; set; }

        [StringLength(50, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required]
        string Password { get; set; }


        [Required]
        bool EstaBloqueado { get; set; }
    }
}
