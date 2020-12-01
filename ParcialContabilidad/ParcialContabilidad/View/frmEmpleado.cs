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
    public partial class frmEmpleado : Form
    {
        private ApiService api;
        
        public frmEmpleado()
        {
            this.TopLevel = false;
            InitializeComponent();
            this.BackColor = ColorPallete.LightBlue;
            api = new ApiService();

            LoadData();

            #region EstiloTxt

            this.NombretxtMaterial.LineIdleColor = ColorPallete.DarkBlue;
            this.NombretxtMaterial.LineFocusedColor = ColorPallete.Purple;
            this.NombretxtMaterial.LineMouseHoverColor = ColorPallete.Purple;
            this.NombretxtMaterial.ForeColor = ColorPallete.Light;

            this.ApellidotxtMaterial.LineIdleColor = ColorPallete.DarkBlue;
            this.ApellidotxtMaterial.LineFocusedColor = ColorPallete.Purple;
            this.ApellidotxtMaterial.LineMouseHoverColor = ColorPallete.Purple;
            this.ApellidotxtMaterial.ForeColor = ColorPallete.Light;

            this.TelefonotxtMaterial.LineIdleColor = ColorPallete.DarkBlue;
            this.TelefonotxtMaterial.LineFocusedColor = ColorPallete.Purple;
            this.TelefonotxtMaterial.LineMouseHoverColor = ColorPallete.Purple;
            this.TelefonotxtMaterial.ForeColor = ColorPallete.Light;

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
            var resp = await api.GetAll<Empleado>("Empleado");
            if (!resp.IsSuccess)
            {

            }
            ObservableCollection<Empleado> empleados = (ObservableCollection<Empleado>)resp.Result;
            for (int i = 0; i < empleados.Count; i++)
            {
                dgvClientes.Rows.Add(new String[] { empleados[i].id_empleado.ToString(), empleados[i].nombre, empleados[i].apellido,empleados[i].telefono.ToString() });
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado item = new Empleado
            {
                nombre = this.NombretxtMaterial.Text,
                apellido = this.ApellidotxtMaterial.Text,
                telefono = this.TelefonotxtMaterial.Text
            };
            await api.Post<Empleado>("Empleado", item);
            LoadData();

        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvClientes.SelectedRows.Count > 0))
            {
                MessageBox.Show("Debe seleccionar el registro a actualizar");
                return;
            }
            Empleado item = new Empleado
            {
                id_empleado = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value),
                nombre = this.NombretxtMaterial.Text,
                apellido = this.ApellidotxtMaterial.Text,
                telefono = this.TelefonotxtMaterial.Text
            };
            await api.Put<Empleado>("Empleado", item.id_empleado, item);
            LoadData();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvClientes.SelectedRows.Count > 0))
            {
                MessageBox.Show("Debe seleccionar el registro a actualizar");
                return;
            }
            var id_Empleado = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value);
            await api.Delete<Empleado>("Empleado", id_Empleado);
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
            this.ApellidotxtMaterial.Text = this.dgvClientes.CurrentRow.Cells[2].Value.ToString();
            this.TelefonotxtMaterial.Text = this.dgvClientes.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
