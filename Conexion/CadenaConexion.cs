using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class CadenaConexion
    {
        private const string BaseDatos = "DbCommerce";
       private const string Servidor = @"CASA-TRABAJO\SQLEXPRESS";
        //private const string Servidor = @"DESKTOP-59FQ4HV\SQLEXPRESS";
        private const string Usuario = "sa";
        //private const string Password = "fiorela";
        private const string Password = "Fiorela";

        public static string ObtenerCadenaConexion => $"Data Source ={Servidor}; " +
                                                      $"Initial Catalog={BaseDatos}; " +
                                                      $"User Id={Usuario}; " +
                                                      $"Password={Password};";
    }
}
