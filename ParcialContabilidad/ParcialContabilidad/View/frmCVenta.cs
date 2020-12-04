using ApiContabilidad.Models;
using ParcialContabilidad.View;
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
    public partial class frmCVenta : Form
    {
        private ApiService api;
        List<Detalle_Venta> listaProducto = new List<Detalle_Venta>();
        ObservableCollection<Empleado> obsEmpleado;
        ObservableCollection<Producto> obsProducto;
        ObservableCollection<Cliente> obsCliente;
        Venta venta;
        frmProveedor frmProv = new frmProveedor();
        public frmCVenta()
        {

            this.TopLevel = false;
            InitializeComponent();
            this.BackColor = ColorPallete.LightBlue;
            api = new ApiService();
            LoadProveedor();

        }
        private async void LoadProveedor()
        {
            var response = await api.GetAll<Empleado>("empleado");
            var responses = await api.GetAll<Producto>("producto");
            var responses2 = await api.GetAll<Cliente>("cliente");
            this.prodComboBox.Items.Clear();
            this.vendComboBox.Items.Clear();
            this.vendComboBox.Refresh();
            this.prodComboBox.Refresh();

            if (!response.IsSuccess || !responses.IsSuccess)
            {
                return;
            }
            obsEmpleado = (ObservableCollection<Empleado>)response.Result;
            for (int i = 0; i < obsEmpleado.Count; i++)
            {
                vendComboBox.Items.Add(obsEmpleado[i].nombre);
            }
            obsProducto = (ObservableCollection<Producto>)responses.Result;
            for (int i = 0; i < obsProducto.Count; i++)
            {
                prodComboBox.Items.Add(obsProducto[i].nombre);
            }
            obsCliente = (ObservableCollection<Cliente>)responses2.Result;
            for (int i = 0; i < obsCliente.Count; i++)
            {
                clienComboBox.Items.Add(obsCliente[i].nombre);
            }
        }
        private async void LoadData()
        {

            var response_dc = await api.GetAll<Detalle_Compra>("Detalle_Compra");
            var response_dv = await api.GetAll<Detalle_Venta>("Detalle_Venta");

            if (!response_dc.IsSuccess || !response_dv.IsSuccess)
            {
                MessageBox.Show(response_dv.Message);
                return;
            }
            ObservableCollection<Detalle_Compra> detalle_compra = (ObservableCollection<Detalle_Compra>)response_dc.Result;
            ObservableCollection<Detalle_Venta> detalle_venta = (ObservableCollection<Detalle_Venta>)response_dv.Result;

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

        private async void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            venta = new Venta();
            venta.fecha = dateTimePicker1.Value.Date;

            var response = await api.Post<Venta>("venta", venta);

            if (!response.IsSuccess)
            {
                return;
            }

            venta = (Venta)response.Result;

            for (int i = 0; i < listaProducto.Count; i++)
            {
                listaProducto[i].id_venta = venta.id_venta;
                await api.Post<Detalle_Venta>("Detalle_compra", listaProducto[i]);
            }
            this.dgvVenta.Rows.Clear();
        }

        private async void btnSaveCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto;
                producto = obsProducto[prodComboBox.SelectedIndex];

                Detalle_Venta detVenta = new Detalle_Venta();
                if (CantCompraTextBox == null || prodComboBox.SelectedItem == null || vendComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor ingrese los", "datos necesarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                detVenta.Producto = producto;
                detVenta.Venta = new Venta();
                detVenta.Venta.Empleado = obsEmpleado[vendComboBox.SelectedIndex];
                detVenta.id_producto = producto.id_producto;
                detVenta.cantidad = Convert.ToInt32(CantCompraTextBox.Text);
                detVenta.monto = detVenta.cantidad * detVenta.precio_unitario;
                
                listaProducto.Add(detVenta);

                dgvVenta.Rows.Add(new string[] { detVenta.Producto.nombre, detVenta.cantidad.ToString(), dateTimePicker1.Value.ToShortDateString(), detVenta.monto.ToString(), detVenta.Producto.Proveedor.nombre });
            }
            catch (Exception)
            {
                MessageBox.Show("Ah ocurrido un error", "inesperado",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                throw;
            }
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frmProv.Show();
        }

        private void CantCompraTextBox_OnValueChanged(object sender, EventArgs e)
        {
            Detalle_Venta detVenta = new Detalle_Venta();
            
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrecioCompraTextBox_OnValueChanged(object sender, EventArgs e)
        {
            Detalle_Venta detVenta = new Detalle_Venta();
            double precioreal = Convert.ToDouble(detVenta.cantidad * detVenta.precio_unitario);
            label3.Text = Convert.ToString(precioreal);
        }
    }
}
