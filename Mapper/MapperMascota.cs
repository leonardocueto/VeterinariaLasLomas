using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperMascota
    {
        public static BEMascota Map(SqlDataReader reader, BECliente cliente)
        {
            BEMascota mascota = new BEMascota();
            mascota.IdMascota = Convert.ToInt32(reader["ID_MASCOTA"]);
            mascota.Nombre = Convert.ToString(reader["NOMBRE"]);
            mascota.Especie = Convert.ToString(reader["ESPECIE"]);
            mascota.Raza = Convert.ToString(reader["RAZA"]);
            mascota.FechaNacimiento = Convert.ToDateTime(reader["FECHA_NACIMIENTO"]);
            mascota.Activo = Convert.ToBoolean(reader["ACTIVO"]);
            mascota.Cliente = cliente;
            return mascota;
        }
    }
}
