using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperEspecialidad
    {
        public static BEEspecialidad Map(SqlDataReader reader)
        {
            BEEspecialidad especialidad = new BEEspecialidad();
            especialidad.IdEspecialidad = Convert.ToInt32(reader["ID_ESPECIALIDAD"]);
            especialidad.NombreEspecialidad = Convert.ToString(reader["NOMBRE_ESPECIALIDAD"]);
            return especialidad;
        }
    }
}
