using Presentacion.Base;
using Presentacion.Base.Clases;
using Presentacion.Core.Clases;
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
    public partial class _0021_AbmCondicionIva : FormularioAbm
    {
        private CondicionIvaLogica _condicionIvaLogica;
        private long? _entidadId;
        private TipoOperacion _tipoOperacion;
        public _0021_AbmCondicionIva(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _condicionIvaLogica = new CondicionIvaLogica();
            _entidadId = entidadId;
            _tipoOperacion = tipoOperacion;
            Inicializador();
            CargarDatos(_entidadId);
        }

        public override void CargarDatos(long? entidadId)
        {
            
            if (TipoOperacion.UpDate == _tipoOperacion || TipoOperacion.Delete == _tipoOperacion)
            {
                var iva = _condicionIvaLogica.ObtenerPorId(entidadId.Value);
                txtDescripcion.Text = iva.Descripcion;
                cmbTipoComprobante.SelectedItem = iva.TipoComprobante;
            }

            if (TipoOperacion.Delete == _tipoOperacion)
            {
                DesactivarControles(this);
            }
        }
        public override void ComandoAgregar()
        {
            var nuevo = new CondicionIvaDto
            {
                Descripcion = txtDescripcion.Text,
                TipoComprobante = (TipoComprobante)cmbTipoComprobante.SelectedItem
                
            };

            _condicionIvaLogica.Insertar(nuevo);
            MessageBox.Show("La Condicion de Iva se Agrego Correctamente");
            this.Close();
        }
        public override void ComandoEliminar()
        {
            var eliminar = _condicionIvaLogica.ObtenerPorId(_entidadId.Value);
            _condicionIvaLogica.Eliminar(eliminar.Id);
            MessageBox.Show("La Condicion de Iva se Elimino Correctamente");
            this.Close();

        }
        public override void ComandoModificar()
        {
            var nuevo = new CondicionIvaDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text,
                TipoComprobante = (TipoComprobante)cmbTipoComprobante.SelectedItem
            };

            _condicionIvaLogica.Modificar(nuevo);
            MessageBox.Show("La Condicion de Iva se Modifico Correctamente");
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
            PoblarComboBox(cmbTipoComprobante, Enum.GetValues(typeof(TipoComprobante)));
        }

    }
}
