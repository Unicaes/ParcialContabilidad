﻿using ApiContabilidad.Models;
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
        List<Detalle_Compra> listaProducto = new List<Detalle_Compra>();
        ObservableCollection<Proveedor> obsProveedor;
        ObservableCollection<Producto> obsProducto;
        Compra compra;

        public frmCompraVenta()
        {

            this.TopLevel = false;
            InitializeComponent();
            this.BackColor = ColorPallete.LightBlue;
            api = new ApiService();
            LoadProveedor();

        }
        private async void LoadProveedor()
        {
            var response = await api.GetAll<Proveedor>("proveedor");
            var responses = await api.GetAll<Producto>("producto");

            if (!response.IsSuccess || !responses.IsSuccess)
            {
                return;
            }
            obsProveedor = (ObservableCollection<Proveedor>)response.Result;
            for (int i = 0; i < obsProveedor.Count; i++)
            {
                provComboBox.Items.Add(obsProveedor[i].nombre);
            }
            obsProducto = (ObservableCollection<Producto>)responses.Result;
            for (int i = 0; i < obsProducto.Count; i++)
            {
                prodComboBox.Items.Add(obsProducto[i].nombre);
            }
        }
        private async void LoadData()
        {

            var response_dc = await api.GetAll<Detalle_Compra>("Detalle_Compra");
            var response_dv = await api.GetAll<Detalle_Venta>("Detalle_Venta");

            if (!response_dc.IsSuccess || !response_dv.IsSuccess)
            {
                MessageBox.Show(response_dc.Message);
                return;
            }
            ObservableCollection<Detalle_Compra> detalle_compra = (ObservableCollection<Detalle_Compra>)response_dc.Result;
            ObservableCollection<Detalle_Venta> detalle_venta = (ObservableCollection<Detalle_Venta>)response_dv.Result;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.dgvCompra.Rows.Clear();
            Detalle_Compra dt = new Detalle_Compra
            {
                cantidad = Int32.Parse(this.CantCompraTextBox.Text),
                precio_unitario = Int32.Parse(this.PrecioCompraTextBox.Text),
                monto = Int32.Parse(this.PrecioCompraTextBox.Text)

            };


            this.dgvCompra.Refresh();

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
            compra = new Compra();
            compra.fecha = dateTimePicker1.Value.Date;

            var response = await api.Post<Compra>("compra", compra);

            if (!response.IsSuccess)
            {
                return;
            }

            compra = (Compra)response.Result;

            for (int i = 0; i < listaProducto.Count; i++)
            {
                listaProducto[i].id_compra = compra.id_compra;
                await api.Post<Detalle_Compra>("Detalle_compra", listaProducto[i]);
            }
        }

        private async void btnSaveCompra_Click(object sender, EventArgs e)
        {
            Producto producto;
            if (checkBox1.Checked)
            {
                producto = new Producto
                {
                    nombre = this.btnNombre.Text,
                    id_proveedor = obsProveedor[this.provComboBox.SelectedIndex].id_proveedor
                };
                var response = await api.Post<Producto>("producto", producto);

                if (!response.IsSuccess)
                {
                    return;
                }

                producto = (Producto)response.Result;
            }
            else
            {
                producto = obsProducto[prodComboBox.SelectedIndex];
            }

            Detalle_Compra detCompra = new Detalle_Compra();

            detCompra.Producto = producto;
            detCompra.Producto.Proveedor = obsProveedor[provComboBox.SelectedIndex];
            detCompra.id_producto = producto.id_producto;
            detCompra.cantidad = Convert.ToInt32(CantCompraTextBox.Text);
            detCompra.precio_unitario = (float)Convert.ToDouble(PrecioCompraTextBox.Text);
            detCompra.monto = detCompra.cantidad * detCompra.precio_unitario;

            listaProducto.Add(detCompra);

            dgvCompra.Rows.Add(new string[]{detCompra.Producto.nombre, detCompra.cantidad.ToString(), dateTimePicker1.Value.ToShortDateString(), detCompra.precio_unitario.ToString(), detCompra.Producto.Proveedor.nombre});
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.prodComboBox.Enabled = false;
                this.btnNombre.Enabled = true;
            }
            else
            {
                this.prodComboBox.Enabled = true;
                this.btnNombre.Enabled = false;
            }
        }
    }
}
