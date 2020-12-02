using ParcialContabilidad.Service;
using System;
using System.Collections.Generic;
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
        public frmInventario()
        {
            this.TopLevel = false;
            InitializeComponent();
            this.BackColor = ColorPallete.LightBlue;

        }

        public void get_promedio(String product_id)
        {
            
        }
    }
}
