using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DTO
{
    public class DTOTurno
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Dueño { get; set; }
        public string Mascota { get; set; }
        public string Veterinario { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

        public DTOTurno(int id, DateTime fechaHora, string dueño, string mascota,
                        string veterinario, string tipo, string estado)
        {
            Id = id;
            FechaHora = fechaHora;
            Dueño = dueño;
            Mascota = mascota;
            Veterinario = veterinario;
            Tipo = tipo;
            Estado = estado;
        }
    }
}
