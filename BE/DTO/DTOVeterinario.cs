using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DTO
{
    public class DTOVeterinario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }
        public string Especialidades { get; set; }
        public bool Activo { get; set; }

        public DTOVeterinario(int id, string nombre, string apellido, string matricula,
                              string especialidades, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
            Especialidades = especialidades;
            Activo = activo;
        }
    }
}
