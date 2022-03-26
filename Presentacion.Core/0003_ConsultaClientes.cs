using Presentacion.Core.Clases;
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
using System.Drawing.Printing;
//using System.Drawing;

namespace Presentacion.Core
{
    public partial class _0003_ConsultaClientes : Form
    {
        private ClienteLogica _clienteLogica;
        protected long? EntidadId;
        public _0003_ConsultaClientes()
        {
            InitializeComponent();
            EntidadId = null;
            _clienteLogica = new ClienteLogica();
        }

        //BOTONES//
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new _0004_AbmClientes(TipoOperacion.Insert);
            nuevo.ShowDialog();
            if (nuevo.RealizoAlgunaOperacion)
            {
                ActualizarDatos(string.Empty);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (VerificarRegistros())
            {
                if (VerificarEntidadSeleccionada())
                {
                    var modificar = new _0004_AbmClientes(TipoOperacion.UpDate, EntidadId);
                    modificar.ShowDialog();
                    if(modificar.RealizoAlgunaOperacion)
                    {
                        ActualizarDatos(string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("No se selecciono Ningun Elemento");
                }
            }
            else
            {
                MessageBox.Show("No hay Elementos Cargados en la Grilla.");
            }           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (VerificarRegistros())
            {
                if (VerificarEntidadSeleccionada())
                {
                    var eliminar = new _0004_AbmClientes(TipoOperacion.Delete, EntidadId);
                    eliminar.ShowDialog();
                    if(eliminar.RealizoAlgunaOperacion)
                    {
                        ActualizarDatos(string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("No se selecciono Ningun Elemento");
                }
            }
            else
            {
                MessageBox.Show("No hay Elementos Cargados en la Grilla.");
            }           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument _doc = new PrintDocument();
            _doc.DefaultPageSettings.Landscape = true; //establesco que la pagina por defecto se crea e imprime verticalmente.
            _doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";//Aca establesco el nombre de la impresora donde imprimire.

            PrintPreviewDialog Pd = new PrintPreviewDialog { Document = _doc };
            ((Form)Pd).WindowState = FormWindowState.Maximized;//establesco que el formulario esta maximisado.

            _doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int Alto = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach(DataGridViewColumn col in dgvGrilla.Columns)//Recorrer Todas las columnas
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Calibri",16,FontStyle.Bold), Brushes.DeepSkyBlue,left,top);
                    left += col.Width;
                    if(col.Index < dgvGrilla.ColumnCount - 1 )//para que la ultima columna no tenga linea
                    {
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvGrilla.RowCount - 1) * Alto);
                    }
     
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach(DataGridViewRow row in dgvGrilla.Rows)
                {
                    if (row.Index == dgvGrilla.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Calibri", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += Alto;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };

            Pd.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(txtBuscar.Text);
        }

        //METODOS//

        public virtual void ActualizarDatos( string cadenabuscar)
        {
            dgvGrilla.DataSource = _clienteLogica.Obtener(cadenabuscar);
        }

        public virtual void FormatearGrilla()
        {
            for (var i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }

            dgvGrilla.Columns["RazonSocial"].Visible = true;
            dgvGrilla.Columns["RazonSocial"].HeaderText = "Razon Social";
            dgvGrilla.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["ApyNom"].Visible = true;
            dgvGrilla.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgvGrilla.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Cuil"].Visible = true;
            dgvGrilla.Columns["Cuil"].HeaderText = "Cuil";
            dgvGrilla.Columns["Cuil"].Width = 100;

            dgvGrilla.Columns["Celular"].Visible = true;
            dgvGrilla.Columns["Celular"].HeaderText = "Celular";
            dgvGrilla.Columns["Celular"].Width = 100;

            dgvGrilla.Columns["Domicilio"].Visible = true;
            dgvGrilla.Columns["Domicilio"].HeaderText = "Domicilio";
            dgvGrilla.Columns["Domicilio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Email"].Visible = true;
            dgvGrilla.Columns["Email"].HeaderText = "Email";
            dgvGrilla.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public virtual bool VerificarEntidadSeleccionada()//Metodo para verificar si se seleccono una entidad
        {
            return EntidadId.HasValue;
        }

        public virtual bool VerificarRegistros()
        {
            return dgvGrilla.RowCount > 0;
        }//Metodo para verifciar si hay datos en la grilla.

        //EVENTOS//
        private void _0003_ConsultaClientes_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
            FormatearGrilla();
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                EntidadId = (int)(long?)dgvGrilla["Id", e.RowIndex].Value;            
            }
            else
            {
                EntidadId = null;
            }
        }
    }
}
