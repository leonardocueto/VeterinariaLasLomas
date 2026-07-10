using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public abstract class BEPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
