using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Proveedor
{
    public class ProveedorLogica
    {
        public IEnumerable<ProveedorDto> Obtener(string cadenaBuscar)
        {
            using (var Context = new DataContext())
            {
                var proveedor = Context.Proveedores.AsNoTracking().Where(x => !x.EstaEliminado && (x.RazonSocial.Contains(cadenaBuscar)
                || x.Cuil.Contains(cadenaBuscar))).Select(x => new ProveedorDto
                {
                    Id = x.Id,
                    RazonSocial = x.RazonSocial,
                    Cuil = x.Cuil,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Celular = x.Celular,
                    Email = x.Email,
                    EstaEliminado = x.EstaEliminado

                }).OrderBy(x => x.RazonSocial).ToList();

                return proveedor;
            }
        }

        public ProveedorDto ObtenerId(long? entidadId)
        {
            using(var Context = new DataContext())
            {
                var empleado = Context.Proveedores.AsNoTracking().Where(x => !x.EstaEliminado).Select(x => new ProveedorDto
                {
                    Id = x.Id,
                    RazonSocial = x.RazonSocial,
                    Cuil = x.Cuil,
                    Telefono = x.Telefono,
                    Celular = x.Celular,
                    Direccion = x.Direccion,
                    Email = x.Email,
                    EstaEliminado = x.EstaEliminado
                }).FirstOrDefault(x => x.Id == entidadId);
                return empleado;
            }
        }
        public long Agregar(ProveedorDto entidad)
        {
            using(var Context = new DataContext())
            {
                var Nproveedor = new Entidades.Proveedor
                {
                    RazonSocial = entidad.RazonSocial,
                    Cuil = entidad.Cuil,
                    Direccion = entidad.Direccion,
                    Telefono = entidad.Telefono,
                    Celular = entidad.Celular,
                    Email = entidad.Email,
                    EstaEliminado = false
                };

                Context.Proveedores.Add(Nproveedor);
                Context.SaveChanges();
                return Nproveedor.Id;
            }
        }

        public void Modificar(ProveedorDto dto)
        {
            using(var Context = new DataContext())
            {
                var proveedor = Context.Proveedores.FirstOrDefault(x => x.Id == dto.Id);

               // proveedor.Id = dto.Id;
                proveedor.RazonSocial = dto.RazonSocial;
                proveedor.Cuil = dto.Cuil;
                proveedor.Telefono = dto.Telefono;
                proveedor.Celular = dto.Celular;
                proveedor.Direccion = dto.Direccion;
                proveedor.Email = dto.Email;
                proveedor.EstaEliminado = dto.EstaEliminado;

                Context.SaveChanges();
            }

        }

        public void Eliminar(long entidad)
        {
            using (var Context = new DataContext())
            {
                var proveedor = Context.Proveedores.FirstOrDefault(x => x.Id == entidad);

                if (proveedor != null)
                {
                    proveedor.EstaEliminado = true;
                }
                if (proveedor == null)
                    throw new Exception("No se encontro el Cliente");

                //Context.Proveedores.Remove(proveedor);
                Context.SaveChanges();
            }
        }

    }
}
