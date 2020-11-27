namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Producto
    {
        public int id_producto { get; set; }

        public string nombre { get; set; }

        public int? id_proveedor { get; set; }
    }
}
