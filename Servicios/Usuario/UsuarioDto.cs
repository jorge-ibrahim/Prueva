using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Usuario
{
    public class UsuarioDto
    {
        //DATOS EMPLEADO
        public long EmpleadoId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public bool Item { get; set; }
        public string ApyNomEmpleado => $"{Apellido} {Nombre}";

        //DATOS USUARIO
        public long? UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public bool Bloqueado { get; set; }
        public string BloqueadoStr => Bloqueado ? "SI" : "NO";
    }
}
