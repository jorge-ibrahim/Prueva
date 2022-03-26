using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Empleado;
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
    public partial class _0001_ConsultaEmpleados : FormularioConsulta
    {
        public EmpleadoLogica _empleadoLogica;
        public _0001_ConsultaEmpleados()
        {
            InitializeComponent();
            _empleadoLogica = new EmpleadoLogica();
        }

        public override void ComandoAgregar()
        {
            var nuevo = new _0002_AbmEmpleados(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if (nuevo.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoModificar()
        {
                    
            var modificar = new _0002_AbmEmpleados(TipoOperacion.UpDate, EntidadId);
            modificar.ShowDialog();
            if (modificar.RealizoAlgunaOperacion)
            {
                ActualizarDatos( string.Empty);
            }

        }
        public override void ComandoEliminar()
        {
            var eliminar = new _0002_AbmEmpleados(TipoOperacion.Delete, EntidadId);
            eliminar.ShowDialog();
            if(eliminar.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }
        public override void ComandoImprimir()
        {
 
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Legajo"].Visible = true;
            dgv.Columns["Legajo"].HeaderText = "Legajo";
            dgv.Columns["Legajo"].Width = 100;

            dgv.Columns["ApyNom"].Visible = true;
            dgv.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].HeaderText = "Dni";
            dgv.Columns["Dni"].Width = 100;

            dgv.Columns["Celular"].Visible = true;
            dgv.Columns["Celular"].HeaderText = "Celular";
            dgv.Columns["Celular"].Width = 100;

            dgv.Columns["Domicilio"].Visible = true;
            dgv.Columns["Domicilio"].HeaderText = "Domicilio";
            dgv.Columns["Domicilio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _empleadoLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }
       

    }
}
