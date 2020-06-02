using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HogarIoT
{
    public class AireAcondicionado : Dispositivo
    {
        public int Temperatura { get; set; }
        public Modo Modo { get; set; }

        public void CambiarModo (TipoModo modo)
        {
            this.Modo.DescripcionModo = modo;
        }
    }
}
