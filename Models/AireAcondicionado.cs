using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public class AireAcondicionado : Dispositivo
    {
        [Required]
        [Range(16, 30, ErrorMessage = "Rango de temperatura: 16° a 30°")]
        public int Temperatura { get; set; }

        [Required]

        public Modo Modo { get; set; }
    }
}
