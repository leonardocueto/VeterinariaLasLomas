using System;

namespace BE.DTO
{
    public class DTOMascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dueño { get; set; }
        public bool Activo { get; set; }

        public DTOMascota(
            int id,
            string nombre,
            string especie,
            string raza,
            DateTime fechaNacimiento,
            string dueño,
            bool activo)
        {
            Id = id;
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            FechaNacimiento = fechaNacimiento;
            Dueño = dueño;
            Activo = activo;
        }
    }
}