using BE;
using BE.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Mapper
{
    public class MapperMascota
    {
        public static BEMascota Map(
            SqlDataReader reader,
            BECliente cliente)
        {
            BEMascota mascota = new BEMascota();

            mascota.IdMascota =
                Convert.ToInt32(reader["ID_MASCOTA"]);

            mascota.Nombre =
                Convert.ToString(reader["NOMBRE"]);

            mascota.Especie =
                Convert.ToString(reader["ESPECIE"]);

            mascota.Raza =
                Convert.ToString(reader["RAZA"]);

            mascota.FechaNacimiento =
                Convert.ToDateTime(reader["FECHA_NACIMIENTO"]);

            mascota.Activo =
                Convert.ToBoolean(reader["ACTIVO"]);

            mascota.Cliente = cliente;

            return mascota;
        }

        public static DTOMascota Map(BEMascota mascota)
        {
            string dueño = "";

            if (mascota.Cliente != null)
            {
                dueño = mascota.Cliente.Nombre + " " +
                        mascota.Cliente.Apellido;
            }

            return new DTOMascota(
                mascota.IdMascota,
                mascota.Nombre,
                mascota.Especie,
                mascota.Raza,
                mascota.FechaNacimiento,
                dueño,
                mascota.Activo
            );
        }

        public static List<DTOMascota> Map(
            List<BEMascota> mascotas)
        {
            List<DTOMascota> lista =
                new List<DTOMascota>();

            foreach (BEMascota mascota in mascotas)
            {
                lista.Add(Map(mascota));
            }

            return lista;
        }
    }
}