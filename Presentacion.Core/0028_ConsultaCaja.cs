using Presentacion.Base;
using Presentacion.Base.Clases;
using Servicios.Caja;
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
    public partial class _0028_ConsultaCaja : FormularioBase
    {
        private CajaDto _cajaSeleccionada;
        private CajaLogica _cajaLogica;
        public _0028_ConsultaCaja()
        {
            InitializeComponent();
            _cajaLogica = new CajaLogica();
            ActualizarDatos();
        }


        //METODOS
        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = _cajaLogica.ObtenerCajas();
            FormatearGrilla(dgvGrilla);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["ApyNomEmpleadoApertura"].Visible = true;
            dgv.Columns["ApyNomEmpleadoApertura"].HeaderText = "USUARIO APERTURA";
            dgv.Columns["ApyNomEmpleadoApertura"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["FechaApertura"].Visible = true;
            dgv.Columns["FechaApertura"].HeaderText = "FECHA APERTURA";
            dgv.Columns["FechaApertura"].Width = 150;

            dgv.Columns["MontoInicial"].Visible = true;
            dgv.Columns["MontoInicial"].HeaderText = "MONTO INICIAL";
            dgv.Columns["MontoInicial"].Width = 100;        

            dgv.Columns["ApyNomEmpleadoCierre"].Visible = true;
            dgv.Columns["ApyNomEmpleadoCierre"].HeaderText = "USUARIO CIERRE";
            dgv.Columns["ApyNomEmpleadoCierre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["FechaCierre"].Visible = true;
            dgv.Columns["FechaCierre"].HeaderText = "FECHA CIERRE";
            dgv.Columns["FechaCierre"].Width = 150;

            dgv.Columns["MontoCierre"].Visible = true;
            dgv.Columns["MontoCierre"].HeaderText = "MONTO CIERRE";
            dgv.Columns["MontoCierre"].Width = 100;
            
        }
        public void GrillaMovimientos(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
                // dgv.Columns[i].DefaultCellStyle.BackColor = Color.Yellow;
                dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv.Columns[i].ContextMenuStrip.Co
            }

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].HeaderText = "DETALLE MOVIMIENTO";
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;;

            dgv.Columns["Fecha"].Visible = true;
            dgv.Columns["Fecha"].HeaderText = "FECHA";
            dgv.Columns["Fecha"].Width = 150;

            dgv.Columns["Monto"].Visible = true;
            dgv.Columns["Monto"].HeaderText = "MONTO";
            dgv.Columns["Monto"].Width = 150;

            dgv.Columns["TipoMovimiento"].Visible = true;
            dgv.Columns["TipoMovimiento"].HeaderText = "TIPO MOVIMIENTO";
            dgv.Columns["TipoMovimiento"].Width = 150;
        }


        //EVENTOS
        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGrilla.RowCount > 0)
            {
                _cajaSeleccionada = (CajaDto)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
                if(_cajaSeleccionada != null)
                {
                    dgvMovimientos.DataSource = _cajaLogica.ObtenerMovimientos(_cajaSeleccionada.Id);
                    GrillaMovimientos(dgvMovimientos);
                }
            }
        }


        //BOTONES
        private void iconToolStripButton1_Click(object sender, EventArgs e)//ABRIr
        {
            long cajaViejaId = _cajaLogica.ObtenerUltimaCajaSinCerrar();
            if (cajaViejaId != 0)
            {
                Identidad.CajaId = cajaViejaId;
                MessageBox.Show("Ya existe una caja Abierta");
                return;
            }
            else
            {
                var formulario = new _0026_AbriCaja();
                formulario.ShowDialog();
            }
        }

        private void iconToolStripButton2_Click(object sender, EventArgs e)//CERRAR
        {
            if (_cajaSeleccionada.FechaCierre == null)
            {
                if (_cajaSeleccionada != null)
                {
                    var fCierreCaja = new _0027_CerrarCaja(_cajaSeleccionada);
                    fCierreCaja.Show();
                }
            }
            else
                MessageBox.Show($"La caja fue cerrada el dia {_cajaSeleccionada.FechaCierre.ToString()}", "Atencion", MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
        }

        private void iconToolStripButton3_Click(object sender, EventArgs e)//ACTUALIZAR
        {
            ActualizarDatos();
        }

        private void iconToolStripButton4_Click(object sender, EventArgs e)//SALIr
        {
            this.Close();
        }
    }
}
