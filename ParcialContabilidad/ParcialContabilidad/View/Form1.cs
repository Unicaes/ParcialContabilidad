using ParcialContabilidad.Service;
using ParcialContabilidad.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialContabilidad
{
    public partial class Form1 : Form
    {
        Form item;
        public Form1()
        {
            InitializeComponent();
            this.TopMenuPanel.BackColor=  ColorPallete.DarkBlue;
            this.SideMenuPanel.BackColor = ColorPallete.LightBlue;
            this.ContentPanel.BackColor = ColorPallete.Purple;
            this.ContentSidePanel.BackColor = ColorPallete.SemiDarkBlue;
            this.btnEmpleado.BackColor = ColorPallete.SemiDarkBlue;
            this.ContentContentPanel.BackColor = ColorPallete.LightBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            item = new frmEmpleado();
            ContentContentPanel.Controls.Clear();
            ContentContentPanel.Controls.Add(item);
            item.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            item = new frmCliente();
            ContentContentPanel.Controls.Clear();
            ContentContentPanel.Controls.Add(item);
            item.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            item = new frmCompraVenta();
            ContentContentPanel.Controls.Clear();
            ContentContentPanel.Controls.Add(item);
            item.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            item = new frmCVenta();
            ContentContentPanel.Controls.Clear();
            ContentContentPanel.Controls.Add(item);
            item.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            item = new frmInventario();
            ContentContentPanel.Controls.Clear();
            ContentContentPanel.Controls.Add(item);
            item.Show();
        }
    }
}
