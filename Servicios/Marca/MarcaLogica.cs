using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Marca
{
    public class MarcaLogica
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

        public long Insertar(MarcaDto dto)
        {
            using (var context = new DataContext())
            {
                var nuevaMarca = new Entidades.Marca()
                {
                    Descripcion = dto.Descripcion,
                    EstaEliminado = dto.EstaEliminado,
                };

                context.Marcas.Add(nuevaMarca);

                context.SaveChanges();

                return nuevaMarca.Id;
            }
        }

        public void Modificar(MarcaDto dto)
        {
            using (var context = new DataContext())
            {
                var marcaModificar = context.Marcas.FirstOrDefault(x => x.Id == dto.Id);

                marcaModificar.Descripcion = dto.Descripcion;

                context.SaveChanges();
            }
        }

        public IEnumerable<MarcaDto> Obtener(string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                return context.Marcas
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && (x.Descripcion.Contains(cadenaBuscar)))
                    .Select(x => new MarcaDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado
                    }).ToList();
            }
        }

        public MarcaDto ObtenerPorId(long id)
        {
            using (var context = new DataContext())
            {
                return context.Marcas
                    .AsNoTracking().Where(x=> !x.EstaEliminado)
                    .Select(x => new MarcaDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado
                    }).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
