using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Localidad;
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
    public partial class _0011_ConsultaLocalidad : FormularioConsulta
    {
        private LocalidadLogica _localidadLogica;
        public _0011_ConsultaLocalidad()
        {
            InitializeComponent();
            _localidadLogica = new LocalidadLogica();
        }

        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _localidadLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void ComandoAgregar()
        {
            var nuevo = new _0012_AbmLocalidad(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if(nuevo.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
            var modificar = new _0012_AbmLocalidad(TipoOperacion.UpDate, EntidadId);
            modificar.ShowDialog();
            if(modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var eliminar = new _0012_AbmLocalidad(TipoOperacion.Delete, EntidadId);
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
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "NOMBRE LOCALIDAD";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Provincia"].Visible = true;
            dgvGrilla.Columns["Provincia"].HeaderText = "PROVINCIA";
            dgvGrilla.Columns["Provincia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
