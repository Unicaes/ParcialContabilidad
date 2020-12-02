namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Venta
    {
        public int id_venta { get; set; }

        public string num_factura { get; set; }

        public DateTime? fecha { get; set; }

        public float? subtotal { get; set; }

        public float? iva { get; set; }

        public float? total { get; set; }

        public int? id_cliente { get; set; }

        public int? id_vendedor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
