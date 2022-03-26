using Presentacion.Base;
using Presentacion.Core.Clases;
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
    public partial class _0007_ConsultaArticulos : FormularioConsulta
    {
        private ArticuloLogica _articuloLogica;
        public _0007_ConsultaArticulos()
        {
            InitializeComponent();
            _articuloLogica = new ArticuloLogica();
        }

        public override void ComandoAgregar()
        {
            var nueva = new _0008_AbmArticulo(TipoOperacion.Insert);
            nueva.ShowDialog();
            if(nueva.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
            var modificar = new _0008_AbmArticulo(TipoOperacion.UpDate, EntidadId);
            modificar.ShowDialog();
            if(modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var eliminar = new _0008_AbmArticulo(TipoOperacion.Delete, EntidadId);
            eliminar.ShowDialog();
            if(eliminar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoBuscar()
        {
            ActualizarDatos(txtBuscar.Text);
        }
        public override void ComandoImprimir()
        {
            base.ComandoImprimir();
        }
        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _articuloLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["codigo"].HeaderText = "CODIGO";
            dgvGrilla.Columns["Codigo"].Width = 100;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Detalle"].Visible = true;
            dgvGrilla.Columns["Detalle"].HeaderText = "DETALLE";
            dgvGrilla.Columns["Detalle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Stock"].Visible = true;
            dgvGrilla.Columns["Stock"].HeaderText = "STOCK";
            dgvGrilla.Columns["Stock"].Width = 80;


        }
    }
}
