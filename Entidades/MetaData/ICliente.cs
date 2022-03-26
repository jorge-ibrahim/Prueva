using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface ICliente
    {

        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        long CondicionIvaId { get; set; }


        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string RazonSocial { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string Nombre { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string Apellido { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string Dni { get; set; }


        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string Cuil { get; set; }


        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Domicilio { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string Telefono { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        string Celular { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Email { get; set; }
    }
}
