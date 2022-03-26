using Conexion;
using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios.Usuario
{
    public class UsuarioLogica
    {

        public IEnumerable<UsuarioDto>Obtener(string cadenaBuscar)
        {
            using(var context = new DataContext())
            {
                var legajo = -1;
                int.TryParse(cadenaBuscar, out legajo);

                return context.Empleados.AsNoTracking().Include(x => x.Usuarios).Where(x => !x.EstaEliminado && (x.Dni.Contains(cadenaBuscar)
                || x.Legajo == legajo
                || x.Nombre.Contains(cadenaBuscar)
                || x.Apellido.Contains(cadenaBuscar))).Select(x => new UsuarioDto
                {
                    EmpleadoId = x.Id,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    Item = false,//es el que uso para poder checkear si creo o no el usuario
                    UsuarioId = x.Usuarios.Any() ? x.Usuarios.FirstOrDefault().Id : (long?)null,
                    NombreUsuario = x.Usuarios.Any() ? x.Usuarios.FirstOrDefault().NombreUsuario : "NO ASIGNADO",
                    Bloqueado = x.Usuarios.Any() && x.Usuarios.FirstOrDefault().EstaBloqueado

                }).OrderBy(x => x.Apellido).ThenBy(x => x.Nombre).ToList();

            }

        }

        public void Crear(List<UsuarioDto> listaUsuarios)
        {
            using(var context = new DataContext())
            {
                try
                {
                    foreach (var usuario in listaUsuarios)
                    {
                        var nombreusuario = GenerarNombreUsuario(usuario.Apellido, usuario.Nombre);

                        var usuarionuevo = new Entidades.Usuario
                        {
                            NombreUsuario = nombreusuario,
                            EstaBloqueado = false,
                            EmpleadoId = usuario.EmpleadoId,
                            Password = "123456"
                        };

                        context.Usuarios.Add(usuarionuevo);
                    }                   

                }
                
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al crear los usuarios");
                }

                context.SaveChanges();
            }        
        }

        private string GenerarNombreUsuario(string apellido,string nombre)
        {
            var contador = 1;
            var nombreusuario = $"{nombre.Trim().ToLower().Substring(0, contador)}{apellido.Trim().ToLower()}";

            using(var context = new DataContext())
            {
                while(context.Usuarios.Any(x => x.NombreUsuario == nombreusuario))//fijate en la tabla si hay algo en la tabla con este usuario si hay retorno nombreusuario si no lo creo
                {
                    contador++;//incremento el contador para que genere el usuari ya no con 1 letra si no con 2 y poder tener un usuario diferente del otro
                    nombreusuario = $"{nombre.Trim().ToLower().Substring(0, contador)}{apellido.Trim().ToLower()}";
                }
            }
            return nombreusuario;
        }

        public bool VerificarSiExiste(string usuario, string contraseña)
        {          
            using(var context = new DataContext())
            {
                return context.Usuarios.Any(x => x.NombreUsuario == usuario && x.Password == contraseña);
            }
        }

        public bool VerificarBloqueado(string nombreusuario)
        {
            using(var context = new DataContext())
            {
                return context.Usuarios.Any(x => x.NombreUsuario == nombreusuario && x.EstaBloqueado);
            }
        }

        public UsuarioDto ObtenerPorNombre(string usuarioConectado)
        {
            using (var context = new DataContext())
            {
                var usuario = context.Usuarios.Include(x => x.Empleado).Where(x=> !x.EstaEliminado).Select(x => new UsuarioDto
                {
                    UsuarioId = x.Id,
                    EmpleadoId = x.EmpleadoId,
                    Nombre = x.Empleado.Nombre,
                    Apellido = x.Empleado.Apellido,
                    Bloqueado = x.EstaBloqueado,
                    NombreUsuario = x.NombreUsuario
                }).FirstOrDefault(x => x.NombreUsuario == usuarioConectado);

                return usuario;               
            }

        }

        public void CambiarEstado(string nombreusuario,bool estado)
        {
            using(var context = new DataContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(x => x.NombreUsuario == nombreusuario);
                if (usuario == null)
                    throw new Exception($"No se encontro el usuario {nombreusuario}");

                usuario.EstaBloqueado = estado;

                context.SaveChanges();
            }
        }

    }
}
