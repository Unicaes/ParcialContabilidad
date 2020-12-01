using ApiContabilidad.Models;
using ParcialContabilidad.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialContabilidad.View
{
    public partial class frmCliente : Form
    {
        private ApiService api;
        public frmCliente()
        {
            this.TopLevel = false;
            InitializeComponent();

            api = new ApiService();
            LoadData();
            this.BackColor = ColorPallete.LightBlue;
            #region EstiloTxt

            this.NombretxtMaterial.LineIdleColor = ColorPallete.DarkBlue;
            this.NombretxtMaterial.LineFocusedColor = ColorPallete.Purple;
            this.NombretxtMaterial.LineMouseHoverColor = ColorPallete.Purple;
            this.NombretxtMaterial.ForeColor = ColorPallete.Light;
            this.ApellidotxtMaterial.LineIdleColor = ColorPallete.DarkBlue;
            this.ApellidotxtMaterial.LineFocusedColor = ColorPallete.Purple;
            this.ApellidotxtMaterial.LineMouseHoverColor = ColorPallete.Purple;
            this.ApellidotxtMaterial.ForeColor = ColorPallete.Light;

            #endregion
            #region EstiloBtn

            this.btnGuardar.ActiveFillColor = ColorPallete.DarkBlue;
            this.btnGuardar.ActiveForecolor = ColorPallete.Light;
            this.btnGuardar.ActiveLineColor = ColorPallete.Light;
            this.btnGuardar.IdleFillColor = ColorPallete.Light;
            this.btnGuardar.IdleForecolor = ColorPallete.DarkBlue;
            this.btnGuardar.IdleLineColor = ColorPallete.DarkBlue;

            this.btnActualizar.ActiveFillColor = ColorPallete.DarkBlue;
            this.btnActualizar.ActiveForecolor = ColorPallete.Light;
            this.btnActualizar.ActiveLineColor = ColorPallete.Light;
            this.btnActualizar.IdleFillColor = ColorPallete.Light;
            this.btnActualizar.IdleForecolor = ColorPallete.DarkBlue;
            this.btnActualizar.IdleLineColor = ColorPallete.DarkBlue;

            this.btnEliminar.ActiveFillColor = ColorPallete.DarkBlue;
            this.btnEliminar.ActiveForecolor = ColorPallete.Light;
            this.btnEliminar.ActiveLineColor = ColorPallete.Light;
            this.btnEliminar.IdleFillColor = ColorPallete.Light;
            this.btnEliminar.IdleForecolor = ColorPallete.DarkBlue;
            this.btnEliminar.IdleLineColor = ColorPallete.DarkBlue;

            this.btnLimpiar.ActiveFillColor = ColorPallete.DarkBlue;
            this.btnLimpiar.ActiveForecolor = ColorPallete.Light;
            this.btnLimpiar.ActiveLineColor = ColorPallete.Light;
            this.btnLimpiar.IdleFillColor = ColorPallete.Light;
            this.btnLimpiar.IdleForecolor = ColorPallete.DarkBlue;
            this.btnLimpiar.IdleLineColor = ColorPallete.DarkBlue; 
            #endregion
        }
        private async void LoadData()
        {
            this.dgvClientes.Rows.Clear();
            this.dgvClientes.Refresh();
            var resp = await api.GetAll<Cliente>("cliente");
            if (!resp.IsSuccess)
            {

            }
            ObservableCollection<Cliente> clientes = (ObservableCollection<Cliente>)resp.Result;
            for (int i = 0; i < clientes.Count; i++)
            {
                dgvClientes.Rows.Add(new String[]{clientes[i].id_cliente.ToString(), clientes[i].nombre, clientes[i].apellido });
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente item = new Cliente
            {
                nombre = this.NombretxtMaterial.Text,
                apellido = this.ApellidotxtMaterial.Text
            };
            await api.Post<Cliente>("Cliente", item);
            LoadData();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvClientes.SelectedRows.Count > 0))
            {
                MessageBox.Show("Debe seleccionar el registro a actualizar");
                return;
            }
            Cliente item = new Cliente
            {
                id_cliente = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value),
                nombre = this.NombretxtMaterial.Text,
                apellido = this.ApellidotxtMaterial.Text
            };
            await api.Put<Cliente>("Cliente", item.id_cliente, item);
            LoadData();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvClientes.SelectedRows.Count > 0))
            {
                MessageBox.Show("Debe seleccionar el registro a actualizar");
                return;
            }
            var id_Cliente = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value);
            await api.Delete<Cliente>("Cliente", id_Cliente);
            LoadData();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvClientes.ClearSelection();
            this.NombretxtMaterial.Text = String.Empty;
        }
    }
}
