using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Provincia
{
    public class ProvinciaDto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public bool EstaEliminado { get; set; }
    }
}
