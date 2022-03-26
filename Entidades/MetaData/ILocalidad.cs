using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetaData
{
    public interface ILocalidad
    {
        [Required]
        long? ProvinciaId { get; set; }

        [StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required]
        string Descripcion { get; set; }
    }
}
