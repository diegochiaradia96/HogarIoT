using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace HogarIoT
{
    public class Modo
    {
        public int ModoID { get; set; }
        public TipoModo DescripcionModo { get; set; }
    }

    public enum TipoModo
    {
        AUTO, FRIO, CALOR, VENTILACIÓN
    }
}
