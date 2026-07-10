using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BEMascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public BECliente Cliente { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
