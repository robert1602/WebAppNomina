using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppNomina.Models
{
    public class GrupoCLS
    {

        [Display(Name = "ID Grupo")]
        public short Id_grupo { get; set; }

        [Display(Name = "Nombre Grupo")]
        [Required]
        public string nomb_grupo { get; set; }

        [Display(Name = "Codigo Grupo")]
        [Required]
        [StringLength(5,ErrorMessage ="Longitud Maxima 5 numeros")]
        public int cod_grupo { get; set; }

    }
}