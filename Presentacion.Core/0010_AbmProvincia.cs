using Presentacion.Base;
using Presentacion.Base.Clases;
using Presentacion.Core.Clases;
using Servicios.Provincia;
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
    public partial class _0010_AbmProvincia : FormularioAbm
    {
        private TipoOperacion _tipoOperacion;
        private long? _entidadId;
        private ProvinciaLogica _provinciaLogica;
        public _0010_AbmProvincia(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            Inicializador();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            _provinciaLogica = new ProvinciaLogica();
            Inicializador();
            CargarDatos(_entidadId);
        }

        public override void Inicializador()
        {
            txtDescripcion.KeyPress += Validaciones.NoSimbolos;
            txtDescripcion.KeyPress += Validaciones.NoNumeros;           
        }
        public override void CargarDatos(long? entidadId)
        {
            
            if(TipoOperacion.Delete == _tipoOperacion || TipoOperacion.UpDate == _tipoOperacion)
            {
                var entidad = _provinciaLogica.ObtenerPorId(entidadId.Value);//si lo pongo fuera del if me tira error
                txtDescripcion.Text = entidad.Descripcion;
            }

            if(TipoOperacion.Delete == _tipoOperacion)
            {
                DesactivarControles(this);
            }
        }
        public override void ComandoAgregar()
        {
            var entidad = new ProvinciaDto
            {
                Descripcion = txtDescripcion.Text
            };

            _provinciaLogica.Insertar(entidad);
            MessageBox.Show("La provincia se Agrego Correctamente.");
            this.Close();
        }
        public override void ComandoModificar()
        {
            var entidad = new ProvinciaDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text
            };
            _provinciaLogica.Modificar(entidad);
            MessageBox.Show("La provincia se Modifico Correctamente.");
            this.Close();

        }
        public override void ComandoEliminar()
        {
            _provinciaLogica.Eliminar(_entidadId.Value);
            MessageBox.Show("La provincia se Elimino Correctamente.");
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
