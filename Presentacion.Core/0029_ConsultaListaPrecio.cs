using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.ListaPrecio;
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
    public partial class _0029_ConsultaListaPrecio : FormularioConsulta
    {
        private ListaPrecioLogica _listaPrecio;
        public _0029_ConsultaListaPrecio()
        {
            InitializeComponent();
            _listaPrecio = new ListaPrecioLogica();
        }

        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _listaPrecio.Obtener(cadenabuscar);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["PorcentajeGanancia"].Visible = true;
            dgvGrilla.Columns["PorcentajeGanancia"].HeaderText = "% DE GANANCIA";
            dgvGrilla.Columns["PorcentajeGanancia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public override void ComandoAgregar()
        {
            var formulario = new _0030_AbmListaPrecio(TipoOperacion.Insert);
            formulario.ShowDialog();
            if(formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
            var formulario = new _0030_AbmListaPrecio(TipoOperacion.UpDate,EntidadId);
            formulario.ShowDialog();
            if (formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var formulario = new _0030_AbmListaPrecio(TipoOperacion.Delete, EntidadId);
            formulario.ShowDialog();
            if (formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoBuscar()
        {
            ActualizarDatos(string.Empty);
        }
        public override void ComandoImprimir()
        {
            base.ComandoImprimir();
        }
    }
}
