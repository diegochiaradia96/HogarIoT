using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public class Heladera : Dispositivo
    {
        [Required]
        [Range(2, 5, ErrorMessage = "Rango de temperatura de la heladera: 2° a 5°")]
        [Display(Name = "Temperatura Heladera")]
        public int TempHeladera { get; set; }

        [Required]
        [Range(-25, -18, ErrorMessage = "Rango de temperatura del freezer: -18° a -25°")]
        [Display(Name = "Temperatura Freezer")]
        public int TempFreezer { get; set; }
    }
}
