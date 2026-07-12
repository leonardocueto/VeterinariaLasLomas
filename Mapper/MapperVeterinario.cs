using BE;
using BE.DTO;
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
        public static DTOVeterinario Map(BEVeterinario veterinario)
        {
            string especialidades = string.Join(", ", veterinario.Especialidades.Select(e => e.NombreEspecialidad));

            return new DTOVeterinario(veterinario.IdVeterinario, veterinario.Nombre,
                                      veterinario.Apellido, veterinario.Matricula,
                                      especialidades, veterinario.Activo);
        }

        public static List<DTOVeterinario> Map(List<BEVeterinario> veterinarios)
        {
            List<DTOVeterinario> lista = new List<DTOVeterinario>();
            foreach (var veterinario in veterinarios)
            {
                lista.Add(Map(veterinario));
            }
            return lista;
        }
    }
}
