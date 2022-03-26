using Presentacion.Base;
using Presentacion.Base.Clases;
using Presentacion.Core.Clases;
using Servicios.Proveedor;
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
    public partial class _0006_AbmProveedor : FormularioAbm
    {
        private TipoOperacion _tipoOperacion;
        private long? _entidadId;
        private ProveedorLogica _proveedorLogica;
        public _0006_AbmProveedor()
        {
            InitializeComponent();
        }
        public _0006_AbmProveedor(TipoOperacion tipoOperacion,long? entidadId = null)
            :base()
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _proveedorLogica = new ProveedorLogica();
            CargarDatos(_entidadId);
            Inicializador();
        }

        public override void CargarDatos(long? entidadId)
        {
            var proveedor = _proveedorLogica.ObtenerId(entidadId);
            if(_tipoOperacion == TipoOperacion.UpDate || _tipoOperacion == TipoOperacion.Delete)
            {
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtCUIT.Text = proveedor.Cuil;
                txtTelefono.Text = proveedor.Telefono;
                txtCelular.Text = proveedor.Celular;
                txtDireccion.Text = proveedor.Direccion;
                txtEmail.Text = proveedor.Email;
            }

            if(_tipoOperacion == TipoOperacion.Delete)
            {
                DesactivarControles(this);
            }

        }
        public override void ComandoAgregar()
        {
            var entidad = new ProveedorDto
            {
                RazonSocial = txtRazonSocial.Text,
                Cuil = txtCUIT.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Email = txtEmail.Text
            };

            _proveedorLogica.Agregar(entidad);
            MessageBox.Show("El Proveedor se Agrego Correctamente");
            this.Close();
        }
        public override void ComandoModificar()
        {
            var entidad = new ProveedorDto
            {
                Id = _entidadId.Value,
                RazonSocial = txtRazonSocial.Text,
                Cuil = txtCUIT.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Email = txtEmail.Text
            };
            _proveedorLogica.Modificar(entidad);
            MessageBox.Show("El Proveedor se Modifico Correctamente");
            this.Close();
        }
        public override void ComandoEliminar()
        {
            var entidad = _proveedorLogica.ObtenerId(_entidadId);
            _proveedorLogica.Eliminar(entidad.Id);
            MessageBox.Show("El Proveedor se Elimino.");
            this.Close();
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

        public override void Inicializador()
        {

            txtCUIT.KeyPress += Validaciones.NoSimbolos;
            txtCUIT.KeyPress += Validaciones.NoLetras;

            txtCelular.KeyPress += Validaciones.NoSimbolos;
            txtCelular.KeyPress += Validaciones.NoLetras;

            txtTelefono.KeyPress += Validaciones.NoSimbolos;
            txtTelefono.KeyPress += Validaciones.NoLetras;
        }

    }
}
