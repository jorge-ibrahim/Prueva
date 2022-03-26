using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Marca;
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
    public partial class _0016_ConsultaMarca : FormularioConsulta
    {
        private MarcaLogica _marcaLogica;
        public _0016_ConsultaMarca()
        {
            InitializeComponent();
            _marcaLogica = new MarcaLogica();
        }

        public override void ComandoAgregar()
        {
            var nueva = new _0017_AbmMarca(TipoOperacion.Insert);
            nueva.ShowDialog();
            if(nueva.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
            var modificar = new _0017_AbmMarca(TipoOperacion.UpDate, EntidadId);
            modificar.ShowDialog();
            if(modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            var eliminar = new _0017_AbmMarca(TipoOperacion.Delete, EntidadId);
            eliminar.ShowDialog();
            if(eliminar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _marcaLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "NOMBRE MARCA";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
