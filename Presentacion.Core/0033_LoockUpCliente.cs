using Presentacion.Base;
using Servicios.Cliente;
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
    public partial class _0033_LoockUpCliente : FormularioLoockUp
    {
        private ClienteLogica _cliente;
        public _0033_LoockUpCliente()
        {
            InitializeComponent();
            _cliente = new ClienteLogica();
        }

        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = (List<ClienteDto>)_cliente.Obtener(cadenabuscar).Where(x => !x.EstaEliminado).ToList();
            base.ActualizarDatos(cadenabuscar);
        }
        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgvGrilla.Columns["ApyNom"].Visible = true;
            dgvGrilla.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgvGrilla.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Celular"].Visible = true;

            dgvGrilla.Columns["Domicilio"].Visible = true;

            dgvGrilla.Columns["Email"].Visible = true;
            dgvGrilla.Columns["Email"].HeaderText = "Correo Electronico";
            dgvGrilla.Columns["Email"].Width = 200;

        }

    }
}
