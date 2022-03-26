using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Base
{
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }
        public virtual void ActivarControles(object obj, bool estado)
        {
            if (obj is Form)//sos un formulario?
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else
                    if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else
                    if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    else
                    if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else
                        if (ctrol is Panel)
                    {
                        ActivarControles(ctrol, estado);
                    }
                }//fin foreach
            }
            else
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else
                    if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else
                    if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else
                        if (ctrol is Panel)
                    {
                        ActivarControles(ctrol, estado);
                    }
                }//fin foreach
            }
        }
        protected void DesactivarControles(object obj)
        {
            if (obj is Form)
            {
                foreach (var controlForm in ((Form)obj).Controls)
                {
                    if (controlForm is TextBox)
                    {
                        ((TextBox)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is ComboBox)
                    {
                        ((ComboBox)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is NumericUpDown)
                    {
                        ((NumericUpDown)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is Button)
                    {
                        ((Button)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is DateTimePicker)
                    {
                        ((DateTimePicker)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is CheckBox)
                    {
                        ((CheckBox)controlForm).Enabled = false;
                        continue;
                    }

                    if (controlForm is Panel)
                    {
                        DesactivarControles(controlForm);
                        continue;
                    }

                    if (controlForm is GroupBox)
                    {
                        DesactivarControles(controlForm);
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ControlPanel in ((Panel)obj).Controls)
                {
                    if (ControlPanel is TextBox)
                    {
                        ((TextBox)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is ComboBox)
                    {
                        ((ComboBox)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is NumericUpDown)
                    {
                        ((NumericUpDown)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is Button)
                    {
                        ((Button)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is DateTimePicker)
                    {
                        ((DateTimePicker)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is CheckBox)
                    {
                        ((CheckBox)ControlPanel).Enabled = false;
                        continue;
                    }

                    if (ControlPanel is Panel)
                    {
                        DesactivarControles(ControlPanel);
                        continue;
                    }

                    if (ControlPanel is GroupBox)
                    {
                        DesactivarControles(ControlPanel);
                    }
                }
            }
            else if (obj is GroupBox)
            {
                foreach (var ControlGroupBox in ((GroupBox)obj).Controls)
                {
                    if (ControlGroupBox is TextBox)
                    {
                        ((TextBox)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is ComboBox)
                    {
                        ((ComboBox)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is NumericUpDown)
                    {
                        ((NumericUpDown)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is Button)
                    {
                        ((Button)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is DateTimePicker)
                    {
                        ((DateTimePicker)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is CheckBox)
                    {
                        ((CheckBox)ControlGroupBox).Enabled = false;
                        continue;
                    }

                    if (ControlGroupBox is Panel)
                    {
                        DesactivarControles(ControlGroupBox);
                        continue;
                    }

                    if (ControlGroupBox is GroupBox)
                    {
                        DesactivarControles(ControlGroupBox);
                    }
                }
            }
        }

        public virtual void Limpiar(object obj)
        {
            if (obj is Form)
            {
                foreach (var ctrolForm in ((Form)obj).Controls)
                {
                    if (ctrolForm is TextBox)
                    {
                        ((TextBox)ctrolForm).Clear();
                    }

                    if (ctrolForm is ComboBox)
                    {
                        if (((ComboBox)ctrolForm).Items.Count > 0)
                        {
                            ((ComboBox)ctrolForm).SelectedIndex = 0;
                        }
                    }

                    if (ctrolForm is NumericUpDown)
                    {
                        ((NumericUpDown)ctrolForm).Value = ((NumericUpDown)ctrolForm).Minimum;
                    }

                    if (ctrolForm is DateTimePicker)
                    {
                        ((DateTimePicker)ctrolForm).Value = DateTime.Now;
                    }

                    if (ctrolForm is Panel)
                    {
                        Limpiar(ctrolForm);
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ctrolPanel in ((Panel)obj).Controls)
                {
                    if (ctrolPanel is TextBox)
                    {
                        ((TextBox)ctrolPanel).Clear();
                    }

                    if (ctrolPanel is ComboBox)
                    {
                        if (((ComboBox)ctrolPanel).Items.Count > 0)
                        {
                            ((ComboBox)ctrolPanel).SelectedIndex = 0;
                        }
                    }

                    if (ctrolPanel is NumericUpDown)
                    {
                        ((NumericUpDown)ctrolPanel).Value = ((NumericUpDown)ctrolPanel).Minimum;
                    }

                    if (ctrolPanel is DateTimePicker)
                    {
                        ((DateTimePicker)ctrolPanel).Value = DateTime.Now; // fecha Sistema
                    }

                    if (ctrolPanel is Panel)
                    {
                        Limpiar(ctrolPanel);
                    }
                }
            }
        }      

        public virtual void PoblarComboBox(ComboBox cmb,object obj,string datosmostrar,string datostraer)
        {
            cmb.DataSource = obj;
            cmb.DisplayMember = datosmostrar;
            cmb.ValueMember = datostraer;
        }

        public virtual void PoblarComboBox(ComboBox cmb, object datos)//este lo uso para cargar enums
        {
            cmb.DataSource = datos;
        }

        public virtual void Inicializador()
        {

        }

        public virtual void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
               // dgv.Columns[i].DefaultCellStyle.BackColor = Color.Yellow;
                dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv.Columns[i].ContextMenuStrip.Co
            }
        }

        public virtual void ActualizarDatos(string cadenabuscar)
        {

        }

        public virtual bool VerificarDatosObligatorios()
        {
            //foreach (var ctrol in _listaDeControlesObligatorios)
            //{
            //    switch (ctrol.Objeto)
            //    {
            //        case TextBox tbox:
            //            if (string.IsNullOrEmpty(tbox.Text)) return false;
            //            break;
            //        case RichTextBox rbox:
            //            if (string.IsNullOrEmpty(rbox.Text)) return false;
            //            break;
            //        case NumericUpDown down:
            //            if (string.IsNullOrEmpty(down.Text)) return false;
            //            break;
            //        case ComboBox cbox:
            //            if (cbox.Items.Count <= 0) return false;
            //            break;
            //        case DateTimePicker dPicker:
            //            if (string.IsNullOrEmpty(dPicker.Text)) return false;
            //            break;
            //    }
            //}

            return true;
        }
    }
}
