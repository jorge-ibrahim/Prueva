using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Base.Clases
{
    public static class Identidad
    {

        public static long EmpleadoId { get; set; }
        public static long CajaId { get; set; }
        public static long UsuarioLogueadoId { get; set; }
        public static string UsuarioLogueado { get; set; }

        public static string ApellidoEmpleado { get; set; }
        public static string ApyNomUsuarioLogin => $"{ApellidoEmpleado} {NombreEmpleado}";
        public static string NombreEmpleado { get; set; }

     //   public static string ApyNom => $"{ApellidoEmpleado} {NombreEmpleado}";

       // public static string SaludoUsuarioLogin => $"Hola {ApyNom}";
    }
}
