using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Rubro;
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
    public partial class _0014_ConsultaRubro : FormularioConsulta
    {
        private RubroLogica _rubroLogica;
        public _0014_ConsultaRubro()
        {
            InitializeComponent();
            _rubroLogica = new RubroLogica();
        }

        public override void ActualizarDatos( string cadenabuscar)
        {
            dgvGrilla.DataSource = _rubroLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void ComandoAgregar()
        {
            var nuevo = new _0015_AbmRubro(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if(nuevo.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var eliminar = new _0015_AbmRubro(TipoOperacion.Delete, EntidadId);
            eliminar.ShowDialog();
            if(eliminar.RealizoAlgunaOperacion)
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
            var modificar = new _0015_AbmRubro(TipoOperacion.UpDate, EntidadId);
            modificar.ShowDialog();
            if(modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Descripcion";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
