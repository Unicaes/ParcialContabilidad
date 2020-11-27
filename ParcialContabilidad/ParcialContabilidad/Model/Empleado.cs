namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;


    public partial class Empleado
    {
        public int id_empleado { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string telefono { get; set; }
    }
}
