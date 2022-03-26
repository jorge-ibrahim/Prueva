using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Empleado
{
    public class EmpleadoLogica
    {
        public IEnumerable<EmpleadoDto> Obtener(string cadenaBuscar)
        {
            using(var Context = new DataContext())
            {
                var empleado = Context.Empleados.AsNoTracking().Where(x => !x.EstaEliminado && (x.Apellido.Contains(cadenaBuscar)
                || x.Nombre.Contains(cadenaBuscar)
                || x.Dni == cadenaBuscar)
                ).Select(x => new EmpleadoDto
                {
                    Id = x.Id,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    Dni = x.Dni,
                    Domicilio = x.Domicilio,
                    Telefono = x.Telefono,
                    Celular = x.Celular,
                    Legajo = x.Legajo
                }).OrderBy(x => x.Apellido).ToList();

                return empleado;
            }
        }
        public EmpleadoDto ObtenerPorId(long? entidad)
        {
            using (var context = new DataContext())
            {
                var empleado = context.Empleados.AsNoTracking().Where(x=> !x.EstaEliminado).Select(x => new EmpleadoDto
                {
                    Id = x.Id,
                    Legajo = x.Legajo,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    Dni = x.Dni,
                    Domicilio = x.Domicilio,
                    Telefono = x.Telefono,
                    Celular = x.Celular
                }).FirstOrDefault(x => x.Id == entidad);

                return empleado;
            }
        }
        public long Agregar(EmpleadoDto entidad)
        {
            using(var Context = new DataContext())
            {
                var nuevoEmpleado = new Entidades.Empleado
                {
                    Legajo = entidad.Legajo,
                    Apellido = entidad.Apellido,
                    Nombre = entidad.Nombre,
                    Dni = entidad.Dni,
                    Domicilio = entidad.Domicilio,
                    Telefono = entidad.Telefono,
                    Celular = entidad.Celular,
                    EstaEliminado = false
                };

                Context.Empleados.Add(nuevoEmpleado);
                Context.SaveChanges();
                return nuevoEmpleado.Id;
            }

        }
        public void Modificar(EmpleadoDto dto)
        {
            using(var Context = new DataContext())
            {
                var empleado = Context.Empleados.FirstOrDefault(x => x.Id == dto.Id);

                empleado.Id = dto.Id;
                empleado.Legajo = dto.Legajo;
                empleado.Apellido = dto.Apellido;
                empleado.Nombre = dto.Nombre;
                empleado.Dni = dto.Dni;
                empleado.Domicilio = dto.Domicilio;
                empleado.Telefono = dto.Telefono;
                empleado.Celular = dto.Celular;

                Context.SaveChanges();
            }
        }
        public void Eliminar(long? entidad)
        {
            using(var Context = new DataContext())
            {
                var empleado = Context.Empleados.FirstOrDefault(x => x.Id == entidad);

                if (empleado == null) throw new Exception("El Empleado Fue Nulo");
                empleado.EstaEliminado = true;

                Context.SaveChanges();
            }
        }
        public int ObtenerSiguienteLegajo()
        {
            using (var Context = new DataContext())
            {
                //si hay empleados con el any entonces traigo el maximo de legajo y le sumo 1 si no asigno 1
                return Context.Empleados.Any() ? Context.Empleados.Max(x => x.Legajo) + 1 : 1000;
            }
        }

    }
}
