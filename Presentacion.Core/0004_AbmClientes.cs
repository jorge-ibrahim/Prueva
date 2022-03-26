using Presentacion.Base.Clases;
using Presentacion.Core.Clases;
using Servicios.Cliente;
using Servicios.CondicionIva;
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
    public partial class _0004_AbmClientes : Form
    {
        private ClienteLogica _clienteLogica;
        private CondicionIvaLogica _condicionIva;
        protected TipoOperacion _tipoOperacion;
        private long? _entidadId;
        public bool RealizoAlgunaOperacion;
        public _0004_AbmClientes()
        {
            InitializeComponent();
        }
        public _0004_AbmClientes(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _clienteLogica = new ClienteLogica();
            _condicionIva = new CondicionIvaLogica();
            CargarDatos(_entidadId);
            RealizoAlgunaOperacion = false;
            Inicializador();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EjecutarComandos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EjecutarComandos()
        {
            switch(_tipoOperacion)
            {
                case TipoOperacion.Insert:
                    ComandoAgregar();
                    break;
                case TipoOperacion.UpDate:
                    ComandoModificar();
                    break;
                case TipoOperacion.Delete:
                    ComandoEliminar();
                    break;
            }
        }

        public void ComandoAgregar()
        {
            var nuevo = new ClienteDto
            {
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                RazonSocial = txtRazonSocial.Text,
                Cuil = txtCuil.Text,
                Dni = txtDni.Text,
                CondicionIvaId = (long)cmbCondicionIva.SelectedValue,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Email = txtEmail.Text
            };

            _clienteLogica.Insertar(nuevo);
            RealizoAlgunaOperacion = true;
            MessageBox.Show("El Cliente fue Agregado Correctamente");
            this.Close();
        }

        public void ComandoModificar()
        {
            var modificar = new ClienteDto
            {
                Id = _entidadId.Value,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                RazonSocial = txtRazonSocial.Text,
                Cuil = txtCuil.Text,
                Dni = txtDni.Text,
                CondicionIvaId = (long)cmbCondicionIva.SelectedValue,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Email = txtEmail.Text
            };

            _clienteLogica.Modificar(modificar);
            RealizoAlgunaOperacion = true;
            MessageBox.Show("El Cliente fue Modificado Correctamente");
            this.Close();
        }

        public void ComandoEliminar()
        {
            var cliente = _clienteLogica.ObtenerPorId(_entidadId);
            _clienteLogica.Eliminar(cliente.Id);
            RealizoAlgunaOperacion = true;
            MessageBox.Show("El Cliente Fue Eliminado");
            this.Close();
        }
        protected void DesactivarControles(object obj)
        {
            if (obj is Form)
            {
                foreach (var controlForm in ((Form)obj).Controls)
                {
                    if (controlForm is TextBox)
                    {
                        ((TextBox)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is ComboBox)
                    {
                        ((ComboBox)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is NumericUpDown)
                    {
                        ((NumericUpDown)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is Button)
                    {
                        ((Button)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is DateTimePicker)
                    {
                        ((DateTimePicker)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is CheckBox)
                    {
                        ((CheckBox)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is Panel)
                    {
                        DesactivarControles(controlForm);
                        continue;
                    }

                    if (controlForm is GroupBox)
                    {
                        DesactivarControles(controlForm);
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ControlPanel in ((Panel)obj).Controls)
                {
                    if (ControlPanel is TextBox)
                    {
                        ((TextBox)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is ComboBox)
                    {
                        ((ComboBox)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is NumericUpDown)
                    {
                        ((NumericUpDown)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is Button)
                    {
                        ((Button)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is DateTimePicker)
                    {
                        ((DateTimePicker)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is CheckBox)
                    {
                        ((CheckBox)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is Panel)
                    {
                        DesactivarControles(ControlPanel);
                        continue;
                    }

                    if (ControlPanel is GroupBox)
                    {
                        DesactivarControles(ControlPanel);
                    }
                }
            }
            else if (obj is GroupBox)
            {
                foreach (var ControlGroupBox in ((GroupBox)obj).Controls)
                {
                    if (ControlGroupBox is TextBox)
                    {
                        ((TextBox)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is ComboBox)
                    {
                        ((ComboBox)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is NumericUpDown)
                    {
                        ((NumericUpDown)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is Button)
                    {
                        ((Button)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is DateTimePicker)
                    {
                        ((DateTimePicker)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is CheckBox)
                    {
                        ((CheckBox)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is Panel)
                    {
                        DesactivarControles(ControlGroupBox);
                        continue;
                    }

                    if (ControlGroupBox is GroupBox)
                    {
                        DesactivarControles(ControlGroupBox);
                    }
                }
            }
        }

        public void CargarDatos(long? entidadId)
        {
            var cliente = _clienteLogica.ObtenerPorId(entidadId);

            if (_tipoOperacion == TipoOperacion.UpDate || _tipoOperacion == TipoOperacion.Delete)
            {

                txtApellido.Text = cliente.Apellido;
                txtNombre.Text = cliente.Nombre;
                txtRazonSocial.Text = cliente.RazonSocial;
                txtCuil.Text = cliente.Cuil;
                txtDni.Text = cliente.Dni;
                cmbCondicionIva.SelectedItem = cliente.CondicionIvaId;
                txtDireccion.Text = cliente.Domicilio;
                txtTelefono.Text = cliente.Telefono;
                txtCelular.Text = cliente.Celular;
                txtEmail.Text = cliente.Email;
            }    
            
            if(_tipoOperacion == TipoOperacion.Delete)
            {
                DesactivarControles(this);
            }
        }

        public void Inicializador()
        {
            txtApellido.KeyPress += Validaciones.NoSimbolos;
            txtApellido.KeyPress += Validaciones.NoNumeros;

            txtNombre.KeyPress += Validaciones.NoSimbolos;
            txtNombre.KeyPress += Validaciones.NoNumeros;

            txtCuil.KeyPress += Validaciones.NoSimbolos;
            txtCuil.KeyPress += Validaciones.NoLetras;

            txtCelular.KeyPress += Validaciones.NoSimbolos;
            txtCelular.KeyPress += Validaciones.NoLetras;

            txtTelefono.KeyPress += Validaciones.NoSimbolos;
            txtTelefono.KeyPress += Validaciones.NoLetras;

            PoblarComboBox(this.cmbCondicionIva, _condicionIva.Obtener(string.Empty), "Descripcion", "Id");
        }

        public virtual void PoblarComboBox(ComboBox cmb, object obj, string datosmostrar, string datostraer)
        {
            cmb.DataSource = obj;
            cmb.DisplayMember = datosmostrar;
            cmb.ValueMember = datostraer;
        }

    }
}
