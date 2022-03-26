using Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Articulo
{
    public class ArticuloLogica
    {

        public long Agregar(ArticuloDto dto)
        {
            using(var context = new DataContext())
            {
                var lista = context.ListaPrecios.Where(x => !x.EstaEliminado);
                if (lista == null) throw new Exception("No se encontraron Listas de Precios.");
         
                try
                {
                    var articulo = new Entidades.Articulo
                    {
                        MarcaId = dto.MarcaId,
                        RubroId = dto.RubroId,
                        ProveedorId = dto.ProveedorId,
                        UnidadMedidaId = dto.UnidadMedidaId,
                        Codigo = dto.Codigo,
                        CodigoBarra = dto.CodigoBarra,
                        Descripcion = dto.Descripcion,
                        Detalle = dto.Detalle,
                        PrecioCosto = dto.PrecioCosto,
                        Stock = dto.Stock,
                        EstaEliminado = false,
                        Precios = GenerarListaPrecios(dto.PrecioCosto, lista)
                        
                    };
                    context.Articulos.Add(articulo);
                    context.SaveChanges();

                    return articulo.Id;
                }
                catch(Exception ex)
                {
                    throw new Exception($"Al crear el Artículo se produjo el error: {ex.Message}");
                }
                
            }
        }

        public void Modificar(ArticuloDto dto)
        {
            using (var context = new DataContext())
            {
                var modificarArticulo = context.Articulos.FirstOrDefault(x => x.Id == dto.Id);
                {

                    modificarArticulo.Codigo = dto.Codigo;
                    modificarArticulo.CodigoBarra = dto.CodigoBarra;
                    modificarArticulo.Descripcion = dto.Descripcion;
                    modificarArticulo.Detalle = dto.Detalle;
                    modificarArticulo.PrecioCosto = dto.PrecioCosto;
                    modificarArticulo.EstaEliminado = dto.EstaEliminado;
                    modificarArticulo.MarcaId = dto.MarcaId;
                    modificarArticulo.RubroId = dto.RubroId;
                    modificarArticulo.ProveedorId = dto.ProveedorId;
                    modificarArticulo.UnidadMedidaId = dto.UnidadMedidaId;
                    modificarArticulo.Stock = dto.Stock;
                };

                context.SaveChanges();
            }
        }

        public void ModificarStock(ArticuloDto dto)
        {
            using (var context = new DataContext())
            {
                var modificarArticulo = context.Articulos.FirstOrDefault(x => x.Id == dto.Id);
                {
                    modificarArticulo.Stock += dto.Stock ;
                };

                context.SaveChanges();
            }
        }

        public void Eliminar(long? entidadId)
        {
            using(var context = new DataContext())
            {
                var articulo = context.Articulos.AsNoTracking().FirstOrDefault(x => x.Id == entidadId);
                if (articulo == null) throw new Exception("El Articulo fue Nulo");

                articulo.EstaEliminado = true;
                context.SaveChanges();
            }
        }

        public IEnumerable<ArticuloDto> Obtener(string cadenaBuscar)
        {
            using(var context = new DataContext())
            {
                int Cod = 1000;
                int.TryParse(cadenaBuscar, out Cod);

                return context.Articulos.AsNoTracking().Include(x => x.Marca).Include(x => x.Rubro).Include(x => x.Proveedor).Where(x => !x.EstaEliminado
                && (x.Codigo == Cod
                || x.CodigoBarra == cadenaBuscar
                || x.Descripcion.Contains(cadenaBuscar)
                || x.Detalle.Contains(cadenaBuscar))).Select(x => new ArticuloDto
                {
                    Id = x.Id,
                    MarcaId = x.Marca.Id,
                    RubroId = x.Rubro.Id,
                    ProveedorId = x.Proveedor.Id,
                    UnidadMedidaId = x.UnidadMedida.Id,
                    Codigo = x.Codigo,
                    CodigoBarra = x.CodigoBarra,
                    Descripcion = x.Descripcion,
                    Detalle = x.Detalle,
                    PrecioCosto = x.PrecioCosto,
                    Stock = x.Stock
                }).OrderBy(x => x.Descripcion).ToList();
            }

        }

        public IEnumerable<ArticuloDto> ObtenerStock(string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                int Cod = 1000;
                int.TryParse(cadenaBuscar, out Cod);

                return context.Articulos.AsNoTracking().Include(x => x.Marca).Include(x => x.Rubro).Include(x => x.Proveedor).Where(x => !x.EstaEliminado
                && (x.Codigo == Cod
                || x.CodigoBarra == cadenaBuscar
                || x.Descripcion.Contains(cadenaBuscar)
                || x.Detalle.Contains(cadenaBuscar))).Select(x => new ArticuloDto
                {
                    Id = x.Id,
                    MarcaId = x.Marca.Id,
                    RubroId = x.Rubro.Id,
                    ProveedorId = x.Proveedor.Id,
                    UnidadMedidaId = x.UnidadMedida.Id,
                    Codigo = x.Codigo,
                    CodigoBarra = x.CodigoBarra,
                    Descripcion = x.Descripcion,
                    Detalle = x.Detalle,
                    PrecioCosto = x.PrecioCosto,
                    Stock = x.Stock
                }).OrderBy(x => x.Stock).ToList();
            }

        }

        public ArticuloDto ObtenerPorId(long? id)
        {
            using (var context = new DataContext())
            {
                return context.Articulos
                    .AsNoTracking().Where(x=> !x.EstaEliminado)
                    .Select(x => new ArticuloDto
                    {
                        Id = x.Id,
                        Codigo = x.Codigo,
                        CodigoBarra = x.CodigoBarra,
                        Descripcion = x.Descripcion,
                        Detalle = x.Detalle,
                        EstaEliminado = x.EstaEliminado,
                        MarcaId = x.MarcaId,
                        RubroId = x.RubroId,
                        ProveedorId = x.ProveedorId,
                        UnidadMedidaId = x.UnidadMedidaId,
                        PrecioCosto = x.PrecioCosto,

                        Stock = x.Stock,
                    }).FirstOrDefault(x => x.Id == id);
            }
        }

        public ArticuloVentaDto ObtenerPorCodigo(string codigo, long listaPrecioId)
        {
            long cod = -1;
            long.TryParse(codigo, out cod);

            var fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

            using (var context = new DataContext())
            {
                var articulo = context.Articulos.Include(x => x.Precios).Where(x => !x.EstaEliminado && (x.Codigo == cod || x.CodigoBarra == codigo) 
                && x.Precios.Any( p => p.ListaPrecioId == listaPrecioId)).FirstOrDefault();


                if (articulo != null)
                {
                    return new ArticuloVentaDto
                    {
                        Id = articulo.Id,
                        CodigoArticulo = articulo.Codigo,
                        CodigoBarraArticulo = articulo.CodigoBarra,
                        DescripcionArticulo = articulo.Descripcion,
                        DetalleArticulo = articulo.Detalle,
                        Stock = articulo.Stock,                       
                        PrecioArticulo = articulo.Precios.FirstOrDefault(x => x.ListaPrecioId == listaPrecioId &&
                        x.FechaActualizacion == articulo.Precios.Where(
                            p => p.ListaPrecioId == listaPrecioId && p.FechaActualizacion <= fechaActual).Max(f => f.FechaActualizacion)).PrecioPublico
                    };
                }
                return null;
            }
        }
        public long ObtenerSiguienteCodigo()
        {
            using(var context = new DataContext())
            {

               return context.Articulos.Any() ? context.Articulos.Max(x => x.Codigo) + 1 : 1000;

            }
        }

        private ICollection<Entidades.Precio> GenerarListaPrecios(decimal precioCosto, IEnumerable<Entidades.ListaPrecio> listaPrecios, long? articuloId = null)
        {
            var precios = new List<Entidades.Precio>();
            foreach (var l in listaPrecios)
            {
                precios.Add(new Entidades.Precio
                {
                    ArticuloId = articuloId.HasValue ? articuloId.Value : 0,
                    ListaPrecioId = l.Id,
                    PrecioCosto = precioCosto,
                    PrecioPublico = precioCosto + ((precioCosto * l.PorcentajeGanancia) / 100),
                    FechaActualizacion = DateTime.Now
                });
            }
            return precios;
        }

        
    }
}
