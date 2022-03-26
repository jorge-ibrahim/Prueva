using Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Caja
{
    public class CajaLogica
    {
        public long AbrirCaja(CajaDto caja)
        {
            using(var context = new DataContext())
            {
                var c = new Entidades.Caja
                {
                    UsuarioAperturaId = caja.UsuarioAperturaId,
                    AEmpleadoApertura = caja.ApellidoEmpleadoApertura,
                    NEmpleadoApertura = caja.NombreEmpleadoApertura,
                    MontoInicial = caja.MontoInicial,
                    AEmpleadoCierre = caja.ApellidoEmpleadoCierre,
                    NEmpleadoCierre = caja.NombreEmpleadoCierre,
                    FechaApertura = caja.FechaApertura,
                    EstaEliminado = false,
                    EstadoCaja = true,//abierta  //false cerrada
                    TotalCheque = 0m,
                    TotalCuentaCorriente = 0m,
                    TotalEfectivo = 0m,
                    TotalTarjeta = 0m,
                    TotalVentaEfectivo = 0m                    
                };
                context.Cajas.Add(c);
                context.SaveChanges();
                return c.Id;
            }
        }

        public void CerrarCaja(CajaDto entidad)
        {
            using(var context = new DataContext())
            {
                var caja = context.Cajas.FirstOrDefault(x => x.Id == entidad.Id);
                caja.Id = entidad.Id;
                caja.UsuarioAperturaId = entidad.UsuarioAperturaId;
                caja.UsuarioCierreId = entidad.UsuarioCierreId;
                caja.NEmpleadoCierre = entidad.NombreEmpleadoCierre;
                caja.AEmpleadoCierre = entidad.ApellidoEmpleadoCierre;
                caja.FechaApertura = entidad.FechaApertura;
                caja.FechaCierre = DateTime.Now;
                caja.TotalCheque = entidad.TotalCheque;
                caja.TotalCuentaCorriente = entidad.TotalCuentaCorriente;
                caja.TotalEfectivo = entidad.TotalEfectivo;
                caja.TotalEgresos = entidad.TotalEgresos;
                caja.MontoCierre = entidad.MontoCierre;
                caja.EstadoCaja = false;//Cerrada

                context.SaveChanges();
            }
        }
        public long ObtenerUltimaCajaSinCerrar()
        {
            using(var context = new DataContext())
            {
                var caja = context.Cajas.Where(x => x.EstaEliminado == false);
                if(caja != null)
                {
                    var ultima =  context.Cajas.FirstOrDefault(x => x.FechaCierre == null);
                    return ultima != null ? ultima.Id : 0;
                }
                else
                {
                    return 0;
                }
            }
        }

        public CajaDto ObtenerPorId(long id)
        {
            using(var context = new DataContext())
            {
                var caja = context.Cajas.Where(x => x.EstaEliminado == false).Select(x => new CajaDto
                {
                    Id = x.Id,
                    UsuarioAperturaId = x.UsuarioAperturaId,
                    MontoInicial = x.MontoInicial,
                    FechaApertura = x.FechaApertura,
                    FechaCierre = x.FechaCierre,
                    UsuarioCierreId = x.UsuarioCierreId,
                    MontoCierre = x.MontoCierre,
                    TotalEfectivo = x.TotalEfectivo,
                    TotalCheque = x.TotalCheque,
                    TotalCuentaCorriente = x.TotalCuentaCorriente,
                    TotalTarjeta = x.TotalTarjeta,
                    TotalEgresos = x.TotalEgresos
                    
                   
                }).FirstOrDefault(x => x.Id == id);

                return caja;
            }
        }

        public IEnumerable<CajaDto> ObtenerCajas()
        {
            using (var context = new DataContext())
            {
                var cajas = context.Cajas.Where(x => x.EstaEliminado == false).Select(x => new CajaDto
                {
                    Id = x.Id,
                    UsuarioAperturaId = x.UsuarioAperturaId,
                    NombreEmpleadoApertura = x.NEmpleadoApertura,
                    ApellidoEmpleadoApertura = x.AEmpleadoApertura,
                    NombreEmpleadoCierre = x.NEmpleadoCierre,
                    ApellidoEmpleadoCierre = x.AEmpleadoCierre,
                    MontoInicial = x.MontoInicial,
                    FechaApertura = x.FechaApertura,
                    FechaCierre = x.FechaCierre,
                    UsuarioCierreId = x.UsuarioCierreId,
                    MontoCierre = x.MontoCierre,
                    TotalEfectivo = x.TotalEfectivo,
                    TotalCheque = x.TotalCheque,
                    TotalCuentaCorriente = x.TotalCuentaCorriente,
                    TotalTarjeta = x.TotalTarjeta,
                    TotalEgresos = x.TotalEgresos,
                    EstadoCaja = x.EstadoCaja


                }).ToList();
                return cajas;
            }
        }

        public IEnumerable<MovimientoDto> ObtenerMovimientos(long id)
        {
            using(var context = new DataContext())
            {
                var movimientos = context.Movimientos.Where(x => x.CajaId == id).Select(x => new MovimientoDto
                {
                    Id = x.Id,
                    CajaId = x.CajaId,
                    FacturaId = x.FacturaId,
                    UsuarioId = x.UsuarioId,
                    Descripcion = x.Descripcion,
                    Fecha = x.Fecha,
                    Monto = x.Monto,
                    TipoMovimiento = x.TipoMovimiento,
                    EstaEliminado = x.EstaEliminado
                }).ToList();
                return movimientos;
                
            }
        }
    }
}
