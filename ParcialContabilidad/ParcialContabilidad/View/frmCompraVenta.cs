using ApiContabilidad.Models;
using ParcialContabilidad.Model;
using ParcialContabilidad.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialContabilidad.View
{
    public partial class frmCompraVenta : Form
    {
        private ApiService api;

        public frmCompraVenta()
        {

            this.TopLevel = false;
            InitializeComponent();
            this.BackColor = ColorPallete.LightBlue;
            api = new ApiService();


        }
        private async void LoadData()
        {
            this.dgvClientes.Rows.Clear();
            this.dgvClientes.Refresh();
            var response = await api.GetAll<Cliente>("Cliente");
            if (!response.IsSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            ObservableCollection<Cliente> clientes = (ObservableCollection<Cliente>)response.Result;
            for (int i = 0; i < clientes.Count; i++)
            {
                dgvClientes.Rows.Add(new string[] { clientes[i].id_cliente.ToString(), clientes[i].nombre, clientes[i].apellido });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {

        }

        private void frmCompraVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
