using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.ListaPrecio;
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
    public partial class _0030_AbmListaPrecio : FormularioAbm
    {
        private TipoOperacion _tipoOperacion;
        private long? _entidadId;
        private ListaPrecioLogica _listaPrecio;
        public _0030_AbmListaPrecio(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _listaPrecio = new ListaPrecioLogica();
            CargarDatos(_entidadId);
        }

        public override void ComandoEliminar()
        {
            _listaPrecio.Eliminar(_entidadId.Value);
            MessageBox.Show("La Lista se Elimino Correctamente.");
            this.Close();
        }
        public override void ComandoAgregar()
        {
            var entidad = new ListaPrecioDto
            {
                Descripcion = txtDescripcion.Text,
                PorcentajeGanancia = nudPorcentaje.Value
            };
            _listaPrecio.Insertar(entidad);
            MessageBox.Show("La Lista se Agrego Correctamente.");
            this.Close();
        }
        public override void ComandoModificar()
        {
            var entidad = new ListaPrecioDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text,
                PorcentajeGanancia = nudPorcentaje.Value
            };
            _listaPrecio.Modificar(entidad);
            MessageBox.Show("La Lista se Modifico Correctamente.");
            this.Close();
        }
        public override void CargarDatos(long? entidadId)
        {
            
            if(_tipoOperacion == TipoOperacion.UpDate || _tipoOperacion == TipoOperacion.Delete)
            {
                var entidad = _listaPrecio.ObtenerPorId(entidadId.Value);
                txtDescripcion.Text = entidad.Descripcion;
                nudPorcentaje.Value = entidad.PorcentajeGanancia;
            }

            if(_tipoOperacion == TipoOperacion.Delete)
            {
                DesactivarControles(this);
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
            base.Inicializador();
        }
    }
}
