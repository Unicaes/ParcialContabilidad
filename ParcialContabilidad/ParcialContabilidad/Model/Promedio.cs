using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialContabilidad.Model
{
    class Promedio
    {
        public DateTime fecha { get; set; }

        public string concepto { get; set; }

        public int entrada { get; set; }

        public int salida { get; set; }

        public int existencia { get; set; }

        public float costo_unitario { get; set; }

        public float costo_promedio { get; set; }

        public float debe { get; set; }

        public float haber { get; set; }

        public float saldo { get; set; }

    }
}
