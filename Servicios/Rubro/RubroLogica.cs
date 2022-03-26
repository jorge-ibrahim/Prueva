using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Rubro
{
    public class RubroLogica
    {
        public void Eliminar(long id)
        {
            using (var context = new DataContext())
            {
                var eliminiarRubro = context.Rubros.FirstOrDefault(x => x.Id == id);

                eliminiarRubro.EstaEliminado = true;

                context.SaveChanges();

            }
        }

        public long Insertar(RubroDto dto)
        {
            using (var context = new DataContext())
            {
                var rudroNuevo = new Entidades.Rubro
                {
                    Descripcion = dto.Descripcion,
                };

                context.Rubros.Add(rudroNuevo);

                context.SaveChanges();

                return rudroNuevo.Id;

            }
        }

        public void Modificar(RubroDto dto)
        {
            using (var context = new DataContext())
            {
                var rubroModificar = context.Rubros.FirstOrDefault(x => x.Id == dto.Id);

                rubroModificar.Descripcion = dto.Descripcion;
                rubroModificar.EstaEliminado = dto.EstaEliminado;

                context.SaveChanges();
            }
        }

        public IEnumerable<RubroDto> Obtener(string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                return context.Rubros
                    .AsNoTracking()
                    .Where(x =>!x.EstaEliminado && (x.Descripcion.Contains(cadenaBuscar)))
                    .Select(x => new RubroDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                    }).ToList();
            }
        }

        public RubroDto ObtenerPorId(long? id)
        {
            using (var context = new DataContext())
            {
                return context.Rubros
                    .AsNoTracking().Where(x=> !x.EstaEliminado).Select(x => new RubroDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                    }).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
