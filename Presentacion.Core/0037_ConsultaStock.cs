using Servicios.Articulo;
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
    public partial class _0036_ConsultaStock : Form
    {
        private ArticuloLogica _articulos;
        private object _entidad;
        public _0036_ConsultaStock()
        {
            InitializeComponent();
            _articulos = new ArticuloLogica();
            _entidad = null;
        }
        //BOTONES
        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var a = (ArticuloDto)_entidad;
            a.Stock = Convert.ToDecimal(txtNuevoStock.Text);
            _articulos.ModificarStock(a);
            ActualizarDatos();
            LimpiarStock();
            
        }

        private void LimpiarStock()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtStockActual.Clear();
            txtNuevoStock.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _articulos.Obtener(txtBuscar.Text);
        }

        //METODOS
        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = _articulos.ObtenerStock(string.Empty);
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            for(int i =0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
                dgvGrilla.Columns[i].DataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].HeaderText = "CODIGO";
            dgvGrilla.Columns["Codigo"].Width = 80;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Detalle"].Visible = true;
            dgvGrilla.Columns["Detalle"].HeaderText = "DETALLE";
            dgvGrilla.Columns["Detalle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Stock"].Visible = true;
            dgvGrilla.Columns["Stock"].HeaderText = "STOCK";
            dgvGrilla.Columns["Stock"].Width = 100;

        }
            


        //EVENTOS
        private void _0036_ConsultaStock_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                _entidad = dgvGrilla.Rows[e.RowIndex].DataBoundItem;  //rowindex devuelve el indice de la fila seleccionada, con el DataBoundItem obtengo el objeto de la fila completa
            }
            else
            {
                _entidad = null;
            }

            Seleccionador();       
        }
        private void Seleccionador()
        {
            var articulo = (ArticuloDto)_entidad;
            txtCodigo.Text = articulo.Codigo.ToString();
            txtDescripcion.Text = articulo.Descripcion;
            txtStockActual.Text = articulo.Stock.ToString();
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtStockActual.Enabled = false;
        }
    }
}
