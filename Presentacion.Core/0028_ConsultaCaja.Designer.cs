
namespace Presentacion.Core
{
    partial class _0028_ConsultaCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.imgLupa = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.MenuConsulta = new System.Windows.Forms.ToolStrip();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton3 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton4 = new FontAwesome.Sharp.IconToolStripButton();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.pnlMovimientos = new System.Windows.Forms.Panel();
            this.lblMovimientos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLupa)).BeginInit();
            this.MenuConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.pnlMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(0, 100);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(1237, 521);
            this.dgvGrilla.TabIndex = 9;
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.Silver;
            this.pnlBusqueda.Controls.Add(this.dtpFechaHasta);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.dtpFechaDesde);
            this.pnlBusqueda.Controls.Add(this.label4);
            this.pnlBusqueda.Controls.Add(this.imgLupa);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBusqueda);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 52);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(1237, 48);
            this.pnlBusqueda.TabIndex = 8;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(720, 14);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaHasta.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(539, 14);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaDesde.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha Desde";
            // 
            // imgLupa
            // 
            this.imgLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLupa.Location = new System.Drawing.Point(840, 6);
            this.imgLupa.Name = "imgLupa";
            this.imgLupa.Size = new System.Drawing.Size(37, 37);
            this.imgLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLupa.TabIndex = 3;
            this.imgLupa.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1123, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(882, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(235, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.MenuConsulta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuConsulta.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MenuConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconToolStripButton1,
            this.iconToolStripButton2,
            this.iconToolStripButton3,
            this.iconToolStripButton4});
            this.MenuConsulta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuConsulta.Location = new System.Drawing.Point(0, 0);
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(1237, 52);
            this.MenuConsulta.TabIndex = 7;
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton1.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Green;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(66, 49);
            this.iconToolStripButton1.Text = "Abrir Caja";
            this.iconToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton1.Click += new System.EventHandler(this.iconToolStripButton1_Click);
            // 
            // iconToolStripButton2
            // 
            this.iconToolStripButton2.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton2.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconToolStripButton2.IconColor = System.Drawing.Color.OrangeRed;
            this.iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton2.Name = "iconToolStripButton2";
            this.iconToolStripButton2.Size = new System.Drawing.Size(73, 49);
            this.iconToolStripButton2.Text = "Cerrar Caja";
            this.iconToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton2.Click += new System.EventHandler(this.iconToolStripButton2_Click);
            // 
            // iconToolStripButton3
            // 
            this.iconToolStripButton3.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton3.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton3.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconToolStripButton3.IconColor = System.Drawing.Color.Blue;
            this.iconToolStripButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton3.Name = "iconToolStripButton3";
            this.iconToolStripButton3.Size = new System.Drawing.Size(66, 49);
            this.iconToolStripButton3.Text = "Actualizar";
            this.iconToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton3.Click += new System.EventHandler(this.iconToolStripButton3_Click);
            // 
            // iconToolStripButton4
            // 
            this.iconToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.iconToolStripButton4.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton4.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton4.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconToolStripButton4.IconColor = System.Drawing.Color.Red;
            this.iconToolStripButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton4.Name = "iconToolStripButton4";
            this.iconToolStripButton4.Size = new System.Drawing.Size(35, 49);
            this.iconToolStripButton4.Text = "Salir";
            this.iconToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton4.Click += new System.EventHandler(this.iconToolStripButton4_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 327);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(1237, 293);
            this.dgvMovimientos.TabIndex = 10;
            // 
            // pnlMovimientos
            // 
            this.pnlMovimientos.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMovimientos.Controls.Add(this.lblMovimientos);
            this.pnlMovimientos.Location = new System.Drawing.Point(0, 243);
            this.pnlMovimientos.Name = "pnlMovimientos";
            this.pnlMovimientos.Size = new System.Drawing.Size(1237, 78);
            this.pnlMovimientos.TabIndex = 11;
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.Location = new System.Drawing.Point(23, 23);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(254, 33);
            this.lblMovimientos.TabIndex = 34;
            this.lblMovimientos.Text = "Lista de Movimientos";
            // 
            // _0028_ConsultaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 621);
            this.Controls.Add(this.pnlMovimientos);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.MenuConsulta);
            this.Name = "_0028_ConsultaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLupa)).EndInit();
            this.MenuConsulta.ResumeLayout(false);
            this.MenuConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.pnlMovimientos.ResumeLayout(false);
            this.pnlMovimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvGrilla;
        public System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox imgLupa;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBusqueda;
        public System.Windows.Forms.ToolStrip MenuConsulta;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton3;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton4;
        public System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Panel pnlMovimientos;
        private System.Windows.Forms.Label lblMovimientos;
    }
}