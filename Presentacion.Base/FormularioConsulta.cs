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
    public partial class FormularioConsulta : FormularioBase
    {

        protected long? EntidadId;
        protected bool PuedeEjecutarComando;
        protected object EntidadSeleccionada;
        public FormularioConsulta()
        {
            InitializeComponent();
            EntidadId = null;
            PuedeEjecutarComando = false;
        }

        //BOTONES//
        public void btnNuevo_Click(object sender, EventArgs e)
        {
            ComandoAgregar();
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            if(VerificarRegistros())
            {
                if(VerificarEntidadSeleccionada())
                {
                    ComandoModificar();
                }
                else
                {
                    MessageBox.Show("No se selecciono Ningun Elemento");
                }
            }
            else
            {
                MessageBox.Show("No hay Elementos Cargados en la Grilla.");
            }

        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            if (VerificarRegistros())
            {
                if (VerificarEntidadSeleccionada())
                {
                    ComandoEliminar();
                }
                else
                {
                    MessageBox.Show("No se selecciono Ningun Elemento");
                }
            }
            else
            {
                MessageBox.Show("No hay Elementos Cargados en la Grilla.");
            }
        }

        public void btnImprimir_Click(object sender, EventArgs e)
        {
            if (VerificarRegistros())
            {
                ComandoImprimir();
            }
            else
            {
                MessageBox.Show("No hay Elementos Cargados en la Grilla.");
            }
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            ComandoBuscar();
        }

        //METODOS//
        public virtual void ComandoBuscar()
        {

        }
        public virtual void ComandoAgregar()
        {

        }

        public virtual void ComandoModificar()
        {

        }

        public virtual void ComandoEliminar()
        {

        }

        public virtual void ComandoImprimir()
        {

        }

        public override void ActualizarDatos(string cadenabuscar)
        {
            
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);
            /*
             * cellborderstyle = singlehorizontal => sin lineas divisorias la cabecera
             * collumheaderdefaulcellstyle = ahi toco el formato de la cabecera
             * gridcolor = orange // lineas
             Rowhederborderstyle = None
            rowdefaultcellstyle = personalizo las celdas de la grilla
             */
        }

        public virtual bool VerificarEntidadSeleccionada()//Metodo para verificar si se seleccono una entidad
        {
            return EntidadId.HasValue;
        }

        public virtual bool VerificarRegistros()
        {
            return dgvGrilla.RowCount > 0;
        }//Metodo para verifciar si hay datos en la grilla.

        //EVENTOS//
        private void FormularioConsulta_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
            FormatearGrilla(dgvGrilla);
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                EntidadId = (int)(long?)dgvGrilla["Id", e.RowIndex].Value;
                EntidadSeleccionada = dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                EntidadId = null;
                EntidadSeleccionada = null;
            }

        }
    }
}
