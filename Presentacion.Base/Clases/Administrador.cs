using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Base.Clases
{
    public static class Administrador
    {
        private static string _password = @"1234";

        private static string _usuarioAdmin = @"jadmin";
        private static string _passwordAdmin = @"plut@n";

        public static string PasswordPorDefecto => $"{_password}";

        public static string UsuarioAdministrador => $"{_usuarioAdmin}";
        public static string PasswordAdministrador => $"{_passwordAdmin}";

        public static int IntentosFallidos = 3;
    }
}
