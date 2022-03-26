using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Localidad
{
    public class LocalidadLogica
    {
        public void Eliminar(long localidadId)
        {
            using (var context = new DataContext())
            {
                var localidadEliminar = context.Localidades
                    .FirstOrDefault(x => x.Id == localidadId);

                if (localidadEliminar == null)
                    throw new Exception("Ocurrio un error al Obtener la Localidad");

                localidadEliminar.EstaEliminado = true;

                context.SaveChanges();
            }
        }

        public long Insertar(LocalidadDto localidadDto)
        {
            using (var context = new DataContext())
            {
                var localidadNueva = new Entidades.Localidad
                {
                    Descripcion = localidadDto.Descripcion,
                    ProvinciaId = localidadDto.ProvinciaId
                };

                context.Localidades.Add(localidadNueva);

                context.SaveChanges();

                return localidadNueva.Id;
            }
        }

        public void Modificar(LocalidadDto localidadDto)
        {
            using (var context = new DataContext())
            {
                var localidadModificar = context.Localidades
                    .FirstOrDefault(x => x.Id == localidadDto.Id);

                if (localidadModificar == null)
                    throw new Exception("Ocurrio un error al Obtener la Provincia");

                localidadModificar.Descripcion = localidadDto.Descripcion;
                localidadModificar.ProvinciaId = localidadDto.ProvinciaId;

                context.SaveChanges();
            }
        }

        public IEnumerable<LocalidadDto> Obtener(string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                return context.Localidades
                    .AsNoTracking()
                    .Include(x => x.Provincias)
                    .Where(x => !x.EstaEliminado && (x.Descripcion.Contains(cadenaBuscar)))
                    .Select(x => new LocalidadDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        ProvinciaId = x.ProvinciaId,
                        Provincia = x.Provincias.Descripcion,
                        EstaEliminado = x.EstaEliminado
                    }).ToList();
            }
        }

        public IEnumerable<LocalidadDto> ObtenerPorProvincia(long provinciaId, string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                return context.Localidades
                    .AsNoTracking()
                    .Include(x => x.Provincias)
                    .Where(x => x.ProvinciaId == provinciaId
                                && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new LocalidadDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        ProvinciaId = x.ProvinciaId,
                        Provincia = x.Provincias.Descripcion,//el provincias es de la prop de navegacion
                        EstaEliminado = x.EstaEliminado
                    }).ToList();
            }
        }

        public LocalidadDto ObtenerPorId(long localidadId)
        {
            using (var context = new DataContext())
            {
                return context.Localidades
                    .Include(x => x.Provincias)
                    .AsNoTracking().Where(x => !x.EstaEliminado)
                    .Select(x => new LocalidadDto
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        ProvinciaId = x.ProvinciaId,
                        Provincia = x.Provincias.Descripcion,
                        EstaEliminado = x.EstaEliminado
                    }).FirstOrDefault(x => x.Id == localidadId);
            }
        }
    }
}
