using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BEEstadoTurno
    {
        public int IdEstadoTurno { get; set; }
        public string NombreEstado { get; set; }

        public override string ToString()
        {
            return NombreEstado;
        }
    }
}
