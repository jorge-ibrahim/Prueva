using Presentacion.Base.Clases;
using Servicios.Caja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Core
{
    public partial class _0027_CerrarCaja : Form
    {
        private CajaLogica _cajaLogica;
        private CajaDto _caja;
        public _0027_CerrarCaja(CajaDto entidad)
        {
            InitializeComponent();
            _cajaLogica = new CajaLogica();
            _caja = entidad;
            CargarDatos();
        }

        private void CargarDatos()
        {
            decimal _totalIngresos = 0m;
            decimal _totalEgresos = 0m;

            if(_caja.Id == 0)
            {
                MessageBox.Show("No se encontro ninguna caja abierta.");
                this.Close();
            }
            else
            {
                var _movimientos = _cajaLogica.ObtenerMovimientos(_caja.Id);//traigo todos los movimientos de la caja abierta

                foreach (var movimiento in _movimientos)//realizo el conteo de ingresos y egresos
                {
                    if (movimiento.TipoMovimiento == Base.Clases.TipoMovimiento.Egreso)
                    {
                        _totalEgresos += movimiento.Monto;
                    }
                    if (movimiento.TipoMovimiento == Base.Clases.TipoMovimiento.Ingreso)
                    {
                        _totalIngresos += movimiento.Monto;
                    }

                }

                //Cargo datos del formulario
                //  lblFechaApertura.Text = $"Fecha Apertura {caja.FechaApertura.ToShortDateString()}";
                txtTotalEgresos.Text = _totalEgresos.ToString();
                txtTotalIngresos.Text = _totalIngresos.ToString();
                txtMontoInicial.Text = _caja.MontoInicial.ToString();
                txtMontoActual.Text = (_totalIngresos - _totalEgresos).ToString();

                //bloqueo elementos
                txtMontoInicial.Enabled = false;
                txtTotalEgresos.Enabled = false;
                txtTotalIngresos.Enabled = false;
                txtMontoActual.Enabled = false;

                //Cargo datos de la caja
                _caja.MontoCierre = _totalIngresos - _totalEgresos;

            }            
        }

        private void iconToolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            _caja.UsuarioCierreId = Identidad.UsuarioLogueadoId;
            _caja.ApellidoEmpleadoCierre = Identidad.ApellidoEmpleado;
            _caja.NombreEmpleadoCierre = Identidad.NombreEmpleado;
            _caja.FechaCierre = DateTime.Now;
            _cajaLogica.CerrarCaja(_caja);            
            MessageBox.Show("La Caja se Cerro Correctamente");
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
