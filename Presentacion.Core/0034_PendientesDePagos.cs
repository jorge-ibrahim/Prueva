using Presentacion.Base;
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
    public partial class _0034_PendientesDePagos : FormularioBase
    {
        private FacturaServicio _facturaLogica;
        private FacturaDto  _factura;
        public _0034_PendientesDePagos()
        {
            InitializeComponent();
            _facturaLogica = new FacturaServicio();
            _factura = new FacturaDto();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var pagar = new _0035_FormaDePago(_factura);
            pagar.ShowDialog();
            if(pagar.RealizoPago)
            {
                ActualizarDatos();
            }
        }

        public void ActualizarDatos()
        {
            dgvPendiente.DataSource = _facturaLogica.ObtenerPendientes();
            FormatearGrilla(dgvPendiente);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            this.dgvPendiente.Columns["Numero"].Visible = true;//elementos del itemview
            this.dgvPendiente.Columns["Numero"].HeaderText = "CODIGO";
            this.dgvPendiente.Columns["Numero"].Width = 100;

            this.dgvPendiente.Columns["ApyNomCliente"].Visible = true;
            this.dgvPendiente.Columns["ApyNomCliente"].HeaderText = "CLIENTE";
            this.dgvPendiente.Columns["ApyNomCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //this.dgvPendiente.Columns["DireccionCliente"].Visible = true;
            //this.dgvPendiente.Columns["DireccionCliente"].HeaderText = "DIRECCION";
            //this.dgvPendiente.Columns["DireccionCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dgvPendiente.Columns["Total"].Visible = true;//elementos del itemview
            this.dgvPendiente.Columns["Total"].HeaderText = "TOTAL";
            this.dgvPendiente.Columns["Total"].Width = 100;

            //dgvGrilla.Columns["CodigoBarraArticulo"].Visible = true;
            //dgvGrilla.Columns["CodigoBarraArticulo"].HeaderText = "CODIGO DE BARRAS";
            //dgvGrilla.Columns["CodigoBarraArticulo"].Width = 100;

            //dgvGrilla.Columns["DescripcionArticulo"].Visible = true;
            //dgvGrilla.Columns["DescripcionArticulo"].HeaderText = "DESCRIPCION PRODUCTO";
            //dgvGrilla.Columns["DescripcionArticulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvGrilla.Columns["Stock"].Visible = true;
            //dgvGrilla.Columns["Stock"].HeaderText = "STOCK DISPONIBLE";
            //dgvGrilla.Columns["Stock"].Width = 100;

            //dgvGrilla.Columns["Cantidad"].Visible = true;
            //dgvGrilla.Columns["Cantidad"].HeaderText = "CANTIDAD";
            //dgvGrilla.Columns["Cantidad"].Width = 100;

            //dgvGrilla.Columns["PrecioProductoStr"].Visible = true;
            //dgvGrilla.Columns["PrecioProductoStr"].HeaderText = "PRECIO";
            //dgvGrilla.Columns["PrecioProductoStr"].Width = 100;

            //dgvGrilla.Columns["SubtotalStr"].Visible = true;
            //dgvGrilla.Columns["SubtotalStr"].HeaderText = "SUB-TOTAL";
            //dgvGrilla.Columns["SubtotalStr"].Width = 100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void _0034_PendientesDePagos_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void dgvPendiente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPendiente.RowCount > 0)
            {
                _factura = (FacturaDto)dgvPendiente.Rows[e.RowIndex].DataBoundItem;

                if (_factura.Items != null)
                {
                    dgvGrillaDetalles.DataSource = _factura.Items;
                    FormatearGrillaDetalle();
                    nudTotal.Value = _factura.Total;
                }
            }
        }

        private void FormatearGrillaDetalle()
        {
            for (int i = 0; i < dgvGrillaDetalles.ColumnCount; i++)
            {
                dgvGrillaDetalles.Columns[i].Visible = false;
            }

            dgvGrillaDetalles.Columns["Codigo"].Visible = true;
            dgvGrillaDetalles.Columns["Codigo"].HeaderText = "CODIGO";
            dgvGrillaDetalles.Columns["Codigo"].Width = 50;

            dgvGrillaDetalles.Columns["Descripcion"].Visible = true;
            dgvGrillaDetalles.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaDetalles.Columns["Descripcion"].HeaderText = "DESCRIPCION";

            dgvGrillaDetalles.Columns["Cantidad"].Visible = true;
            dgvGrillaDetalles.Columns["Cantidad"].HeaderText = "CANTIDAD";
            dgvGrillaDetalles.Columns["Cantidad"].Width = 100;

            dgvGrillaDetalles.Columns["Precio"].Visible = true;
            dgvGrillaDetalles.Columns["Precio"].HeaderText = "PRECIO";
            dgvGrillaDetalles.Columns["Precio"].Width = 100;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
    }
}
