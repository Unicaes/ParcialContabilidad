
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPromedio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromedio.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPromedio.Location = new System.Drawing.Point(15, 208);
            this.dgvPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPromedio.MultiSelect = false;
            this.dgvPromedio.Name = "dgvPromedio";
            this.dgvPromedio.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedio.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPromedio.RowHeadersVisible = false;
            this.dgvPromedio.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPromedio.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto,
            this.cantidad_producto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducto.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducto.Location = new System.Drawing.Point(15, 27);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProducto.RowTemplate.Height = 24;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(724, 160);
            this.dgvProducto.TabIndex = 3;
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
            this.nombre_producto.Width = 200;
            // 
            // cantidad_producto
            // 
            this.cantidad_producto.HeaderText = "Cantidad";
            this.cantidad_producto.Name = "cantidad_producto";
            this.cantidad_producto.ReadOnly = true;
            this.cantidad_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.dgvPromedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_producto;
    }
}