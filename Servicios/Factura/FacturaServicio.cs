using Conexion;
using Presentacion.Base.Clases;
using Servicios.Articulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Factura
{
    
    public class FacturaServicio
    {
        private ArticuloLogica _articuloLogica;
        public FacturaServicio()
        {
            _articuloLogica = new ArticuloLogica();
        }


        public long Grabar(FacturaDto entidad)
        {
            using(var context = new DataContext())
            {
                var factura = context.Facturas.FirstOrDefault(x => x.Id == entidad.Id);

                if(factura == null)//Si no Existe una factura, creo una nueva
                {
                    var facturaNueva = new Entidades.Factura
                    {
                        Numero = entidad.Numero,//numero factura
                        ClienteId = entidad.ClienteFacturaId,
                        UsuarioId = entidad.UsuarioId,
                        EmpleadoId = entidad.EmpleadoId,
                        TipoComprobante = entidad.TipoComprobante,
                        Fecha = entidad.Fecha,
                        Iva105 = entidad.Iva105,
                        Iva21 = entidad.Iva21,
                        Descuento = entidad.Descuento,
                        SubTotal = entidad.SubTotal,
                        Total = entidad.Total,
                        MontoPagado = 0,
                        EstadoComprobante = entidad.EstadoComprobante,
                    };

                    facturaNueva.Items = new List<Entidades.Item>();
                    foreach (var it in entidad.Items)
                    {
                        var articulo = _articuloLogica.ObtenerPorId(it.ArticuloId);
                        facturaNueva.Id = entidad.Id;
                        facturaNueva.Items.Add(new Entidades.Item
                        {
                            EstaEliminado = false,
                            ArticuloId = it.ArticuloId,
                            FacturaId = it.FacturaId,
                            Cantidad = it.Cantidad,
                            Codigo = it.Codigo,
                            Descripcion = it.Descripcion,
                            Precio = it.Precio,
                            SubTotal = it.SubTotal,
                            Iva = it.Iva

                        });
                    }
                    context.Facturas.Add(facturaNueva);
                    context.SaveChanges();

                    return facturaNueva.Id;
                }
                else//si ya existe una factura(es porque se esta por realizar el proceso de pagar) esta se modificara
                {
                    //asigno la caja abierta en la que se esta por pagar la factura
                    var caja = context.Cajas.FirstOrDefault(x => x.Id == entidad.CajaId);
                    //preparo para agregar movimiento de ingreso en la caja
                    caja.Movimientos = new List<Entidades.Movimiento>();

                    factura.MontoPagado = entidad.MontoPagado;
                    factura.EstadoComprobante = EstadoComprobante.Pagado;

                    caja.Movimientos.Add(new Entidades.Movimiento
                    {
                        EstaEliminado = false,
                        FacturaId = entidad.Id,
                        CajaId = entidad.CajaId,
                        Fecha = factura.Fecha,
                        Monto = factura.MontoPagado,
                        TipoMovimiento = TipoMovimiento.Ingreso,
                        UsuarioId = factura.UsuarioId,
                        Descripcion = $"- Nro Factura: {factura.Numero} - Total: {factura.Total.ToString("C")}"
                    });

                    context.SaveChanges();
                    return factura.Id;
                }
                
            }
        }

        public int ObtenerSiguienteNumeroFactura()
        {
            using(var context = new DataContext())
            {
                return context.Facturas.Any() ? context.Facturas.Max(x => x.Numero) + 1 : 1000;
            }
        }

        public IEnumerable<FacturaDto> ObtenerPendientes()
        {
            using(var context = new DataContext())
            {
                var facturas = context.Facturas.Where(x => !x.EstaEliminado && x.EstadoComprobante == Presentacion.Base.Clases.EstadoComprobante.Pendiente)
                    .Select(x => new FacturaDto
                    {
                        EstaEliminado = x.EstaEliminado,
                        ClienteFacturaId = x.ClienteId,
                        ApellidoCliente = x.Cliente.Apellido,
                        Descuento = x.Descuento,
                        DniCliente = x.Cliente.Dni,
                        EmpleadoId = x.EmpleadoId,
                        EstadoComprobante = x.EstadoComprobante,
                        Fecha = x.Fecha,
                        Id = x.Id,
                        Iva105 = x.Iva105,
                        Iva21 = x.Iva21,
                        NombreCliente = x.Cliente.Nombre,
                        Numero = x.Numero,
                        SubTotal = x.SubTotal,
                        TipoComprobante = x.TipoComprobante,
                        Total = x.Total,
                        UsuarioId = x.UsuarioId,
                        Items = x.Items.Select(c => new ItemDto
                        {
                            //EstaEliminado = c.EstaEliminado,//me falto agregar el esta en entidad item
                            Descripcion = c.Descripcion,
                            ArticuloId = c.ArticuloId,
                            Cantidad = c.Cantidad,
                            Codigo = c.Codigo,
                            //ComprobanteId = c.ComprobanteId,
                            FacturaId = c.FacturaId,
                            Iva = c.Iva,
                            Precio = c.Precio,
                            SubTotal = c.SubTotal
                            // Id = c.Id
                        }).ToList()

                    }).OrderBy(x=> x.Fecha).ToList();
                return facturas;
            }
        }

    }
}
