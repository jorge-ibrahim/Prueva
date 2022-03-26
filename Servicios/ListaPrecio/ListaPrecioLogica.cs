using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ListaPrecio
{
    public class ListaPrecioLogica
    {
        public long Insertar(ListaPrecioDto entidad)
        {
            using(var context = new DataContext())
            {
                var ed =  new Entidades.ListaPrecio
                {
                    Descripcion = entidad.Descripcion,
                    PorcentajeGanancia = entidad.PorcentajeGanancia,
                    NecesitaAutorizacion = entidad.NecesitaAutorizacion,
                    EstaEliminado = false
                };

                context.ListaPrecios.Add(ed);
                context.SaveChanges();
                return ed.Id;
            }
        }

        public void Eliminar(long id)
        {
            using(var context = new DataContext())
            {
                var entidad = context.ListaPrecios.FirstOrDefault(x => x.Id == id);
                if (entidad == null) throw new Exception("EL objeto fue nulo");
                entidad.EstaEliminado = true;
                context.SaveChanges();
            }
        }

        public IEnumerable<ListaPrecioDto> Obtener(string cadenaBuscar)
        {
            using(var context = new DataContext())
            {
                return context.ListaPrecios.AsNoTracking().Where(x => !x.EstaEliminado && (x.Descripcion.Contains(cadenaBuscar))).Select(x => new ListaPrecioDto
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    PorcentajeGanancia = x.PorcentajeGanancia,
                    NecesitaAutorizacion = x.NecesitaAutorizacion,
                    EstaEliminado = x.EstaEliminado
                }).OrderBy(x => x.Descripcion).ToList();
            }
        }

        public ListaPrecioDto ObtenerPorId(long id)
        {
            using(var context = new DataContext())
            {
                return context.ListaPrecios.AsNoTracking().Where(x => !x.EstaEliminado).Select(x => new ListaPrecioDto
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    PorcentajeGanancia = x.PorcentajeGanancia,
                    NecesitaAutorizacion = x.NecesitaAutorizacion,
                    EstaEliminado = x.EstaEliminado
                }).FirstOrDefault(x => x.Id == id);
            }
        }

        public void Modificar(ListaPrecioDto dto)
        {
            using (var context = new DataContext())
            {
                var entidad = context.ListaPrecios.FirstOrDefault(x => x.Id == dto.Id);

                entidad.Descripcion = dto.Descripcion;
                entidad.PorcentajeGanancia = dto.PorcentajeGanancia;
                entidad.NecesitaAutorizacion = dto.NecesitaAutorizacion;
                entidad.EstaEliminado = dto.EstaEliminado;

                context.SaveChanges();
            }
        }      
    }
}
