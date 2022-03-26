using Presentacion.Base;
using Presentacion.Base.Clases;
using Presentacion.Core.Clases;
using Servicios.Articulo;
using Servicios.Marca;
using Servicios.Proveedor;
using Servicios.Rubro;
using Servicios.UnidadMedida;
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
    public partial class _0008_AbmArticulo : FormularioAbm
    {
        private long? _entidadId;
        private TipoOperacion _tipoOperacion;
        private MarcaLogica _marcaLogica;
        private RubroLogica _rubroLogica;
        private ProveedorLogica _proveedorLogica;
        private UnidadMedidaLogica _unidadMedidaLogica;
        private ArticuloLogica _articuloLogica;
        public _0008_AbmArticulo()
        {
            InitializeComponent();
        }
        public _0008_AbmArticulo(TipoOperacion tipoOperacion, long? entidadId = null)     
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _marcaLogica = new MarcaLogica();
            _rubroLogica = new RubroLogica();
            _proveedorLogica = new ProveedorLogica();
            _unidadMedidaLogica = new UnidadMedidaLogica();
            _articuloLogica = new ArticuloLogica();
            CargarDatos(_entidadId);
            Inicializador();

        }


        //METODOS
        public override void ComandoAgregar()
        {
            var entidad = new ArticuloDto
            {
                Codigo = (int)nudCodigo.Value,
                CodigoBarra = txtcodigoBarra.Text,
                Descripcion = txtDescripcion.Text,
                Detalle = txtDetalle.Text,
                Stock = nudStock.Value,
                ProveedorId = ((ProveedorDto)cmbProveedor.SelectedItem).Id,
                RubroId = ((RubroDto)cmbRubro.SelectedItem).Id,
                MarcaId = ((MarcaDto)cmbMarca.SelectedItem).Id,
                UnidadMedidaId = ((UnidadMedidaDto)cmbUnidadMedida.SelectedItem).Id,
                PrecioCosto = nudPrecioCosto.Value

            };

            _articuloLogica.Agregar(entidad);
            MessageBox.Show("El Articulo se Agrego correctamente.");
            this.Close();
        }

        public override void ComandoModificar()
        {
            var entidad = new ArticuloDto
            {
                Id = _entidadId.Value,
                Codigo = (int)nudCodigo.Value,
                CodigoBarra = txtcodigoBarra.Text,
                Descripcion = txtDescripcion.Text,
                Detalle = txtDetalle.Text,
                Stock = nudStock.Value,
                ProveedorId = ((ProveedorDto)cmbProveedor.SelectedItem).Id,
                RubroId = ((RubroDto)cmbRubro.SelectedItem).Id,
                MarcaId = ((MarcaDto)cmbMarca.SelectedItem).Id,
                UnidadMedidaId = ((UnidadMedidaDto)cmbUnidadMedida.SelectedItem).Id
            };

            _articuloLogica.Modificar(entidad);
            MessageBox.Show("El Articulo se Modifico correctamente.");
            this.Close();
        }

        public override void ComandoEliminar()
        {
            _articuloLogica.Eliminar(_entidadId.Value);
            MessageBox.Show("El Articulo se Elimino correctamente.");
            this.Close();
        }

        public override void CargarDatos(long? entidadId)
        {
            var articulo = _articuloLogica.ObtenerPorId(entidadId);
            if (_tipoOperacion == TipoOperacion.UpDate || _tipoOperacion == TipoOperacion.Delete)
            {
                nudCodigo.Value = articulo.Codigo;
                txtcodigoBarra.Text = articulo.CodigoBarra;
                txtDescripcion.Text = articulo.Descripcion;
                txtDetalle.Text = articulo.Detalle;
                nudStock.Value = articulo.Stock;
                nudPrecioCosto.Value = articulo.PrecioCosto;
                PoblarComboBox(cmbMarca, _marcaLogica.Obtener(string.Empty), "Descripcion", "Id");
                PoblarComboBox(cmbRubro, _rubroLogica.Obtener(string.Empty), "Descripcion", "Id");
                PoblarComboBox(cmbProveedor, _proveedorLogica.Obtener(string.Empty), "Descripcion", "Id");
                PoblarComboBox(cmbUnidadMedida, _unidadMedidaLogica.Obtener(string.Empty), "Descripcion", "Id");
                cmbRubro.SelectedItem = articulo.RubroId;
                cmbMarca.SelectedItem = articulo.MarcaId;
                cmbProveedor.SelectedItem = articulo.ProveedorId;
                cmbUnidadMedida.SelectedItem = articulo.UnidadMedidaId;

            }

            if (_tipoOperacion == TipoOperacion.Delete)
            {
                DesactivarControles(this);
            }

            if(_tipoOperacion == TipoOperacion.Insert)
            {
                nudCodigo.Value = _articuloLogica.ObtenerSiguienteCodigo();
                nudCodigo.Enabled = false;
            }
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

            PoblarComboBox(cmbProveedor, _proveedorLogica.Obtener(string.Empty), "RazonSocial", "Id");
            PoblarComboBox(cmbMarca, _marcaLogica.Obtener(string.Empty), "Descripcion", "Id");
            PoblarComboBox(cmbRubro, _rubroLogica.Obtener(string.Empty), "Descripcion", "Id");
            PoblarComboBox(cmbUnidadMedida, _unidadMedidaLogica.Obtener(string.Empty), "Descripcion", "Id");

            nudCodigo.KeyPress += Validaciones.NoLetras;
            nudCodigo.KeyPress += Validaciones.NoSimbolos;

            txtcodigoBarra.KeyPress += Validaciones.NoSimbolos;
            txtcodigoBarra.KeyPress += Validaciones.NoLetras;
        }

        //BOTONES
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            var nuevo = new _0006_AbmProveedor(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if(nuevo.RealizoAlgunaOperacion)
            {
                PoblarComboBox(cmbProveedor, _proveedorLogica.Obtener(string.Empty), "RazonSocial", "Id");
            }
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            var nuevo = new _0017_AbmMarca(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if(nuevo.RealizoAlgunaOperacion)
            {
                PoblarComboBox(cmbMarca, _marcaLogica.Obtener(string.Empty), "Descripcion", "Id");
            }
        }

        private void btnNuevoRubro_Click(object sender, EventArgs e)
        {
            var nuevo = new _0015_AbmRubro(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if(nuevo.RealizoAlgunaOperacion)
            {
                PoblarComboBox(cmbRubro, _rubroLogica.Obtener(string.Empty), "Descripcion", "Id");
            }
        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            var nuevo = new _0019_AbmUnidadMedida(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if (nuevo.RealizoAlgunaOperacion)
            {
                PoblarComboBox(cmbUnidadMedida, _unidadMedidaLogica.Obtener(string.Empty), "Descripcion", "Id");
            }
        }
    }
}
