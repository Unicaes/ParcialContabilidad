namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;


    public partial class Detalle_Compra
    {
        public int id_detalle_compra { get; set; }

        public int? id_producto { get; set; }

        public int? id_compra { get; set; }

        public int? cantidad { get; set; }

        public float? precio_unitario { get; set; }

        public float? monto { get; set; }
        public virtual Compra Compra { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
