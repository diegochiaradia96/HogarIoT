using System;
using System.Collections.Generic;
using System.Text;        
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HogarIoT
{
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ESTADOID { get; set; }
        public string DescripcionEstado { get; set; }
    }
    
    //CASO ANTERIOR
    // public TipoEstado DescripcionEstado { get; set; }
    ////public enum TipoEstado
    //{
    //    ENCENDIDO, APAGADO, SIN_CONEXION
    //}
}
