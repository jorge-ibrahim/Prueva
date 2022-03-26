using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadBase
    {
        [Key]
        public long Id { get; set; }

        [DefaultValue(false)]
        public bool EstaEliminado { get; set; }
    }
}
