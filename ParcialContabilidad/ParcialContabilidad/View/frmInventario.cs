using ApiContabilidad.Models;
using ParcialContabilidad.Model;
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
    public partial class frmInventario : Form
    {
        private ApiService api;
        public double ultimoPromedio;
        public frmInventario()
        {
            this.TopLevel = false;
            InitializeComponent();

            api = new ApiService();
            this.BackColor = ColorPallete.LightBlue;
            this.cargar_productos();
        }

        public async void cargar_productos()
        {
            try
            {
                this.dgvProducto.Rows.Clear();
                this.dgvProducto.Refresh();

                var response_p = await api.GetAll<Producto>("Producto");
                ObservableCollection<Producto> producto =
                    (ObservableCollection<Producto>)response_p.Result;

                for (int i = 0; i < producto.Count; i++)
                {
                    dgvProducto.Rows.Add(new string[] {
                    producto[i].id_producto.ToString(),
                    producto[i].nombre});
                }
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public async Task<double> get_promedio(int product_id)
        {
            this.dgvPromedio.Rows.Clear();
            this.dgvPromedio.Refresh();
            this.txtEntradas.Text = "0"; this.txtSalidas.Text = "0";
            this.txtCostoVenta.Text = "$ 0.00"; this.txtUtilidad.Text = "$ 0.00";

            var response_dc = await api.GetAll<Detalle_Compra>("Detalle_Compra");
            ObservableCollection<Detalle_Compra> detalle_compra = 
                (ObservableCollection<Detalle_Compra>)response_dc.Result;

            var response_dv = await api.GetAll<Detalle_Venta>("Detalle_Venta");
            ObservableCollection<Detalle_Venta> detalle_venta =
                (ObservableCollection<Detalle_Venta>)response_dv.Result;

            List<Promedio> lprom = new List<Promedio>();

            // COMPRAS
            for (int i = 0; i < detalle_compra.Count; i++)
            {
                if (detalle_compra[i].id_producto == product_id)
                {
                    Promedio prom = new Promedio();
                    prom.fecha = (DateTime) detalle_compra[i].Compra.fecha;
                    prom.concepto = "COMPRA";
                    prom.entrada = (int) detalle_compra[i].cantidad;
                    prom.salida = 0;
                    prom.costo_unitario = (float) detalle_compra[i].precio_unitario;
                    lprom.Add(prom);
                }            
            }

            // VENTAS
            for (int i = 0; i < detalle_venta.Count; i++)
            {
                if (detalle_venta[i].id_producto == product_id)
                {
                    Promedio prom = new Promedio();
                    prom.fecha = (DateTime)detalle_venta[i].Venta.fecha;
                    prom.concepto = "VENTA";
                    prom.entrada = 0;
                    prom.salida = (int)detalle_venta[i].cantidad;
                    prom.costo_unitario = (float)detalle_venta[i].precio_unitario;
                    lprom.Add(prom);
                }
            }

            // ORDEN POR FECHA.
            lprom.Sort((x, y) => x.fecha.CompareTo(y.fecha));

            // RESULTADOS
            int existencia = 0;
            float saldo = 0, costo_venta = 0;
            int total_salidas = 0, total_entradas = 0;

            for (int i = 0; i < lprom.Count; i++)
            {
                // Existencias y promedio
                if (lprom[i].concepto == "VENTA") { existencia -= lprom[i].salida; }
                else{ existencia += lprom[i].entrada; }

                // Debe
                lprom[i].debe = lprom[i].entrada * lprom[i].costo_unitario;

                // Haber
                if (lprom[i].concepto == "VENTA")
                {
                    if (i != 0)
                    {
                        lprom[i].costo_promedio = lprom[i - 1].costo_promedio;
                    }
                    lprom[i].haber = lprom[i].salida * lprom[i].costo_promedio;
                }
                else
                {
                    lprom[i].haber = 0;
                }

                // Saldo
                if (i==0){ saldo = lprom[i].debe;}
                else {
                    saldo += lprom[i].debe - lprom[i].haber;
                }

                // Promedio
                if (lprom[i].concepto == "VENTA")
                {
                    if (i!=0)
                    {
                        lprom[i].costo_promedio = lprom[i-1].costo_promedio;
                    }      
                }
                else
                {
                    lprom[i].costo_promedio = saldo / existencia;
                }

                costo_venta += lprom[i].haber;
                total_entradas += lprom[i].entrada;
                total_salidas += lprom[i].salida;

                this.dgvPromedio.Rows.Add(new string[] {
                    lprom[i].fecha.ToShortDateString(),
                    lprom[i].concepto,
                    lprom[i].entrada.ToString(),
                    lprom[i].salida.ToString(),
                    existencia.ToString(),
                    "$ " + lprom[i].costo_unitario.ToString(),
                    "$ " + lprom[i].costo_promedio.ToString(),
                    "$ " + lprom[i].debe.ToString(),
                    "$ " + lprom[i].haber.ToString(),
                    "$ " + saldo.ToString()
                });

                this.txtEntradas.Text = total_entradas.ToString();
                this.txtSalidas.Text = total_salidas.ToString();
                this.txtCostoVenta.Text = "$ " + costo_venta;
                this.txtUtilidad.Text = "$ " + saldo.ToString();
            }
            return lprom[lprom.Count() - 1].costo_promedio;
            
        }
        public async Task<double> GetLastPromedio(int id_producto)
        {
            return await get_promedio(id_producto);
        }
        private async void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                await this.get_promedio(int.Parse(dgvProducto.SelectedCells[0].Value.ToString()));
            }
            catch (Exception ex){Console.WriteLine(ex.Message);}        
        }
    }
}