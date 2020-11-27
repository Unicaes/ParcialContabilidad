namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;


    public partial class Cliente
    {
        public int id_cliente { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }
    }
}
