using Presentacion.Base;
using Presentacion.Core.Clases;
using Servicios.Localidad;
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
    public partial class _0012_AbmLocalidad : FormularioAbm
    {
        private ProvinciaLogica _provinciaLogica;
        private LocalidadLogica _localidadLogica;
        private TipoOperacion _tipoOperacion;
        private long? _entidadId;
        public _0012_AbmLocalidad(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            InitializeComponent();
            _provinciaLogica = new ProvinciaLogica();
            _localidadLogica = new LocalidadLogica();
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
            PoblarComboBox(cmbProvincia, _provinciaLogica.Obtener(string.Empty), "Descripcion", "Id");
            CargarDatos(_entidadId);
        }
     
        public override void CargarDatos(long? entidadId)
        {
            if(TipoOperacion.Delete == _tipoOperacion || TipoOperacion.UpDate == _tipoOperacion)
            {
                var entidad = _localidadLogica.ObtenerPorId(entidadId.Value);

                txtDescripcion.Text = entidad.Descripcion;
            }

            if(TipoOperacion.Delete == _tipoOperacion)
            {
                DesactivarControles(this);
            }
        }

        public override void ComandoAgregar()
        {
            var nueva = new LocalidadDto
            {
                Descripcion = txtDescripcion.Text,
                ProvinciaId = ((ProvinciaDto)cmbProvincia.SelectedItem).Id
            };
            _localidadLogica.Insertar(nueva);
            MessageBox.Show("La localidad se Agrego Correctamente.");
            this.Close();
        }
        public override void ComandoEliminar()
        {
           
            if(_entidadId == null)
            {
                MessageBox.Show("Ocurrio un error y no se pudo Borrar la Localidad.");

            }
            _localidadLogica.Eliminar(_entidadId.Value);

            MessageBox.Show("Se Elimino Correctamente la Localidad.");
            this.Close();
        }
        public override void ComandoModificar()
        {

            var entidad = new LocalidadDto
            {
                Id = _entidadId.Value,
                Descripcion = txtDescripcion.Text,
                ProvinciaId = ((ProvinciaDto)cmbProvincia.SelectedItem).Id
            };
            _localidadLogica.Modificar(entidad);
            MessageBox.Show("Se Modifico Correctamente la Localidad.");
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
