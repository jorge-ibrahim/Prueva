using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Marca;
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
    public partial class _0017_AbmMarca : FormularioAbm
    {
        private TipoOperacion _tipoOperacion;
        private long? _entidadId;
        private MarcaLogica _marcaLogica;
        public _0017_AbmMarca(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _marcaLogica = new MarcaLogica();
            Inicializador();
            CargarDatos(_entidadId);
        }

        public override void CargarDatos(long? entidadId)
        {
            if(_tipoOperacion == TipoOperacion.Delete || _tipoOperacion == TipoOperacion.UpDate)
            {
                var entidad = _marcaLogica.ObtenerPorId(entidadId.Value);

                txtDescripcion.Text = entidad.Descripcion;
            }
            if(_tipoOperacion == TipoOperacion.Delete)
            {
                DesactivarControles(this);
            }
        }
        public override void Inicializador()
        {
            
        }
        public override void ComandoAgregar()
        {
            var entidad = new MarcaDto
            {
                Descripcion = txtDescripcion.Text
            };
            _marcaLogica.Insertar(entidad);
            MessageBox.Show("La Marca se Agrego Correctamente.");
            this.Close();
        }
        public override void ComandoEliminar()
        {
            _marcaLogica.Eliminar(_entidadId.Value);
            MessageBox.Show("La Marca se Elimino Correctamente.");
            this.Close();
        }
        public override void ComandoModificar()
        {
            var entidad = new MarcaDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text
            };
            _marcaLogica.Modificar(entidad);
            MessageBox.Show("La Marca se Modifico Correctamente.");
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
