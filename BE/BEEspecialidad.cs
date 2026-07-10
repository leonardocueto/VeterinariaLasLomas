using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BEEspecialidad
    {
        public int IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }

        public override string ToString()
        {
            return NombreEspecialidad;
        }
    }
}
