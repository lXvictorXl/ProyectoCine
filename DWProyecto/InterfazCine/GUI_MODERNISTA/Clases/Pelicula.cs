﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    public class Pelicula
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public DateTime duracion { get; set; }
        public DateTime fechaEstreno { get; set; }
        public string estado { get; set; }
        public string clasificacion { get; set; }
    }
}
