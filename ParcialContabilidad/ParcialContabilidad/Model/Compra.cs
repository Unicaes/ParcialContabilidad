namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;


    public partial class Compra
    {
        public int id_compra { get; set; }

        public string num_factura { get; set; }

        public DateTime? fecha { get; set; }

        public float? subtotal { get; set; }

        public float? iva { get; set; }

        public float? total { get; set; }
    }
}
