using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Provincia;
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
    public partial class _0009_ConsultaProvincia : FormularioConsulta
    {
        private ProvinciaLogica _provinciaLogica;
        public _0009_ConsultaProvincia()
        {
            InitializeComponent();
            _provinciaLogica = new ProvinciaLogica();
        }
        
        public override void ComandoAgregar()
        {
            base.ComandoAgregar();
            var agregar = new _0010_AbmProvincia(TipoOperacion.Insert);
            agregar.ShowDialog();
            if (agregar.RealizoAlgunaOperacion)
            {
                ActualizarDatos( string.Empty);
            }
        }
        public override void ComandoEliminar()
        {
            base.ComandoEliminar();
            var eliminar = new _0010_AbmProvincia(TipoOperacion.Delete, EntidadId);
            eliminar.ShowDialog();
            if (eliminar.RealizoAlgunaOperacion)
            {
                ActualizarDatos( string.Empty);
            }
        }
        public override void ComandoImprimir()
        {
            base.ComandoImprimir();
        }
        public override void ComandoModificar()
        {
            base.ComandoModificar();
            var modificar = new _0010_AbmProvincia(TipoOperacion.UpDate, EntidadId);
            modificar.ShowDialog();
            if(modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoBuscar()
        {
            ActualizarDatos( txtBuscar.Text);
        }
        public override void ActualizarDatos( string cadenabuscar)
        {
            dgvGrilla.DataSource = _provinciaLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
        public override void FormatearGrilla(DataGridView grilla)
        {
            base.FormatearGrilla(grilla);

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].HeaderText = "NOMBRE DE LA PROVINCIA";
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
