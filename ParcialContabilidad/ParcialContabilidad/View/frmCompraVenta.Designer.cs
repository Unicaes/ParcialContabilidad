
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
            this.btnNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PrecioCompraTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CantCompraTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.provComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCompra = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCompra = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.prodComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNombre
            // 
            this.btnNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNombre.ForeColor = System.Drawing.Color.White;
            this.btnNombre.HintForeColor = System.Drawing.Color.White;
            this.btnNombre.HintText = "Nombre del producto";
            this.btnNombre.isPassword = false;
            this.btnNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.btnNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.btnNombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btnNombre.LineThickness = 3;
            this.btnNombre.Location = new System.Drawing.Point(12, 100);
            this.btnNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(157, 27);
            this.btnNombre.TabIndex = 44;
            this.btnNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.PrecioCompraTextBox.Location = new System.Drawing.Point(399, 100);
            this.PrecioCompraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioCompraTextBox.Name = "PrecioCompraTextBox";
            this.PrecioCompraTextBox.Size = new System.Drawing.Size(158, 27);
            this.PrecioCompraTextBox.TabIndex = 43;
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
            this.CantCompraTextBox.Location = new System.Drawing.Point(201, 100);
            this.CantCompraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantCompraTextBox.Name = "CantCompraTextBox";
            this.CantCompraTextBox.Size = new System.Drawing.Size(158, 27);
            this.CantCompraTextBox.TabIndex = 42;
            this.CantCompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // provComboBox
            // 
            this.provComboBox.FormattingEnabled = true;
            this.provComboBox.Location = new System.Drawing.Point(399, 177);
            this.provComboBox.Name = "provComboBox";
            this.provComboBox.Size = new System.Drawing.Size(157, 21);
            this.provComboBox.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(396, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 37;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(198, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha de compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "Producto nuevo: ";
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
            this.btnSaveCompra.ButtonText = "Agregar a lista";
            this.btnSaveCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveCompra.IdleBorderThickness = 1;
            this.btnSaveCompra.IdleCornerRadius = 20;
            this.btnSaveCompra.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveCompra.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCompra.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCompra.Location = new System.Drawing.Point(565, 100);
            this.btnSaveCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCompra.Name = "btnSaveCompra";
            this.btnSaveCompra.Size = new System.Drawing.Size(153, 42);
            this.btnSaveCompra.TabIndex = 45;
            this.btnSaveCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCompra.Click += new System.EventHandler(this.btnSaveCompra_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.FechaCompra,
            this.Precio,
            this.Proveedor});
            this.dgvCompra.Location = new System.Drawing.Point(14, 268);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(734, 199);
            this.dgvCompra.TabIndex = 46;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.ActiveBorderThickness = 1;
            this.btnFinalizarCompra.ActiveCornerRadius = 20;
            this.btnFinalizarCompra.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnFinalizarCompra.ActiveForecolor = System.Drawing.Color.White;
            this.btnFinalizarCompra.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinalizarCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFinalizarCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarCompra.BackgroundImage")));
            this.btnFinalizarCompra.ButtonText = "Finalizar compra";
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizarCompra.IdleBorderThickness = 1;
            this.btnFinalizarCompra.IdleCornerRadius = 20;
            this.btnFinalizarCompra.IdleFillColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizarCompra.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(317, 474);
            this.btnFinalizarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(168, 48);
            this.btnFinalizarCompra.TabIndex = 47;
            this.btnFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Nuevo proveedor";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton22.Location = new System.Drawing.Point(563, 163);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(153, 46);
            this.bunifuThinButton22.TabIndex = 48;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Producto nuevo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // prodComboBox
            // 
            this.prodComboBox.Enabled = false;
            this.prodComboBox.FormattingEnabled = true;
            this.prodComboBox.Location = new System.Drawing.Point(12, 177);
            this.prodComboBox.Name = "prodComboBox";
            this.prodComboBox.Size = new System.Drawing.Size(157, 21);
            this.prodComboBox.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 14);
            this.label7.TabIndex = 51;
            this.label7.Text = "Producto exisente: ";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // FechaCompra
            // 
            this.FechaCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaCompra.HeaderText = "Fecha de compra";
            this.FechaCompra.Name = "FechaCompra";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // frmCompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodComboBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnSaveCompra);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.PrecioCompraTextBox);
            this.Controls.Add(this.CantCompraTextBox);
            this.Controls.Add(this.provComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCompraVenta";
            this.Text = "frmCompraVenta";
            this.Load += new System.EventHandler(this.frmCompraVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveCompra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PrecioCompraTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CantCompraTextBox;
        private System.Windows.Forms.ComboBox provComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompra;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizarCompra;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox prodComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
    }
}