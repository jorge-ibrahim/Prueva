using Presentacion.Core.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Presentacion.Base
{
    public partial class FormularioAbm : FormularioBase
    {
        protected TipoOperacion _tipoOperacion;
        protected long? _entidadId;
        public bool RealizoAlgunaOperacion;

        
        public FormularioAbm()           
        {
            InitializeComponent();
            RealizoAlgunaOperacion = false;
        }

        public FormularioAbm(TipoOperacion tipoOperacion,long? entidadId = null)
        {
            _tipoOperacion = tipoOperacion;
            _entidadId = entidadId;
        }

        //BOTONES//
        public virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            EjecutarComandos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioAbm_Load(object sender, EventArgs e)
        {

        }

        //METODOS//

        public virtual void ComandoAgregar()
        {
            
        }

        public virtual void ComandoModificar()
        {
            
        }

        public virtual void ComandoEliminar()
        {
            
        }

        public virtual void CargarDatos(long? entidadId)
        {

        }
        


        /// <summary>
        /// NO BORRAR EL METODO BASE
        /// </summary>
        public virtual void EjecutarComandos()
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
