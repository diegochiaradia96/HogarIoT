using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string NombreUsuario { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        [Required]
        public List<Dispositivo> Dispositivos { get; set; }

    }
}
