
namespace ParcialContabilidad
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TopMenuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.PictureBox();
            this.ContentSidePanel = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.PictureBox();
            this.btnCompras = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.PictureBox();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ContentContentPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ElipseSidePanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseContentPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTipEmpleado = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCliente = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEntradas = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSalidas = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInventario = new System.Windows.Forms.ToolTip(this.components);
            this.TopMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleado)).BeginInit();
            this.ContentSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventario)).BeginInit();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuPanel
            // 
            this.TopMenuPanel.Controls.Add(this.label1);
            this.TopMenuPanel.Controls.Add(this.pictureBox1);
            this.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMenuPanel.Name = "TopMenuPanel";
            this.TopMenuPanel.Size = new System.Drawing.Size(1235, 75);
            this.TopMenuPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Inventario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ParcialContabilidad.Properties.Resources.Close_Window__2_48px;
            this.pictureBox1.Location = new System.Drawing.Point(1173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.Controls.Add(this.btnEmpleado);
            this.SideMenuPanel.Controls.Add(this.ContentSidePanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 75);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(200, 678);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Image = global::ParcialContabilidad.Properties.Resources.employee;
            this.btnEmpleado.Location = new System.Drawing.Point(50, 24);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(100, 100);
            this.btnEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.TabStop = false;
            this.toolTipEmpleado.SetToolTip(this.btnEmpleado, "Vista Empleados");
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // ContentSidePanel
            // 
            this.ContentSidePanel.Controls.Add(this.btnCliente);
            this.ContentSidePanel.Controls.Add(this.btnCompras);
            this.ContentSidePanel.Controls.Add(this.btnVentas);
            this.ContentSidePanel.Controls.Add(this.btnInventario);
            this.ContentSidePanel.Location = new System.Drawing.Point(10, 10);
            this.ContentSidePanel.Name = "ContentSidePanel";
            this.ContentSidePanel.Size = new System.Drawing.Size(180, 658);
            this.ContentSidePanel.TabIndex = 5;
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Image = global::ParcialContabilidad.Properties.Resources.Client;
            this.btnCliente.Location = new System.Drawing.Point(40, 149);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 100);
            this.btnCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCliente.TabIndex = 1;
            this.btnCliente.TabStop = false;
            this.toolTipCliente.SetToolTip(this.btnCliente, "Vista Cliente");
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Image = global::ParcialContabilidad.Properties.Resources.Incoming;
            this.btnCompras.Location = new System.Drawing.Point(40, 277);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(100, 100);
            this.btnCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCompras.TabIndex = 2;
            this.btnCompras.TabStop = false;
            this.toolTipEntradas.SetToolTip(this.btnCompras, "Ver Entradas");
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Image = global::ParcialContabilidad.Properties.Resources.Outcoming;
            this.btnVentas.Location = new System.Drawing.Point(40, 405);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 100);
            this.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVentas.TabIndex = 3;
            this.btnVentas.TabStop = false;
            this.toolTipSalidas.SetToolTip(this.btnVentas, "Ver Salidas");
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.Image = global::ParcialContabilidad.Properties.Resources.box;
            this.btnInventario.Location = new System.Drawing.Point(40, 533);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(100, 100);
            this.btnInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInventario.TabIndex = 4;
            this.btnInventario.TabStop = false;
            this.toolTipInventario.SetToolTip(this.btnInventario, "Ver Inventario");
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ContentContentPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 75);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1035, 678);
            this.ContentPanel.TabIndex = 2;
            // 
            // ContentContentPanel
            // 
            this.ContentContentPanel.Location = new System.Drawing.Point(8, 10);
            this.ContentContentPanel.Name = "ContentContentPanel";
            this.ContentContentPanel.Size = new System.Drawing.Size(1015, 658);
            this.ContentContentPanel.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopMenuPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ElipseSidePanel
            // 
            this.ElipseSidePanel.ElipseRadius = 7;
            this.ElipseSidePanel.TargetControl = this.ContentSidePanel;
            // 
            // ElipseContentPanel
            // 
            this.ElipseContentPanel.ElipseRadius = 7;
            this.ElipseContentPanel.TargetControl = this.ContentContentPanel;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 753);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Controls.Add(this.TopMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMenuPanel.ResumeLayout(false);
            this.TopMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleado)).EndInit();
            this.ContentSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventario)).EndInit();
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenuPanel;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnEmpleado;
        private System.Windows.Forms.PictureBox btnVentas;
        private System.Windows.Forms.PictureBox btnCompras;
        private System.Windows.Forms.PictureBox btnCliente;
        private System.Windows.Forms.PictureBox btnInventario;
        private System.Windows.Forms.Panel ContentSidePanel;
        private Bunifu.Framework.UI.BunifuElipse ElipseSidePanel;
        private System.Windows.Forms.Panel ContentContentPanel;
        private Bunifu.Framework.UI.BunifuElipse ElipseContentPanel;
        private System.Windows.Forms.ToolTip toolTipEmpleado;
        private System.Windows.Forms.ToolTip toolTipCliente;
        private System.Windows.Forms.ToolTip toolTipEntradas;
        private System.Windows.Forms.ToolTip toolTipSalidas;
        private System.Windows.Forms.ToolTip toolTipInventario;
    }
}

