using Servicios.Usuario;
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
    public partial class _0013_ConsultaUsuarios : Form
    {
        private UsuarioLogica _usuarioLogica;
        private object EntidadId;
        public _0013_ConsultaUsuarios()
            :this(new UsuarioLogica())//con este llamo al contructor de abajo
        {
            InitializeComponent();
            
        }

        public _0013_ConsultaUsuarios(UsuarioLogica usuarioLogica)
        {
            _usuarioLogica = usuarioLogica;
        }

        private void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = _usuarioLogica.Obtener(cadenabuscar);
            FormatearGrilla(dgvGrilla);
        }

        private void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgvGrilla.Columns["Item"].Visible = true;
            dgvGrilla.Columns["Item"].HeaderText = string.Empty;
            dgvGrilla.Columns["Item"].Width = 40;

            dgvGrilla.Columns["ApyNomEmpleado"].Visible = true;
            dgvGrilla.Columns["ApyNomEmpleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["ApyNomEmpleado"].HeaderText = @"Apellido y Nombre";
            dgvGrilla.Columns["ApyNomEmpleado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["NombreUsuario"].Visible = true;
            dgvGrilla.Columns["NombreUsuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["NombreUsuario"].HeaderText = @"Usuario";
            //dgvGrilla.Columns["NombreUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["BloqueadoStr"].Visible = true;
            dgvGrilla.Columns["BloqueadoStr"].Width = 100;
            dgvGrilla.Columns["BloqueadoStr"].HeaderText = @"Bloqueado";
            dgvGrilla.Columns["BloqueadoStr"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["BloqueadoStr"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

        }

        private void _0013_ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)//cada ves que escribo en el buscador y presiono enter trae lo que encuentre
        {
            if((char)Keys.Enter == e.KeyChar)
            {
                btnBuscar.PerformClick();
            }

            if(((TextBox)sender).TextLength >= 3)//aca le digo que si ya agrego  3 letras o mas ya busque automaticamente
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGrilla.DataSource != null)
                {
                    var usuarios = (List<UsuarioDto>)dgvGrilla.DataSource;

                    if (usuarios.Any(x => x.Item))
                    {
                        _usuarioLogica.Crear(usuarios.Where(x => x.Item && x.NombreUsuario == "NO ASIGNADO").ToList());

                        ActualizarDatos(string.Empty);
                        MessageBox.Show("Se Creo el Usuario");
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Empleado");
                    }
                }
                else
                {
                    MessageBox.Show("No hay Empleados para crear Usuarios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK);
            }
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).RowCount <= 0) return;

            if (e.RowIndex >= 0)
            {
                ((DataGridView)sender).EndEdit();
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (EntidadId == null || ((UsuarioDto)EntidadId).NombreUsuario == "NO ASIGNADO") return;

            var usuarioSeleccionado = (UsuarioDto)EntidadId;

            _usuarioLogica.CambiarEstado(usuarioSeleccionado.NombreUsuario, !usuarioSeleccionado.Bloqueado);

            var mensaje = usuarioSeleccionado.Bloqueado
                ? "Usuario Desbloqueado Correctamente"
                : "Usuario Bloqueado Correctamente";


            MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarDatos(string.Empty);
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGrilla.RowCount > 0)
            {
                EntidadId = dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                EntidadId = null;
            }
        }
    }
}
