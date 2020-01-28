using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    public class Empleado
    {
        public int id { get; set; }
        public string ci { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public DateTime fechaNac { get; set; }
        public int cel { get; set; }
        public string direccion { get; set; }
        public string password { get; set; }
        public bool estado { get; set; }
        public int idCargo { get; set; }
        public string cargo { get; set; }
    }
}
