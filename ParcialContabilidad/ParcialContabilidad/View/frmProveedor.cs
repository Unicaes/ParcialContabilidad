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
    public partial class frmProveedor : Form
    {
        private ApiService api;
        public frmProveedor()
        {
            this.TopLevel = false;
            InitializeComponent();
            this.BackColor = ColorPallete.LightBlue;

            api = new ApiService();

            LoadData();

            this.NombretxtMaterial.LineIdleColor = ColorPallete.DarkBlue;
            this.NombretxtMaterial.LineFocusedColor = ColorPallete.Purple;
            this.NombretxtMaterial.LineMouseHoverColor = ColorPallete.Purple;
            this.NombretxtMaterial.ForeColor = ColorPallete.Light;

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
            var resp = await api.GetAll<Proveedor>("Proveedor");
            if (!resp.IsSuccess)
            {

            }
            ObservableCollection<Proveedor> proveedores = (ObservableCollection<Proveedor>)resp.Result;
            for (int i = 0; i < proveedores.Count; i++)
            {
                dgvClientes.Rows.Add(new String[] { proveedores[i].id_proveedor.ToString(), proveedores[i].nombre });
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Proveedor item = new Proveedor
            {
                nombre = this.NombretxtMaterial.Text
            };
            await api.Post<Proveedor>("Proveedor", item);
            LoadData();

        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvClientes.SelectedRows.Count>0))
            {
                MessageBox.Show("Debe seleccionar el registro a actualizar");
                return;
            }
            Proveedor item = new Proveedor
            {
                id_proveedor = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value),
                nombre = this.NombretxtMaterial.Text
            };
            await api.Put<Proveedor>("Proveedor",item.id_proveedor, item);
            LoadData();

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvClientes.SelectedRows.Count > 0))
            {
                MessageBox.Show("Debe seleccionar el registro a actualizar");
                return;
            }
            var id_proveedor = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value);
            await api.Delete<Proveedor>("Proveedor", id_proveedor);
            LoadData();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvClientes.ClearSelection();
            this.NombretxtMaterial.Text = String.Empty;
        }

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            this.NombretxtMaterial.Text = this.dgvClientes.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
