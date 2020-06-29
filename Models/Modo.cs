using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public enum Modo
    {
        [Display(Name = "Automatico")]
        AUTO = 0,

        [Display(Name = "Frio")]
        FRIO = 1,

        [Display(Name = "Calor")]
        CALOR = 2,

        [Display(Name = "Ventilacion")]
        VENTILACIÓN = 3
    }
}
