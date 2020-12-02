namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;


    public partial class Inventario
    {
        public int id_inventario { get; set; }

        public int? id_producto { get; set; }

        public string lote { get; set; }

        public DateTime? fecha_entrada { get; set; }

        public int? cantidad { get; set; }

        public float? costo { get; set; }

        public float? precio { get; set; }

        public int? id_detalle_compra { get; set; }
        public virtual Detalle_Compra Detalle_Compra { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
