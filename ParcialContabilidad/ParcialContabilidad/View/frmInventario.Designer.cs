
namespace ParcialContabilidad.View
{
    partial class frmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPromedio = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUtilidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostoVenta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalidas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromedio
            // 
            this.dgvPromedio.AllowUserToAddRows = false;
            this.dgvPromedio.AllowUserToDeleteRows = false;
            this.dgvPromedio.AllowUserToResizeColumns = false;
            this.dgvPromedio.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPromedio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.concepto,
            this.entradas,
            this.salidas,
            this.existencias,
            this.costo_unitario,
            this.costo_promedio,
            this.debe,
            this.haber,
            this.saldo});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromedio.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPromedio.Location = new System.Drawing.Point(11, 256);
            this.dgvPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPromedio.MultiSelect = false;
            this.dgvPromedio.Name = "dgvPromedio";
            this.dgvPromedio.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedio.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPromedio.RowHeadersVisible = false;
            this.dgvPromedio.RowHeadersWidth = 51;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPromedio.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPromedio.RowTemplate.Height = 24;
            this.dgvPromedio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromedio.Size = new System.Drawing.Size(724, 208);
            this.dgvPromedio.TabIndex = 2;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // concepto
            // 
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            this.concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.concepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // entradas
            // 
            this.entradas.HeaderText = "Entradas";
            this.entradas.Name = "entradas";
            this.entradas.ReadOnly = true;
            this.entradas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.entradas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // salidas
            // 
            this.salidas.HeaderText = "Salidas";
            this.salidas.Name = "salidas";
            this.salidas.ReadOnly = true;
            this.salidas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salidas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // existencias
            // 
            this.existencias.HeaderText = "Existencias";
            this.existencias.Name = "existencias";
            this.existencias.ReadOnly = true;
            this.existencias.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.existencias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // costo_unitario
            // 
            this.costo_unitario.HeaderText = "Costo Unitario";
            this.costo_unitario.Name = "costo_unitario";
            this.costo_unitario.ReadOnly = true;
            this.costo_unitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.costo_unitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // costo_promedio
            // 
            this.costo_promedio.HeaderText = "Costo Promedio";
            this.costo_promedio.Name = "costo_promedio";
            this.costo_promedio.ReadOnly = true;
            this.costo_promedio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.costo_promedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // debe
            // 
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            this.debe.ReadOnly = true;
            this.debe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.debe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // haber
            // 
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            this.haber.ReadOnly = true;
            this.haber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.haber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AllowUserToResizeColumns = false;
            this.dgvProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto});
            this.dgvProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducto.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvProducto.Location = new System.Drawing.Point(15, 27);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvProducto.RowTemplate.Height = 24;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(405, 205);
            this.dgvProducto.TabIndex = 3;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducto_CellClick);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre de Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre_producto.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(528, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Utilidad:";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUtilidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUtilidad.Enabled = false;
            this.txtUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtUtilidad.HintForeColor = System.Drawing.Color.White;
            this.txtUtilidad.HintText = "";
            this.txtUtilidad.isPassword = false;
            this.txtUtilidad.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txtUtilidad.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.txtUtilidad.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.txtUtilidad.LineThickness = 3;
            this.txtUtilidad.Location = new System.Drawing.Point(604, 185);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(128, 33);
            this.txtUtilidad.TabIndex = 8;
            this.txtUtilidad.Text = "$ 0.00";
            this.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(478, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Costo de Venta:";
            // 
            // txtCostoVenta
            // 
            this.txtCostoVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCostoVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCostoVenta.Enabled = false;
            this.txtCostoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoVenta.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtCostoVenta.HintForeColor = System.Drawing.Color.White;
            this.txtCostoVenta.HintText = "";
            this.txtCostoVenta.isPassword = false;
            this.txtCostoVenta.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txtCostoVenta.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.txtCostoVenta.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCostoVenta.LineThickness = 3;
            this.txtCostoVenta.Location = new System.Drawing.Point(604, 134);
            this.txtCostoVenta.Name = "txtCostoVenta";
            this.txtCostoVenta.Size = new System.Drawing.Size(128, 33);
            this.txtCostoVenta.TabIndex = 10;
            this.txtCostoVenta.Text = "$ 0.00";
            this.txtCostoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(478, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Salidas Totales:";
            // 
            // txtSalidas
            // 
            this.txtSalidas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSalidas.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSalidas.Enabled = false;
            this.txtSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalidas.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtSalidas.HintForeColor = System.Drawing.Color.White;
            this.txtSalidas.HintText = "";
            this.txtSalidas.isPassword = false;
            this.txtSalidas.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txtSalidas.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.txtSalidas.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.txtSalidas.LineThickness = 3;
            this.txtSalidas.Location = new System.Drawing.Point(604, 83);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(128, 33);
            this.txtSalidas.TabIndex = 12;
            this.txtSalidas.Text = "0";
            this.txtSalidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(463, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Entradas Totales:";
            // 
            // txtEntradas
            // 
            this.txtEntradas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEntradas.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEntradas.Enabled = false;
            this.txtEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradas.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtEntradas.HintForeColor = System.Drawing.Color.White;
            this.txtEntradas.HintText = "";
            this.txtEntradas.isPassword = false;
            this.txtEntradas.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txtEntradas.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.txtEntradas.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.txtEntradas.LineThickness = 3;
            this.txtEntradas.Location = new System.Drawing.Point(604, 39);
            this.txtEntradas.Name = "txtEntradas";
            this.txtEntradas.Size = new System.Drawing.Size(128, 33);
            this.txtEntradas.TabIndex = 14;
            this.txtEntradas.Text = "0";
            this.txtEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostoVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.dgvPromedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUtilidad;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCostoVenta;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSalidas;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEntradas;
    }
}