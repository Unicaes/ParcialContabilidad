
namespace ParcialContabilidad.View
{
    partial class frmCVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCVenta));
            this.CantCompraTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.vendComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFinalizarVenta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveVenta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.clienComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Compras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
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
            this.CantCompraTextBox.Location = new System.Drawing.Point(335, 123);
            this.CantCompraTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CantCompraTextBox.Name = "CantCompraTextBox";
            this.CantCompraTextBox.Size = new System.Drawing.Size(211, 33);
            this.CantCompraTextBox.TabIndex = 42;
            this.CantCompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CantCompraTextBox.OnValueChanged += new System.EventHandler(this.CantCompraTextBox_OnValueChanged);
            // 
            // vendComboBox
            // 
            this.vendComboBox.FormattingEnabled = true;
            this.vendComboBox.Location = new System.Drawing.Point(632, 130);
            this.vendComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vendComboBox.Name = "vendComboBox";
            this.vendComboBox.Size = new System.Drawing.Size(208, 24);
            this.vendComboBox.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 233);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(628, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Vendedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(332, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha de compra:";
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.FechaVenta,
            this.Precio,
            this.Vendedor});
            this.dgvVenta.Location = new System.Drawing.Point(19, 330);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.Size = new System.Drawing.Size(979, 245);
            this.dgvVenta.TabIndex = 46;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // FechaVenta
            // 
            this.FechaVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaVenta.HeaderText = "Fecha de venta";
            this.FechaVenta.MinimumWidth = 6;
            this.FechaVenta.Name = "FechaVenta";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.MinimumWidth = 6;
            this.Vendedor.Name = "Vendedor";
            // 
            // prodComboBox
            // 
            this.prodComboBox.FormattingEnabled = true;
            this.prodComboBox.Location = new System.Drawing.Point(16, 130);
            this.prodComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodComboBox.Name = "prodComboBox";
            this.prodComboBox.Size = new System.Drawing.Size(208, 24);
            this.prodComboBox.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Producto: ";
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.ActiveBorderThickness = 1;
            this.btnFinalizarVenta.ActiveCornerRadius = 20;
            this.btnFinalizarVenta.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnFinalizarVenta.ActiveForecolor = System.Drawing.Color.White;
            this.btnFinalizarVenta.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinalizarVenta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFinalizarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarVenta.BackgroundImage")));
            this.btnFinalizarVenta.ButtonText = "Finalizar venta";
            this.btnFinalizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizarVenta.IdleBorderThickness = 1;
            this.btnFinalizarVenta.IdleCornerRadius = 20;
            this.btnFinalizarVenta.IdleFillColor = System.Drawing.Color.White;
            this.btnFinalizarVenta.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizarVenta.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(423, 583);
            this.btnFinalizarVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(224, 59);
            this.btnFinalizarVenta.TabIndex = 47;
            this.btnFinalizarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnSaveVenta
            // 
            this.btnSaveVenta.ActiveBorderThickness = 1;
            this.btnSaveVenta.ActiveCornerRadius = 20;
            this.btnSaveVenta.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveVenta.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveVenta.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveVenta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSaveVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveVenta.BackgroundImage")));
            this.btnSaveVenta.ButtonText = "Agregar a lista";
            this.btnSaveVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveVenta.IdleBorderThickness = 1;
            this.btnSaveVenta.IdleCornerRadius = 20;
            this.btnSaveVenta.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveVenta.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveVenta.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveVenta.Location = new System.Drawing.Point(637, 215);
            this.btnSaveVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveVenta.Name = "btnSaveVenta";
            this.btnSaveVenta.Size = new System.Drawing.Size(204, 59);
            this.btnSaveVenta.TabIndex = 45;
            this.btnSaveVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveVenta.Click += new System.EventHandler(this.btnSaveCompra_Click);
            // 
            // clienComboBox
            // 
            this.clienComboBox.FormattingEnabled = true;
            this.clienComboBox.Location = new System.Drawing.Point(336, 236);
            this.clienComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienComboBox.Name = "clienComboBox";
            this.clienComboBox.Size = new System.Drawing.Size(208, 24);
            this.clienComboBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cliente:";
            // 
            // Compras
            // 
            this.Compras.AutoSize = true;
            this.Compras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.ForeColor = System.Drawing.Color.White;
            this.Compras.Location = new System.Drawing.Point(12, 9);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(71, 24);
            this.Compras.TabIndex = 54;
            this.Compras.Text = "Ventas";
            // 
            // frmCVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1015, 658);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clienComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodComboBox);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.btnSaveVenta);
            this.Controls.Add(this.CantCompraTextBox);
            this.Controls.Add(this.vendComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCVenta";
            this.Text = "r";
            this.Load += new System.EventHandler(this.frmCompraVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveVenta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CantCompraTextBox;
        private System.Windows.Forms.ComboBox vendComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVenta;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizarVenta;
        private System.Windows.Forms.ComboBox prodComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.ComboBox clienComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Compras;
    }
}