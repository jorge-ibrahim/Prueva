using Presentacion.Base.Clases;
using Servicios.Caja;
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
    public partial class _0026_AbriCaja : Form
    {
        private CajaLogica _cajaLogica;
        public _0026_AbriCaja()
        {
            InitializeComponent();
            _cajaLogica = new CajaLogica();
        }

        private void iconToolStripButton3_Click(object sender, EventArgs e)//boton salir
        {
            this.Close();
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)//boton guardar
        {
            try
            {
                var usuario = Identidad.UsuarioLogueadoId;
                Identidad.CajaId = _cajaLogica.AbrirCaja(new CajaDto
                {
                   // UsuarioApertura = Identidad.ApyNomUsuarioLogin,
                    ApellidoEmpleadoApertura = Identidad.ApellidoEmpleado,
                    NombreEmpleadoApertura = Identidad.NombreEmpleado,
                    ApellidoEmpleadoCierre = "No Tiene",
                    NombreEmpleadoCierre = "No Tiene",
                    UsuarioAperturaId = usuario,
                    MontoInicial = nudMonto.Value,
                    FechaApertura = DateTime.Now
                });
                MessageBox.Show($"Caja Abierta por {Identidad.ApyNomUsuarioLogin}");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al Iniciar la Caja");
            }
        }

        private void iconToolStripButton2_Click(object sender, EventArgs e)//boton limpiar
        {
            nudMonto.Value = 0m;
        }
    }
}
