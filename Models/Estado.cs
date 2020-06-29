using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{


   
    public enum Estado
    {
        [Display(Name = "Encendido")]
        ENCENDIDO = 0,

        [Display(Name = "Apagado")]
        APAGADO = 1,

        [Display(Name = "Sin Connexion")]
        SIN_CONEXION = 2
    }
}
