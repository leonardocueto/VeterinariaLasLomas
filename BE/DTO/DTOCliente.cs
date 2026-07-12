using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DTO
{
    public class DTOCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public DTOCliente(int id, string nombre, string apellido, string dni,
                          string telefono, string email, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Email = email;
            Activo = activo;
        }
    }
}
