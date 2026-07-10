using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BETipoConsulta
    {
        public int IdTipoConsulta { get; set; }
        public string NombreTipo { get; set; }
        public int DuracionMinutos { get; set; }

        public override string ToString()
        {
            return NombreTipo;
        }
    }
}
