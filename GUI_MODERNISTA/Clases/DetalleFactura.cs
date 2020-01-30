using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class DetalleFactura
    {
        public int Id { get; set; }
        public string TituloPelicula { get; set; }//
        public DateTime FechaHoraFuncion { get; set; }//
        public int NroSala { get; set; }//
        public int CantidadTickets { get; set; }//
        public decimal SubTotal { get; set; }//
        public int fkNroFactura { get; set; }
    }
}
