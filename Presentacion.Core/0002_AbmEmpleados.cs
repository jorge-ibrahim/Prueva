using Presentacion.Base;
using Presentacion.Base.Clases;
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
    public partial class _0002_AbmEmpleados : FormularioAbm
    {
        private TipoOperacion _tipoOperacion;
        private EmpleadoLogica _empleadoLogica;
        private long? _entidadId;
        public _0002_AbmEmpleados(TipoOperacion tipoOperacion, long? entidadId = null)
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _empleadoLogica = new EmpleadoLogica();
            _entidadId = entidadId;
            CargarDatos(entidadId);
            Inicializador();
        }
        public override void EjecutarComandos()
        {
            switch (_tipoOperacion)
            {
                case TipoOperacion.Insert:
                    ComandoAgregar();
                    RealizoAlgunaOperacion = true;

                    break;

                case TipoOperacion.Delete:
                    ComandoEliminar();
                    RealizoAlgunaOperacion = true;

                    break;
                case TipoOperacion.UpDate:
                    ComandoModificar();
                    RealizoAlgunaOperacion = true;
                    break;
            }
        }
        public override void ComandoAgregar()
        {   
            var nuevo = new EmpleadoDto
            {
                Legajo = (int)nudLegajo.Value,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
            };

            _empleadoLogica.Agregar(nuevo);

            MessageBox.Show("Los Datos Se Agregaron Correctamente");
            this.Close();
        }
        public override void ComandoEliminar()
        {
            base.ComandoEliminar();
            _empleadoLogica.Eliminar(_entidadId);
            MessageBox.Show("El empleado se Elimino Correctamente.");
            this.Close();
        }
        public override void ComandoModificar()
        {          

            var modificar = new EmpleadoDto
            {
                Id = _entidadId.Value,
                Legajo = (int)nudLegajo.Value,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text
            };

            _empleadoLogica.Modificar(modificar);
        
            MessageBox.Show("Los datos se Modifico Correctamente");
            this.Close();
        }
        public override void CargarDatos(long? entidad)
        {
            var empleado = _empleadoLogica.ObtenerPorId(entidad);

            if (_tipoOperacion == TipoOperacion.UpDate || _tipoOperacion == TipoOperacion.Delete)
            {
                
                nudLegajo.Value = Convert.ToInt32(empleado.Legajo) ;
                txtApellido.Text = empleado.Apellido;
                txtNombre.Text = empleado.Nombre;
                txtDni.Text = empleado.Dni;
                txtDireccion.Text = empleado.Domicilio;
                txtTelefono.Text = empleado.Telefono;
                txtCelular.Text = empleado.Celular;
            }

            if(_tipoOperacion == TipoOperacion.Delete)
            {
                DesactivarControles(this);
            }

            if(_tipoOperacion == TipoOperacion.Insert)
            {
                nudLegajo.Value = _empleadoLogica.ObtenerSiguienteLegajo();
                nudLegajo.Enabled = false;
            }

        }
        public override void Inicializador()
        {
            txtApellido.KeyPress += Validaciones.NoSimbolos;
            txtApellido.KeyPress += Validaciones.NoNumeros;

            txtNombre.KeyPress += Validaciones.NoSimbolos;
            txtNombre.KeyPress += Validaciones.NoNumeros;

            txtDni.KeyPress += Validaciones.NoSimbolos;
            txtDni.KeyPress += Validaciones.NoLetras;

            txtCelular.KeyPress += Validaciones.NoSimbolos;
            txtCelular.KeyPress += Validaciones.NoLetras;

            txtTelefono.KeyPress += Validaciones.NoSimbolos;
            txtTelefono.KeyPress += Validaciones.NoLetras;
        }

    }
}
