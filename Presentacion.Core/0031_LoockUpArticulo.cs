using Presentacion.Base;
using Servicios.Articulo;
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
    public partial class _0031_LoockUpArticulo : FormularioLoockUp
    {
        private readonly ArticuloLogica _articulo;
        public _0031_LoockUpArticulo()
        {
            InitializeComponent();
            _articulo = new ArticuloLogica();
        }

        public override void ActualizarDatos(string cadenabuscar)
        {
            dgvGrilla.DataSource = (List<ArticuloDto>)_articulo.Obtener(cadenabuscar).Where(x => !x.EstaEliminado).ToList();

            base.ActualizarDatos(cadenabuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Codigo"].Visible = true;
            dgv.Columns["Codigo"].HeaderText = "CODIGO ARTICULO";
            dgv.Columns["Codigo"].Width = 70;

            dgv.Columns["CodigoBarra"].Visible = true;
            dgv.Columns["CodigoBarra"].HeaderText = "CODIGO DE BARRA";
            dgv.Columns["CodigoBarra"].Width = 120;

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["Stock"].Visible = true;
            dgv.Columns["Stock"].HeaderText = "STOCK";
            dgv.Columns["Stock"].Width = 100;
        }

    }
}
