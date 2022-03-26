using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.UnidadMedida
{
    public class UnidadMedidaLogica
    {
        public void Eliminar(long id)
        {
            using (var context = new DataContext())
            {
                var eliminarMarca = context.Marcas.FirstOrDefault(x => x.Id == id);

                eliminarMarca.EstaEliminado = true;

                context.SaveChanges();
            }
        }

        public long Insertar(UnidadMedidaDto dto)
        {
            using (var context = new DataContext())
            {
                var nuevaunidad = new Entidades.UnidadMedida()
                {
                    Descripcion = dto.Descripcion,
                    EstaEliminado = dto.EstaEliminado,
                };

                context.UnidadMedidas.Add(nuevaunidad);

                context.SaveChanges();

                return nuevaunidad.Id;
            }
        }

        public void Modificar(UnidadMedidaDto dto)
        {
            using (var context = new DataContext())
            {
                var unidadModificar = context.UnidadMedidas.FirstOrDefault(x => x.Id == dto.Id);

                unidadModificar.Descripcion = dto.Descripcion;

                context.SaveChanges();
            }
        }

        public IEnumerable<UnidadMedidaDto> Obtener(string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                return context.UnidadMedidas
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && (x.Descripcion.Contains(cadenaBuscar)))
                    .Select(x => new UnidadMedidaDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado
                    }).ToList();
            }
        }

        public UnidadMedidaDto ObtenerPorId(long id)
        {
            using (var context = new DataContext())
            {
                return context.Marcas
                    .AsNoTracking().Where(x => !x.EstaEliminado)
                    .Select(x => new UnidadMedidaDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado
                    }).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
