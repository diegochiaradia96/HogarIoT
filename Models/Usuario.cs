using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace HogarIoT
{
    public class Usuario
    {
        //public int Id_User { get; set; }??????????
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public List<Dispositivo> Dispositivos { get; set; }

    }
}
