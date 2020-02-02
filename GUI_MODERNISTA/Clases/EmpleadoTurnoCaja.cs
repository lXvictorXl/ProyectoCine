using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class EmpleadoTurnoCaja
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string Turno { get; set; }
        public int NroCaja { get; set; }
        public DateTime Fecha { get; set; }

        public int fkIdEmpleado { get; set; }
        public int fkTunrnoEmpleado { get; set; }
        public int fkIdCaja { get; set; }
       
        public double Caja_Chica { get; set; }
    }
}
