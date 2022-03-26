
namespace Presentacion.Core
{
    partial class _0023_Venta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarLinea = new FontAwesome.Sharp.IconButton();
            this.btnCambioCantidad = new FontAwesome.Sharp.IconButton();
            this.btnConsultaVentas = new FontAwesome.Sharp.IconButton();
            this.btnCancelarCompra = new FontAwesome.Sharp.IconButton();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.btnPendientes = new FontAwesome.Sharp.IconButton();
            this.txtMontoDescuento = new System.Windows.Forms.TextBox();
            this.nudPorcentajeDescuento = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.cmbCondicionIva = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDniCuitCuilCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtApyNomCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeDescuento)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(0, 143);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.RowHeadersWidth = 62;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(1214, 291);
            this.dgvGrilla.TabIndex = 6;
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.btnCancelarLinea);
            this.panel1.Controls.Add(this.btnCambioCantidad);
            this.panel1.Controls.Add(this.btnConsultaVentas);
            this.panel1.Controls.Add(this.btnCancelarCompra);
            this.panel1.Controls.Add(this.btnFacturar);
            this.panel1.Controls.Add(this.btnPendientes);
            this.panel1.Controls.Add(this.txtMontoDescuento);
            this.panel1.Controls.Add(this.nudPorcentajeDescuento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblDescuento);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 118);
            this.panel1.TabIndex = 5;
            // 
            // btnCancelarLinea
            // 
            this.btnCancelarLinea.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLinea.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarLinea.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarLinea.IconColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarLinea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarLinea.IconSize = 45;
            this.btnCancelarLinea.Location = new System.Drawing.Point(17, 66);
            this.btnCancelarLinea.Name = "btnCancelarLinea";
            this.btnCancelarLinea.Size = new System.Drawing.Size(192, 44);
            this.btnCancelarLinea.TabIndex = 34;
            this.btnCancelarLinea.Text = "Cancelar Linea";
            this.btnCancelarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarLinea.UseVisualStyleBackColor = true;
            this.btnCancelarLinea.Click += new System.EventHandler(this.btnCancelarLinea_Click_1);
            // 
            // btnCambioCantidad
            // 
            this.btnCambioCantidad.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioCantidad.ForeColor = System.Drawing.Color.Black;
            this.btnCambioCantidad.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnCambioCantidad.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnCambioCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambioCantidad.IconSize = 45;
            this.btnCambioCantidad.Location = new System.Drawing.Point(17, 14);
            this.btnCambioCantidad.Name = "btnCambioCantidad";
            this.btnCambioCantidad.Size = new System.Drawing.Size(192, 44);
            this.btnCambioCantidad.TabIndex = 33;
            this.btnCambioCantidad.Text = "Cambiar Cantidad";
            this.btnCambioCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambioCantidad.UseVisualStyleBackColor = true;
            this.btnCambioCantidad.Click += new System.EventHandler(this.btnCambioCantidad_Click);
            // 
            // btnConsultaVentas
            // 
            this.btnConsultaVentas.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaVentas.ForeColor = System.Drawing.Color.Black;
            this.btnConsultaVentas.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.btnConsultaVentas.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultaVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultaVentas.IconSize = 45;
            this.btnConsultaVentas.Location = new System.Drawing.Point(236, 66);
            this.btnConsultaVentas.Name = "btnConsultaVentas";
            this.btnConsultaVentas.Size = new System.Drawing.Size(192, 44);
            this.btnConsultaVentas.TabIndex = 32;
            this.btnConsultaVentas.Text = "Consulta Ventas";
            this.btnConsultaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultaVentas.UseVisualStyleBackColor = true;
            this.btnConsultaVentas.Click += new System.EventHandler(this.btnConsultaVentas_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCompra.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarCompra.IconColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCompra.IconSize = 45;
            this.btnCancelarCompra.Location = new System.Drawing.Point(236, 14);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(192, 44);
            this.btnCancelarCompra.TabIndex = 31;
            this.btnCancelarCompra.Text = "Cancelar Compra";
            this.btnCancelarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.Black;
            this.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnFacturar.IconColor = System.Drawing.Color.Green;
            this.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturar.IconSize = 45;
            this.btnFacturar.Location = new System.Drawing.Point(463, 66);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(192, 44);
            this.btnFacturar.TabIndex = 30;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // btnPendientes
            // 
            this.btnPendientes.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendientes.ForeColor = System.Drawing.Color.Black;
            this.btnPendientes.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnPendientes.IconColor = System.Drawing.Color.Goldenrod;
            this.btnPendientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPendientes.IconSize = 45;
            this.btnPendientes.Location = new System.Drawing.Point(463, 14);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(192, 44);
            this.btnPendientes.TabIndex = 29;
            this.btnPendientes.Text = "Pendientes";
            this.btnPendientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPendientes.UseVisualStyleBackColor = true;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // txtMontoDescuento
            // 
            this.txtMontoDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoDescuento.Enabled = false;
            this.txtMontoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMontoDescuento.Location = new System.Drawing.Point(1082, 43);
            this.txtMontoDescuento.Name = "txtMontoDescuento";
            this.txtMontoDescuento.Size = new System.Drawing.Size(122, 26);
            this.txtMontoDescuento.TabIndex = 6;
            this.txtMontoDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPorcentajeDescuento
            // 
            this.nudPorcentajeDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPorcentajeDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudPorcentajeDescuento.Location = new System.Drawing.Point(986, 43);
            this.nudPorcentajeDescuento.Name = "nudPorcentajeDescuento";
            this.nudPorcentajeDescuento.Size = new System.Drawing.Size(58, 26);
            this.nudPorcentajeDescuento.TabIndex = 5;
            this.nudPorcentajeDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPorcentajeDescuento.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPorcentajeDescuento.ValueChanged += new System.EventHandler(this.nudPorcentajeDescuento_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(1046, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "[%]";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(868, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 96);
            this.panel4.TabIndex = 18;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescuento.Location = new System.Drawing.Point(893, 47);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(87, 20);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(986, 75);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(218, 35);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(889, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSubTotal.Location = new System.Drawing.Point(986, 11);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(218, 26);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(899, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub-Total";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.pnlSuperior.Controls.Add(this.cmbTipoComprobante);
            this.pnlSuperior.Controls.Add(this.cmbCondicionIva);
            this.pnlSuperior.Controls.Add(this.label10);
            this.pnlSuperior.Controls.Add(this.cmbListaPrecio);
            this.pnlSuperior.Controls.Add(this.panel5);
            this.pnlSuperior.Controls.Add(this.btnBuscarArticulo);
            this.pnlSuperior.Controls.Add(this.txtCodigoArticulo);
            this.pnlSuperior.Controls.Add(this.label9);
            this.pnlSuperior.Controls.Add(this.panel3);
            this.pnlSuperior.Controls.Add(this.label8);
            this.pnlSuperior.Controls.Add(this.txtDireccionCliente);
            this.pnlSuperior.Controls.Add(this.label7);
            this.pnlSuperior.Controls.Add(this.label6);
            this.pnlSuperior.Controls.Add(this.txtDniCuitCuilCliente);
            this.pnlSuperior.Controls.Add(this.panel2);
            this.pnlSuperior.Controls.Add(this.btnBuscarCliente);
            this.pnlSuperior.Controls.Add(this.txtApyNomCliente);
            this.pnlSuperior.Controls.Add(this.label5);
            this.pnlSuperior.Controls.Add(this.dtpFechaFactura);
            this.pnlSuperior.Controls.Add(this.label4);
            this.pnlSuperior.Controls.Add(this.btnBuscarEmpleado);
            this.pnlSuperior.Controls.Add(this.txtVendedor);
            this.pnlSuperior.Controls.Add(this.label3);
            this.pnlSuperior.Controls.Add(this.txtNumeroFactura);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.ForeColor = System.Drawing.Color.White;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1214, 143);
            this.pnlSuperior.TabIndex = 4;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuperior_Paint);
            // 
            // cmbTipoComprobante
            // 
            this.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Location = new System.Drawing.Point(17, 5);
            this.cmbTipoComprobante.Name = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size = new System.Drawing.Size(130, 24);
            this.cmbTipoComprobante.TabIndex = 29;
            // 
            // cmbCondicionIva
            // 
            this.cmbCondicionIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCondicionIva.FormattingEnabled = true;
            this.cmbCondicionIva.Location = new System.Drawing.Point(936, 65);
            this.cmbCondicionIva.Name = "cmbCondicionIva";
            this.cmbCondicionIva.Size = new System.Drawing.Size(163, 24);
            this.cmbCondicionIva.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(835, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Lista de Precio";
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(938, 107);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(245, 24);
            this.cmbListaPrecio.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(402, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 39);
            this.panel5.TabIndex = 21;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscarArticulo.Location = new System.Drawing.Point(358, 102);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(32, 31);
            this.btnBuscarArticulo.TabIndex = 20;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoArticulo.Location = new System.Drawing.Point(90, 105);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(262, 29);
            this.txtCodigoArticulo.TabIndex = 19;
            this.txtCodigoArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoArticulo_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Código";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(12, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 4);
            this.panel3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(845, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Condicion de Iva";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionCliente.BackColor = System.Drawing.Color.White;
            this.txtDireccionCliente.Location = new System.Drawing.Point(90, 68);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(694, 20);
            this.txtDireccionCliente.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dni/Cuit/Cuil";
            // 
            // txtDniCuitCuilCliente
            // 
            this.txtDniCuitCuilCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDniCuitCuilCliente.BackColor = System.Drawing.Color.White;
            this.txtDniCuitCuilCliente.Location = new System.Drawing.Point(936, 42);
            this.txtDniCuitCuilCliente.Name = "txtDniCuitCuilCliente";
            this.txtDniCuitCuilCliente.ReadOnly = true;
            this.txtDniCuitCuilCliente.Size = new System.Drawing.Size(163, 20);
            this.txtDniCuitCuilCliente.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 4);
            this.panel2.TabIndex = 10;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(1131, 41);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(52, 46);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtApyNomCliente
            // 
            this.txtApyNomCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApyNomCliente.BackColor = System.Drawing.Color.White;
            this.txtApyNomCliente.Location = new System.Drawing.Point(90, 42);
            this.txtApyNomCliente.Name = "txtApyNomCliente";
            this.txtApyNomCliente.ReadOnly = true;
            this.txtApyNomCliente.Size = new System.Drawing.Size(694, 20);
            this.txtApyNomCliente.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cliente";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(1081, 8);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaFactura.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1038, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(993, 5);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarEmpleado.TabIndex = 4;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendedor.BackColor = System.Drawing.Color.White;
            this.txtVendedor.Location = new System.Drawing.Point(563, 8);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(369, 20);
            this.txtVendedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendedor";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.Color.White;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(179, 5);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(76, 22);
            this.txtNumeroFactura.TabIndex = 1;
            // 
            // _0023_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 552);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSuperior);
            this.MinimumSize = new System.Drawing.Size(1230, 591);
            this.Name = "_0023_Venta";
            this.Text = "_0023_Venta";
            this.Activated += new System.EventHandler(this._0023_Venta_Activated);
            this.Load += new System.EventHandler(this._0023_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeDescuento)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMontoDescuento;
        private System.Windows.Forms.NumericUpDown nudPorcentajeDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDniCuitCuilCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtApyNomCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private FontAwesome.Sharp.IconButton btnCancelarLinea;
        private FontAwesome.Sharp.IconButton btnCambioCantidad;
        private FontAwesome.Sharp.IconButton btnConsultaVentas;
        private FontAwesome.Sharp.IconButton btnCancelarCompra;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private FontAwesome.Sharp.IconButton btnPendientes;
        private System.Windows.Forms.ComboBox cmbCondicionIva;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
    }
}