using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public class Modo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModoID { get; set; }
        public string DescripcionModo { get; set; }
    }

    //CASO ANTERIOR
    //public TipoModo DescripcionModo { get; set; }
    //public enum TipoModo
    //{
    //    AUTO, FRIO, CALOR, VENTILACIÓN
    //}
}
