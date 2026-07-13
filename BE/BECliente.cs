using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BECliente : BEPersona
    {
        public int IdCliente { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NombreCompleto
        {
            get { return Apellido + ", " + Nombre; }
        }
    }
}
