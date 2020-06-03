using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HogarIoT
{
    public class Dispositivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        public string Nombre { get; set; }

        public Estado Estado { get; set; }

        public void CambiarEstado (string estado)
        {
            this.Estado.DescripcionEstado = estado;
        }
    }
}

