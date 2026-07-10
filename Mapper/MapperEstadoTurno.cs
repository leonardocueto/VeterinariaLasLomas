using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperEstadoTurno
    {
        public static BEEstadoTurno Map(SqlDataReader reader)
        {
            BEEstadoTurno estado = new BEEstadoTurno();
            estado.IdEstadoTurno = Convert.ToInt32(reader["ID_ESTADO_TURNO"]);
            estado.NombreEstado = Convert.ToString(reader["NOMBRE_ESTADO"]);
            return estado;
        }
    }
}
