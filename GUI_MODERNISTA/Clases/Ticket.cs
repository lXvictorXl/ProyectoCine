using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    public class Ticket
    {
        public int Nro { get; set; }
        public string TituloPelicula{get;set;}//
        public string Tipo { get; set; }//
        public DateTime FechaHoraFuncion { get; set; }//
        public int NroSala { get; set; }//
        public int NroButaca { get; set; }//
        public string NombrePromocion { get; set; }
        public decimal PrecioFinal { get; set; }//
        public string NombreEmpleado { get; set; }//
        public DateTime Fecha { get; set; }
        public decimal PrecioOriginal { get; set; }
        public int fkIdCosto { get; set; }//
        public int fkIdPromocion { get; set; }
        public int fkFuncionSala { get; set; }//
        public int IdDetalle { get; set; }
        
    }
}
