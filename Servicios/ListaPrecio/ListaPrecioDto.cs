using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ListaPrecio
{
    public class ListaPrecioDto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }

        public decimal PorcentajeGanancia { get; set; }

        public bool NecesitaAutorizacion { get; set; }

        public string NecesitaAutorizacionStr => NecesitaAutorizacion ? "Sí" : "No";
        public bool EstaEliminado { get; set; }
    }
}
