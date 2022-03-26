using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Base
{
    public partial class FormularioLoockUp : FormularioBase
    {
        private object _entidad;
        public object EntidadSeleccionada => _entidad;// =>{get;}

        public FormularioLoockUp()
        {
            InitializeComponent();
            _entidad = null;
        }

        //BOTONES

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusqueda.Text))
                ActualizarDatos(txtBusqueda.Text);
        }

        //EVENTOS
        private void dgvGrilla_KeyPress(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //propiedad Selection Mode = FullRowSelect
            _entidad = dgvGrilla.RowCount > 0
                ? _entidad = dgvGrilla.Rows[e.RowIndex].DataBoundItem
                : _entidad = null;
        }
        private void dgvGrilla_DoubleClick(object sender, EventArgs e)
        {
            if (_entidad != null)
                Close();
        }
        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                _entidad = dgvGrilla.Rows[e.RowIndex].DataBoundItem;  //rowindex devuelve el indice de la fila seleccionada, con el DataBoundItem obtengo el objeto de la fila completa
            }
            else
            {
                _entidad = null;
            }
        }
        private void FormularioLoockUp_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        //METODOS

        public virtual void ActualizarDatos(string cadenabuscar)
        {
            FormatearGrilla(this.dgvGrilla);
        }
        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);
        }
               
    }
}
