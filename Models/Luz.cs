using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public class Luz : Dispositivo
    {
        [Required]
        [Range(1, 10, ErrorMessage = "Rango de intensidad: 1 a 10 niveles")]
        public int Intensidad { get; set; }
    }
}
