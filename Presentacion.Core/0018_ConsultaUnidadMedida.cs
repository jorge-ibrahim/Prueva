using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.UnidadMedida;
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
    public partial class _0018_ConsultaUnidadMedida : FormularioConsulta
    {
        private UnidadMedidaLogica _unidadMedidaLogica;
        public _0018_ConsultaUnidadMedida()
        {
            InitializeComponent();
            _unidadMedidaLogica = new UnidadMedidaLogica();
        }
        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _unidadMedidaLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public override void ComandoAgregar()
        {
            var formulario = new _0019_AbmUnidadMedida(TipoOperacion.Insert);
            formulario.ShowDialog();
            if(formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoBuscar()
        {
            ActualizarDatos(string.Empty);
        }
        public override void ComandoEliminar()
        {
            var formulario = new _0019_AbmUnidadMedida(TipoOperacion.Delete,EntidadId);
            formulario.ShowDialog();
            if (formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoImprimir()
        {
            base.ComandoImprimir();
        }
        public override void ComandoModificar()
        {
            var formulario = new _0019_AbmUnidadMedida(TipoOperacion.UpDate,EntidadId);
            formulario.ShowDialog();
            if (formulario.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
    }
}
