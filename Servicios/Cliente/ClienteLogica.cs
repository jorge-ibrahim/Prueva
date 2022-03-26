using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Cliente
{
    public class ClienteLogica
    {
        public long Insertar(ClienteDto entidad)
        {
            using(var Context = new DataContext())
            {
                var nuevo = new Entidades.Cliente
                {
                    Apellido = entidad.Apellido,
                    Nombre = entidad.Nombre,
                    RazonSocial = entidad.RazonSocial,
                    Cuil = entidad.Cuil,
                    Domicilio = entidad.Domicilio,
                    Telefono = entidad.Telefono,
                    Dni = entidad.Dni,
                    CondicionIvaId = entidad.CondicionIvaId,
                    Celular = entidad.Celular,
                    Email = entidad.Email,
                    EstaEliminado = false
                };
                Context.Clientes.Add(nuevo);
                Context.SaveChanges();

                return nuevo.Id;
            }
        }
        public void Modificar(ClienteDto dto)
        {
            using (var Context = new DataContext())
            {
                var cliente = Context.Clientes.FirstOrDefault(x => x.Id == dto.Id);

                cliente.Id = dto.Id;
                cliente.Apellido = dto.Apellido;
                cliente.Nombre = dto.Nombre;
                cliente.RazonSocial = dto.RazonSocial;
                cliente.Cuil = dto.Cuil;
                cliente.Dni = dto.Dni;
                cliente.CondicionIvaId = dto.CondicionIvaId;
                cliente.Domicilio = dto.Domicilio;
                cliente.Telefono = dto.Telefono;
                cliente.Celular = dto.Celular;
                cliente.Email = dto.Email;

                Context.SaveChanges();
            }
        }
        public void Eliminar(long clienteId)
        {
            using (var context = new DataContext())
            {
                var clienteEliminar = context.Clientes
                    .FirstOrDefault(x => x.Id == clienteId);

                if (clienteEliminar == null)
                    throw new Exception("No se encontro el Cliente");

                clienteEliminar.EstaEliminado = true;
              //  clienteEliminar.EstaEliminado = true;
             // context.Clientes.Remove(clienteEliminar);
                context.SaveChanges();
            }
        }
        public IEnumerable<ClienteDto> Obtener(string cadenaBuscar)
        {
            using(var Context = new DataContext())
            {
                var clientes = Context.Clientes.AsNoTracking().
                    Where(x => !x.EstaEliminado && (x.RazonSocial.Contains(cadenaBuscar)
                    || x.Nombre.Contains(cadenaBuscar)
                    || x.Apellido.Contains(cadenaBuscar))
                 ) .Select(x => new ClienteDto
                {
                    Id = x.Id,
                    RazonSocial = x.RazonSocial,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    Cuil = x.Cuil,
                    Dni = x.Dni,
                    CondicionIvaId = x.CondicionIvaId,
                    Domicilio = x.Domicilio,
                    Telefono = x.Telefono,
                    Celular = x.Celular,
                    Email = x.Email,
                    EstaEliminado = x.EstaEliminado

                }).OrderBy(x => x.Apellido).ThenBy(x => x.Nombre).ToList();

                return clientes;
            }

        }
        public ClienteDto ObtenerPorId(long? entidad)
        {
            using (var context = new DataContext())
            {
                var cliente = context.Clientes.AsNoTracking().Select(x => new ClienteDto
                {
                    Id = x.Id,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    RazonSocial = x.RazonSocial,
                    Cuil = x.Cuil,
                    Dni = x.Dni,
                    CondicionIvaId = x.CondicionIvaId,
                    Domicilio = x.Domicilio,
                    Telefono = x.Telefono,
                    Celular = x.Celular,
                    Email = x.Email

                }).FirstOrDefault(x => x.Id == entidad);

                return cliente;
            }
        }
    }
}
