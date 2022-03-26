using Presentacion.Base;
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
    public partial class _0032_LoockUpEmpleado : FormularioLoockUp
    {
        private readonly EmpleadoLogica _empleadoLogica;
        public _0032_LoockUpEmpleado()
        {
            InitializeComponent();
            _empleadoLogica = new EmpleadoLogica();
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Legajo"].Visible = true;

            dgv.Columns["ApyNom"].Visible = true;
            dgv.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].HeaderText = "DNI";

        }
        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = (List<EmpleadoDto>)_empleadoLogica.Obtener(cadenabuscar).Where(x => !x.EstaEliminado).ToList();
      
            base.ActualizarDatos(cadenabuscar);
        }
    }
}
