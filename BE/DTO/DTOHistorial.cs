using System;

namespace BE.DTO
{
    public class DTOHistorial
    {
        public string Mascota { get; set; }
        public string Duenio { get; set; }
        public DateTime Fecha { get; set; }
        public string Veterinario { get; set; }
        public string Tipo { get; set; }
        public string Diagnostico { get; set; }

        public DTOHistorial(
            string mascota,
            string duenio,
            DateTime fecha,
            string veterinario,
            string tipo,
            string diagnostico)
        {
            Mascota = mascota;
            Duenio = duenio;
            Fecha = fecha;
            Veterinario = veterinario;
            Tipo = tipo;
            Diagnostico = diagnostico;
        }
    }
}