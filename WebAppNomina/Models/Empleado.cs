//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppNomina.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public short Id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public short cod_empleado { get; set; }
        public string area { get; set; }
        public short Id_grupo { get; set; }
    
        public virtual Grupo Grupo { get; set; }
    }
}
