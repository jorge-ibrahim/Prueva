using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.CondicionIva;
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
    public partial class _0020_ConsultaCondicionIva : FormularioConsulta
    {
        private CondicionIvaLogica _condicionIvaLogica;
        public _0020_ConsultaCondicionIva()
        {
            InitializeComponent();
            _condicionIvaLogica = new CondicionIvaLogica();
        }
        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _condicionIvaLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);
            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["TipoComprobante"].Visible = true;
            dgvGrilla.Columns["TipoComprobante"].HeaderText = "TIPO DE COMPROBANTE";
            dgvGrilla.Columns["TipoComprobante"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public override void ComandoAgregar()
        {
            var formulario = new _0021_AbmCondicionIva(TipoOperacion.Insert);
            formulario.ShowDialog();
            if(formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
            var formulario = new _0021_AbmCondicionIva(TipoOperacion.UpDate,EntidadId);
            formulario.ShowDialog();
            if (formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var formulario = new _0021_AbmCondicionIva(TipoOperacion.Delete, EntidadId);
            formulario.ShowDialog();
            if (formulario.RealizoAlgunaOperacion)
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

    }
}
