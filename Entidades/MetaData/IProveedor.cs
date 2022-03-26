using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface IProveedor
    {
        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required]
        string RazonSocial { get; set; }

        [Required]
        string Cuil { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required]
        string Direccion { get; set; }

        [Required]
        string Telefono { get; set; }

        [Required]
        string Celular { get; set; }

        [Required]
        string Email { get; set; }
    }
}
