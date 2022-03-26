using Presentacion.Base.Clases;
using Servicios.Articulo;
using Servicios.Caja;
using Servicios.Factura;
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
    public partial class _0035_FormaDePago : Form
    {
        private ArticuloLogica _articuloLogica;
        private FacturaDto _factura;
        private CajaLogica _cajaLogica;
        private FacturaServicio _facturaLogica;
        public bool RealizoPago;
        public _0035_FormaDePago(FacturaDto facturaDto)
        {
            InitializeComponent();
            _factura = facturaDto;
            _cajaLogica = new CajaLogica();
            _facturaLogica = new FacturaServicio();
            _articuloLogica = new ArticuloLogica();
            RealizoPago = false;
            Inicializar();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (nudTotal.Value == 0 || nudTotal.Value > _factura.Total)
            {
                MessageBox.Show("Por favor ingrese un monto válido para Abonar");
                return;
            }
            long _cajaId = _cajaLogica.ObtenerUltimaCajaSinCerrar();

            if(_cajaId != 0)
            {
                _factura.CajaId = _cajaId;

                if (nudTotalEfectivo.Value > 0)
                {
                    try
                    {
                        _factura.MontoPagado = nudTotalEfectivo.Value;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error {ex.Message}");
                    }                   
                    _facturaLogica.Grabar(_factura);
                    DescontarStock();
                    MessageBox.Show("Factura Pagada Correctamente");
                    RealizoPago = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Es necesario Abrir una caja para efectuar el pago");
            }
            
        }

        private void Inicializar()
        {
            txtTotalAbonar.Text = _factura.Total.ToString("C");
            nudMontoEfectivo.Value = _factura.Total;
        }

        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Actualizar()
        {
    
            nudTotal.Value = nudTotalEfectivo.Value + nudTotalTarjeta.Value + nudTotalCheque.Value + nudTotalCtaCte.Value;
        }

        private void nudTotalEfectivo_ValueChanged(object sender, EventArgs e)
        {
            nudTotalEfectivo.Value = nudMontoEfectivo.Value;
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudMontoEfectivo_ValueChanged(object sender, EventArgs e)
        {
            nudTotalEfectivo.Value = nudMontoEfectivo.Value;
            Actualizar();
        }
        private void DescontarStock()
        {
            var productos = _factura.Items.ToList();
            foreach(var x in productos)
            {
                var articulo = _articuloLogica.ObtenerPorId(x.ArticuloId);
                articulo.Stock -= x.Cantidad;
                _articuloLogica.Modificar(articulo);
            }
        }
    }
}
