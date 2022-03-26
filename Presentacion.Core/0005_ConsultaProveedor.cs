using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Proveedor;
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
    public partial class _0005_ConsultaProveedor : FormularioConsulta
    {
        private ProveedorLogica _proveedorLogica;
        public _0005_ConsultaProveedor()
        {
            InitializeComponent();
            _proveedorLogica = new ProveedorLogica();
        }

        public override void ComandoAgregar()
        {
            var nuevo = new _0006_AbmProveedor(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if(nuevo.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
            var modificar = new _0006_AbmProveedor(TipoOperacion.UpDate,EntidadId);
            modificar.ShowDialog();
            if (modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var eliminar = new _0006_AbmProveedor(TipoOperacion.Delete, EntidadId);
            eliminar.ShowDialog();
            if (eliminar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoImprimir()
        {
            base.ComandoImprimir();
        }
        public override void ComandoBuscar()
        {
            ActualizarDatos(txtBuscar.Text);
        }
        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _proveedorLogica.Obtener(cadenabuscar);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["RazonSocial"].Visible = true;
            dgvGrilla.Columns["RazonSocial"].HeaderText = "Razon Social";
            dgvGrilla.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Direccion"].Visible = true;
            dgvGrilla.Columns["Direccion"].HeaderText = "Direccion";
            dgvGrilla.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Telefono"].Visible = true;
            dgvGrilla.Columns["Telefono"].HeaderText = "Telefono";
            dgvGrilla.Columns["Telefono"].Width = 100;

            dgvGrilla.Columns["Celular"].Visible = true;
            dgvGrilla.Columns["Celular"].HeaderText = "Celular";
            dgvGrilla.Columns["Celular"].Width = 100;

            dgvGrilla.Columns["Email"].Visible = true;
            dgvGrilla.Columns["Email"].HeaderText = "Email";
            dgvGrilla.Columns["Email"].Width = 250;

        }
    }
}
