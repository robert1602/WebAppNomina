using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppNomina.Models
{
    public class EmpleadoCLS
    {
        [Display(Name="ID Empleado")]
     
        public int Id_empleado { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(100,ErrorMessage ="La longitud maxima es 100")]
        public string nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required]
        [StringLength(100, ErrorMessage = "La longitud maxima es 100")]
        public string apellido { get; set; }

        [Display(Name = "Codigo Empleado")]
        [Required]
        public short cod_empleado { get; set; }
        
        [Display(Name = "Area")]
        [Required]
        [StringLength(50, ErrorMessage = "La longitud maxima es 50")]
        public string area { get; set; }

        public short Id_grupo { get; set; }

    }
}