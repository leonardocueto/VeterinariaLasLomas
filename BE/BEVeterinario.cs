using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BEVeterinario : BECliente
    {
        public int IdVeterinario { get; set; }
        public string Matricula { get; set; }
        public List<BEEspecialidad> Especialidades { get; set; } = new List<BEEspecialidad>();
    }
}
