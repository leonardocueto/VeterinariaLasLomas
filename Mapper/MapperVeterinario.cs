using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperVeterinario
    {
        public static BEVeterinario Map(SqlDataReader reader, List<BEEspecialidad> especialidades)
        {
            BEVeterinario veterinario = new BEVeterinario();
            veterinario.IdVeterinario = Convert.ToInt32(reader["ID_VETERINARIO"]);
            veterinario.Nombre = Convert.ToString(reader["NOMBRE"]);
            veterinario.Apellido = Convert.ToString(reader["APELLIDO"]);
            veterinario.Matricula = Convert.ToString(reader["MATRICULA"]);
            veterinario.Activo = Convert.ToBoolean(reader["ACTIVO"]);
            veterinario.Especialidades = especialidades;
            return veterinario;
        }
    }
}
