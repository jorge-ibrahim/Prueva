using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Rubro;
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
    public partial class _0015_AbmRubro : FormularioAbm
    {
        private TipoOperacion _tipoOperacion;
        private long? _entidadId;
        private RubroLogica _rubroLogica;

        public _0015_AbmRubro()
        {
            InitializeComponent();
        }
        public _0015_AbmRubro(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _rubroLogica = new RubroLogica();
            CargarDatos(_entidadId);
        }

        public override void CargarDatos(long? entidadId)
        {
            var rubro = _rubroLogica.ObtenerPorId(entidadId);
            if(TipoOperacion.UpDate == _tipoOperacion || TipoOperacion.Delete == _tipoOperacion)
            {
                txtDescripcion.Text = rubro.Descripcion;
            }

            if(TipoOperacion.Delete == _tipoOperacion)
            {
                DesactivarControles(this);
              
            }
        }
        public override void ComandoAgregar()
        {
            var nuevo = new RubroDto
            {
                Descripcion = txtDescripcion.Text
            };

            _rubroLogica.Insertar(nuevo);
            MessageBox.Show("El Rubro se Agrego Correctamente");
            this.Close();
        }
        public override void ComandoEliminar()
        {
            var eliminar = _rubroLogica.ObtenerPorId(_entidadId);
            _rubroLogica.Eliminar(eliminar.Id);
            MessageBox.Show("El Rubro se Elimino Correctamente");
            this.Close();

        }
        public override void ComandoModificar()
        {
            var nuevo = new RubroDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text
            };

            _rubroLogica.Modificar(nuevo);
            MessageBox.Show("El Rubro se Modifico Correctamente");
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
