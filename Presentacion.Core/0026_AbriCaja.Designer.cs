
namespace Presentacion.Core
{
    partial class _0026_AbriCaja
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
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.MenuConsulta = new System.Windows.Forms.ToolStrip();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton3 = new FontAwesome.Sharp.IconToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.MenuConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMonto
            // 
            this.nudMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudMonto.Location = new System.Drawing.Point(164, 133);
            this.nudMonto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(196, 26);
            this.nudMonto.TabIndex = 11;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(160, 100);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(159, 20);
            this.lblDescuento.TabIndex = 10;
            this.lblDescuento.Text = "Monto de Apertura";
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.MenuConsulta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuConsulta.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MenuConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconToolStripButton1,
            this.iconToolStripButton2,
            this.iconToolStripButton3});
            this.MenuConsulta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuConsulta.Location = new System.Drawing.Point(0, 0);
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(509, 52);
            this.MenuConsulta.TabIndex = 9;
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton1.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Green;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(50, 49);
            this.iconToolStripButton1.Text = "Grabar";
            this.iconToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton1.Click += new System.EventHandler(this.iconToolStripButton1_Click);
            // 
            // iconToolStripButton2
            // 
            this.iconToolStripButton2.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton2.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.iconToolStripButton2.IconColor = System.Drawing.Color.Yellow;
            this.iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton2.Name = "iconToolStripButton2";
            this.iconToolStripButton2.Size = new System.Drawing.Size(52, 49);
            this.iconToolStripButton2.Text = "Limpiar";
            this.iconToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton2.Click += new System.EventHandler(this.iconToolStripButton2_Click);
            // 
            // iconToolStripButton3
            // 
            this.iconToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.iconToolStripButton3.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconToolStripButton3.ForeColor = System.Drawing.Color.White;
            this.iconToolStripButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconToolStripButton3.IconColor = System.Drawing.Color.Red;
            this.iconToolStripButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton3.Name = "iconToolStripButton3";
            this.iconToolStripButton3.Size = new System.Drawing.Size(35, 49);
            this.iconToolStripButton3.Text = "Salir";
            this.iconToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconToolStripButton3.Click += new System.EventHandler(this.iconToolStripButton3_Click);
            // 
            // _0026_AbriCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(509, 229);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.MenuConsulta);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 268);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(525, 268);
            this.Name = "_0026_AbriCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abri Caja";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.MenuConsulta.ResumeLayout(false);
            this.MenuConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label lblDescuento;
        public System.Windows.Forms.ToolStrip MenuConsulta;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton3;
    }
}