using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Cliente
{
    public class ClienteDto
    {
        public long Id { get; set; }
        public long CondicionIvaId { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Dni { get; set; }
        public string ApyNom => $"{Apellido} {Nombre}";
        public string Cuil { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public bool EstaEliminado { get; set; }
    }
}
