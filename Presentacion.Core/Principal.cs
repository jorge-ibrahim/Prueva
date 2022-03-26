using Presentacion.Base.Clases;
using Presentacion.Core.Clases;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            lblNombreUsuario.Text = Identidad.ApyNomUsuarioLogin;
        }

        private void consultaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cempleado = new _0001_ConsultaEmpleados();
            cempleado.ShowDialog();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Nempleado = new _0002_AbmEmpleados(TipoOperacion.Insert);
            Nempleado.ShowDialog();
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0003_ConsultaClientes();
            consulta.ShowDialog();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevo = new _0004_AbmClientes(TipoOperacion.Insert);
            nuevo.ShowDialog();
        }

        private void consultaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0005_ConsultaProveedor();
            consulta.ShowDialog();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevo = new _0006_AbmProveedor(TipoOperacion.Insert);
            nuevo.ShowDialog();
        }

        private void nuevaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nueva = new _0012_AbmLocalidad(TipoOperacion.Insert);
            nueva.ShowDialog();
        }

        private void consultaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0011_ConsultaLocalidad();
            consulta.ShowDialog();
        }

        private void consultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0013_ConsultaUsuarios();
            consulta.ShowDialog();
        }

        private void consultaRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0014_ConsultaRubro();
            consulta.ShowDialog();
        }

        private void nuevoRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevo = new _0015_AbmRubro(TipoOperacion.Insert);
            nuevo.ShowDialog();
        }

        private void menuParametricas_Click(object sender, EventArgs e)
        {

        }

        private void consultaProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0009_ConsultaProvincia();
            consulta.ShowDialog();
        }

        private void nuevaProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nueva = new _0010_AbmProvincia(TipoOperacion.Insert);
            nueva.ShowDialog();
        }

        private void consultaMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = new _0016_ConsultaMarca();
            consulta.ShowDialog();
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevamarca = new _0017_AbmMarca(TipoOperacion.Insert);
            nuevamarca.ShowDialog();
        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0026_AbriCaja();
            formulario.ShowDialog();
        }

        private void consultaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultaProducto = new _0007_ConsultaArticulos();
            consultaProducto.ShowDialog();
        }

        private void nuevoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevoProducto = new _0008_AbmArticulo(TipoOperacion.Insert);
            nuevoProducto.ShowDialog();
        }

        private void consultaUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0018_ConsultaUnidadMedida();
            formulario.ShowDialog();
        }

        private void nuevaUnidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0019_AbmUnidadMedida(TipoOperacion.Insert);
            formulario.ShowDialog();
        }

        private void consultaIvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0020_ConsultaCondicionIva();
            formulario.ShowDialog();
        }

        private void nuevaCondicionIvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0021_AbmCondicionIva(TipoOperacion.Insert);
            formulario.ShowDialog();
        }

        private void consultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0022_ConsultaVenta();
            formulario.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0023_Venta();
            formulario.Show();//solo show para poder abrir muchos formularios de ventas
        }

        private void consultaComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0024_ConsultaCompra();
            formulario.ShowDialog();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0025_Compra();
            formulario.ShowDialog();
        }       

        private void consultaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0028_ConsultaCaja();
            formulario.ShowDialog();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblNombreUsuario.Text = string.Empty;
            var formulario = new Login();
            formulario.ShowDialog();
            if (formulario.PuedeAcceder)
            {
                lblNombreUsuario.Text = Identidad.ApyNomUsuarioLogin;
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del Sistema",
                    "Atención",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                Application.Exit();
            }
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {

        }

        private void consultaListaPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0029_ConsultaListaPrecio();
            formulario.ShowDialog();
        }

        private void nuevaListaDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0030_AbmListaPrecio(TipoOperacion.Insert);
            formulario.ShowDialog();
        }

        private void consultaStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0036_ConsultaStock();
            formulario.ShowDialog();
        }

        private void consultaIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0039_ConsultaIngresos();
            formulario.ShowDialog();
        }

        private void consultaEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0038_ConsultaEgresos();
            formulario.ShowDialog();
        }

        private void pendientesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _0034_PendientesDePagos();
            formulario.ShowDialog();
        }
    }
}
