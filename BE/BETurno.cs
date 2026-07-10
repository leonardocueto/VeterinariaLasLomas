using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BETurno
    {
        public int IdTurno { get; set; }
        public DateTime FechaHora { get; set; }
        public string Diagnostico { get; set; }
        public BEMascota Mascota { get; set; }
        public BEVeterinario Veterinario { get; set; }
        public BETipoConsulta TipoConsulta { get; set; }
        public BEEstadoTurno Estado { get; set; }
    }
}
