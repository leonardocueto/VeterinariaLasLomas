using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperTipoConsulta
    {
        public static BETipoConsulta Map(SqlDataReader reader)
        {
            BETipoConsulta tipo = new BETipoConsulta();
            tipo.IdTipoConsulta = Convert.ToInt32(reader["ID_TIPO_CONSULTA"]);
            tipo.NombreTipo = Convert.ToString(reader["NOMBRE_TIPO"]);
            tipo.DuracionMinutos = Convert.ToInt32(reader["DURACION_MINUTOS"]);
            return tipo;
        }
    }
}
