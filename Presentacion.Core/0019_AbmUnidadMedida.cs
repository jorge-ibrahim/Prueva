using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.UnidadMedida;
using System.Windows.Forms;

namespace Presentacion.Core
{
    public partial class _0019_AbmUnidadMedida : FormularioAbm
    {
        private UnidadMedidaLogica _unidadMedidaLogica;
        private long? _entidadId;
        private TipoOperacion _tipoOperacion;
        public _0019_AbmUnidadMedida(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _unidadMedidaLogica = new UnidadMedidaLogica();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            CargarDatos(_entidadId);
        }

        public override void CargarDatos(long? entidadId)
        {           
            if (TipoOperacion.UpDate == _tipoOperacion || TipoOperacion.Delete == _tipoOperacion)
            {
                var unidad = _unidadMedidaLogica.ObtenerPorId(entidadId.Value);
                txtDescripcion.Text = unidad.Descripcion;
            }

            if (TipoOperacion.Delete == _tipoOperacion)
            {
                DesactivarControles(this);
            }
        }
        public override void ComandoAgregar()
        {
            var nuevo = new UnidadMedidaDto
            {
                Descripcion = txtDescripcion.Text
            };

            _unidadMedidaLogica.Insertar(nuevo);
            MessageBox.Show("La Unidad se Agrego Correctamente");
            this.Close();
        }
        public override void ComandoEliminar()
        {
            var eliminar = _unidadMedidaLogica.ObtenerPorId(_entidadId.Value);
            _unidadMedidaLogica.Eliminar(eliminar.Id);
            MessageBox.Show("La Unidad se Elimino Correctamente");
            this.Close();

        }
        public override void ComandoModificar()
        {
            var nuevo = new UnidadMedidaDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text
            };

            _unidadMedidaLogica.Modificar(nuevo);
            MessageBox.Show("La Unidad se Modifico Correctamente");
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
    }
}
