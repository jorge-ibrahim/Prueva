using Presentacion.Base.Clases;
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
    public partial class Login : Form
    {
        private UsuarioLogica _usuarioLogica;//En lab 2 hace referencia a SeguridadServicio
        public bool PuedeAcceder;
        private int IntentosFallidos;
        public Login()
        {
            InitializeComponent();
            _usuarioLogica = new UsuarioLogica();
            PuedeAcceder = false;
            IntentosFallidos = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if(VerificarDatos(txtNombreUsuario.Text, txtPassword.Text))
                {
                    if (Administrador.UsuarioAdministrador == txtNombreUsuario.Text && Administrador.PasswordAdministrador == txtPassword.Text)
                    {
                        Identidad.UsuarioLogueado = txtNombreUsuario.Text;
                        Identidad.ApellidoEmpleado = string.Empty;
                        Identidad.NombreEmpleado = txtNombreUsuario.Text;
                        Identidad.EmpleadoId = 0;
                        Identidad.UsuarioLogueadoId = 0;
                        this.Close();
                        PuedeAcceder = true;
                    }
                    else
                    {
                        if (_usuarioLogica.VerificarSiExiste(txtNombreUsuario.Text, txtPassword.Text))
                        {
                            if (!_usuarioLogica.VerificarBloqueado(txtNombreUsuario.Text))
                            {
                                var usuario = _usuarioLogica.ObtenerPorNombre(txtNombreUsuario.Text);

                                Identidad.UsuarioLogueado = txtNombreUsuario.Text;
                                Identidad.ApellidoEmpleado = usuario.Apellido;
                                Identidad.NombreEmpleado = usuario.Nombre;
                                Identidad.EmpleadoId = usuario.EmpleadoId;
                                Identidad.UsuarioLogueadoId = usuario.UsuarioId.Value;
                                this.Close();
                                PuedeAcceder = true;
                            }
                            else
                            {
                                MessageBox.Show("El Usuario esta Bloqueado, por favor comuniquese con el Administrador");
                                txtNombreUsuario.Clear();
                                txtPassword.Clear();
                                txtNombreUsuario.Focus();
                            }
                        }
                        else
                        {                            
                            MessageBox.Show("El Usuario o Contraseña no son correctos.");                           
                            IntentosFallidos++;
                            txtPassword.Clear();
                            txtPassword.Focus();
                            if (IntentosFallidos == Administrador.IntentosFallidos)
                            {
                                _usuarioLogica.CambiarEstado(txtNombreUsuario.Text, true);
                                MessageBox.Show("Por seguridad el Usuario fue Bloqueado.");
                                Close();
                            }
                        }
                    }                    
                }
                else
                {

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK);
                this.txtPassword.Clear();
                this.txtPassword.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del Sistema",
                    "Atención",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                PuedeAcceder = false;
                Application.Exit();
            }
        }

        private bool VerificarDatos(string usuario, string password)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show($"Por favor ingresa el Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show($"Por favor ingresa la contraseña");
                return false;
            }

            return true;
        }

        private void imgOjo_Click(object sender, EventArgs e)
        {
           // txtPassword.PasswordChar = string.Empty;
        }
    }
}
