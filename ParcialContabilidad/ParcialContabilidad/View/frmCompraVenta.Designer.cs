
namespace ParcialContabilidad.View
{
    partial class frmCompraVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraVenta));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PrecioCompraTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CantCompraTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DetalleTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompra = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PrecioVentaTexBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CantVentaTexBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveCompra = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveVenta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveCompra);
            this.splitContainer1.Panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.splitContainer1.Panel1.Controls.Add(this.PrecioCompraTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.CantCompraTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.DetalleTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCompra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveVenta);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuThinButton23);
            this.splitContainer1.Panel2.Controls.Add(this.PrecioVentaTexBox);
            this.splitContainer1.Panel2.Controls.Add(this.CantVentaTexBox);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox3);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuMaterialTextbox5);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(761, 535);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 0;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "Nombre del producto";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(13, 90);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(284, 27);
            this.bunifuMaterialTextbox1.TabIndex = 30;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PrecioCompraTextBox
            // 
            this.PrecioCompraTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrecioCompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PrecioCompraTextBox.ForeColor = System.Drawing.Color.White;
            this.PrecioCompraTextBox.HintForeColor = System.Drawing.Color.White;
            this.PrecioCompraTextBox.HintText = "0.00";
            this.PrecioCompraTextBox.isPassword = false;
            this.PrecioCompraTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.PrecioCompraTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.PrecioCompraTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PrecioCompraTextBox.LineThickness = 3;
            this.PrecioCompraTextBox.Location = new System.Drawing.Point(13, 310);
            this.PrecioCompraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioCompraTextBox.Name = "PrecioCompraTextBox";
            this.PrecioCompraTextBox.Size = new System.Drawing.Size(284, 27);
            this.PrecioCompraTextBox.TabIndex = 29;
            this.PrecioCompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CantCompraTextBox
            // 
            this.CantCompraTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CantCompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CantCompraTextBox.ForeColor = System.Drawing.Color.White;
            this.CantCompraTextBox.HintForeColor = System.Drawing.Color.White;
            this.CantCompraTextBox.HintText = "0";
            this.CantCompraTextBox.isPassword = false;
            this.CantCompraTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.CantCompraTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.CantCompraTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CantCompraTextBox.LineThickness = 3;
            this.CantCompraTextBox.Location = new System.Drawing.Point(13, 161);
            this.CantCompraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantCompraTextBox.Name = "CantCompraTextBox";
            this.CantCompraTextBox.Size = new System.Drawing.Size(284, 27);
            this.CantCompraTextBox.TabIndex = 28;
            this.CantCompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 393);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // DetalleTextBox
            // 
            this.DetalleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DetalleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DetalleTextBox.ForeColor = System.Drawing.Color.White;
            this.DetalleTextBox.HintForeColor = System.Drawing.Color.White;
            this.DetalleTextBox.HintText = "Ingrese una corta descripción";
            this.DetalleTextBox.isPassword = false;
            this.DetalleTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.DetalleTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.DetalleTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.DetalleTextBox.LineThickness = 3;
            this.DetalleTextBox.Location = new System.Drawing.Point(13, 450);
            this.DetalleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DetalleTextBox.Name = "DetalleTextBox";
            this.DetalleTextBox.Size = new System.Drawing.Size(284, 27);
            this.DetalleTextBox.TabIndex = 24;
            this.DetalleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 433);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha de compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Producto:  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.ActiveBorderThickness = 1;
            this.btnCompra.ActiveCornerRadius = 20;
            this.btnCompra.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompra.ActiveForecolor = System.Drawing.Color.White;
            this.btnCompra.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompra.BackgroundImage")));
            this.btnCompra.ButtonText = "Compra";
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompra.IdleBorderThickness = 1;
            this.btnCompra.IdleCornerRadius = 20;
            this.btnCompra.IdleFillColor = System.Drawing.Color.White;
            this.btnCompra.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnCompra.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnCompra.Location = new System.Drawing.Point(108, -1);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(136, 33);
            this.btnCompra.TabIndex = 17;
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompra.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PrecioVentaTexBox
            // 
            this.PrecioVentaTexBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrecioVentaTexBox.Enabled = false;
            this.PrecioVentaTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PrecioVentaTexBox.ForeColor = System.Drawing.Color.White;
            this.PrecioVentaTexBox.HintForeColor = System.Drawing.Color.White;
            this.PrecioVentaTexBox.HintText = "0.00";
            this.PrecioVentaTexBox.isPassword = false;
            this.PrecioVentaTexBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.PrecioVentaTexBox.LineIdleColor = System.Drawing.Color.Gray;
            this.PrecioVentaTexBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PrecioVentaTexBox.LineThickness = 3;
            this.PrecioVentaTexBox.Location = new System.Drawing.Point(28, 310);
            this.PrecioVentaTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioVentaTexBox.Name = "PrecioVentaTexBox";
            this.PrecioVentaTexBox.Size = new System.Drawing.Size(284, 27);
            this.PrecioVentaTexBox.TabIndex = 41;
            this.PrecioVentaTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CantVentaTexBox
            // 
            this.CantVentaTexBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CantVentaTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CantVentaTexBox.ForeColor = System.Drawing.Color.White;
            this.CantVentaTexBox.HintForeColor = System.Drawing.Color.White;
            this.CantVentaTexBox.HintText = "0";
            this.CantVentaTexBox.isPassword = false;
            this.CantVentaTexBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.CantVentaTexBox.LineIdleColor = System.Drawing.Color.Gray;
            this.CantVentaTexBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CantVentaTexBox.LineThickness = 3;
            this.CantVentaTexBox.Location = new System.Drawing.Point(28, 161);
            this.CantVentaTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantVentaTexBox.Name = "CantVentaTexBox";
            this.CantVentaTexBox.Size = new System.Drawing.Size(284, 27);
            this.CantVentaTexBox.TabIndex = 40;
            this.CantVentaTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(28, 393);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 21);
            this.comboBox3.TabIndex = 39;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.HintText = "Ingrese una corta descripción";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(28, 450);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(284, 27);
            this.bunifuMaterialTextbox5.TabIndex = 36;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(26, 96);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(231, 21);
            this.comboBox4.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 14);
            this.label12.TabIndex = 30;
            this.label12.Text = "Producto:  ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(28, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 14);
            this.label11.TabIndex = 31;
            this.label11.Text = "Fecha de compra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 433);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 32;
            this.label10.Text = "Detalle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 14);
            this.label7.TabIndex = 35;
            this.label7.Text = "Proveedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 14);
            this.label9.TabIndex = 33;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Precio:";
            // 
            // btnSaveCompra
            // 
            this.btnSaveCompra.ActiveBorderThickness = 1;
            this.btnSaveCompra.ActiveCornerRadius = 20;
            this.btnSaveCompra.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveCompra.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveCompra.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCompra.BackgroundImage")));
            this.btnSaveCompra.ButtonText = "Guardar";
            this.btnSaveCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveCompra.IdleBorderThickness = 1;
            this.btnSaveCompra.IdleCornerRadius = 20;
            this.btnSaveCompra.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveCompra.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCompra.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCompra.Location = new System.Drawing.Point(108, 496);
            this.btnSaveCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCompra.Name = "btnSaveCompra";
            this.btnSaveCompra.Size = new System.Drawing.Size(136, 33);
            this.btnSaveCompra.TabIndex = 31;
            this.btnSaveCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveVenta
            // 
            this.btnSaveVenta.ActiveBorderThickness = 1;
            this.btnSaveVenta.ActiveCornerRadius = 20;
            this.btnSaveVenta.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveVenta.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveVenta.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveVenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveVenta.BackgroundImage")));
            this.btnSaveVenta.ButtonText = "Guardar";
            this.btnSaveVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveVenta.IdleBorderThickness = 1;
            this.btnSaveVenta.IdleCornerRadius = 20;
            this.btnSaveVenta.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveVenta.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveVenta.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveVenta.Location = new System.Drawing.Point(137, 496);
            this.btnSaveVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveVenta.Name = "btnSaveVenta";
            this.btnSaveVenta.Size = new System.Drawing.Size(136, 33);
            this.btnSaveVenta.TabIndex = 32;
            this.btnSaveVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Venta";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton23.Location = new System.Drawing.Point(137, -1);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(136, 33);
            this.bunifuThinButton23.TabIndex = 33;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCompraVenta";
            this.Text = "frmCompraVenta";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DetalleTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PrecioCompraTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CantCompraTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PrecioVentaTexBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CantVentaTexBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveCompra;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveVenta;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}