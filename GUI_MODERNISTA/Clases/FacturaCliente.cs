﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class FacturaCliente
    {
        public int Nro { get; set; }
        public DateTime FechaEmision { get; set; }
        public int fkNitCiCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal Total { get; set; }
        public int fkIdTipoPago { get; set; }
        public int fkIdEmpleado { get; set; }
        
        
    }
}
