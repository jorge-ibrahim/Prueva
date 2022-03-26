using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.CondicionIva
{
    public class CondicionIvaLogica
    {
        public long Insertar(CondicionIvaDto dto)
        {
            using(var context = new DataContext())
            {
                var iva = new Entidades.CondicionIva
                {
                    Descripcion = dto.Descripcion,
                    TipoComprobante = dto.TipoComprobante,
                    EstaEliminado = false
                };
                context.CondicionIvas.Add(iva);
                context.SaveChanges();
                return iva.Id;
            }
        }

        public IEnumerable<CondicionIvaDto> Obtener(string cadenaBuscar)
        {
            using(var context = new DataContext())
            {
                return context.CondicionIvas.AsNoTracking().Where(x => !x.EstaEliminado && (x.Descripcion.Contains(cadenaBuscar))).Select(x => new CondicionIvaDto
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    TipoComprobante = x.TipoComprobante,
                    EstaEliminado = x.EstaEliminado

                }).OrderBy(x => x.Descripcion).ToList();
            }
        }

        public void Eliminar(long? id)
        {
            using(var context = new DataContext())
            {
                var entidad = context.CondicionIvas.FirstOrDefault(x => x.Id == id);
                entidad.EstaEliminado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(CondicionIvaDto dto)
        {
            using(var context = new DataContext())
            {
                var entidad = context.CondicionIvas.FirstOrDefault(x => x.Id == dto.Id);

                entidad.Descripcion = dto.Descripcion;
                entidad.TipoComprobante = dto.TipoComprobante;

                context.SaveChanges();
            }
        }

        public CondicionIvaDto ObtenerPorId(long condicionId)
        {
            using (var context = new DataContext())
            {
                return context.CondicionIvas
                    .AsNoTracking().Where(x=> !x.EstaEliminado)
                    .Select(x => new CondicionIvaDto()
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        TipoComprobante = x.TipoComprobante,
                        EstaEliminado = x.EstaEliminado,

                    }).FirstOrDefault(x => x.Id == condicionId);
            }
        }

    }
}
