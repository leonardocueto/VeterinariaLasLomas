using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperTurno
    {
        public static BETurno Map(SqlDataReader reader, BEMascota mascota, BEVeterinario veterinario, BETipoConsulta tipoConsulta, BEEstadoTurno estado)
        {
            BETurno turno = new BETurno();
            turno.IdTurno = Convert.ToInt32(reader["ID_TURNO"]);
            turno.FechaHora = Convert.ToDateTime(reader["FECHA_HORA"]);
            turno.Diagnostico = Convert.ToString(reader["DIAGNOSTICO"]);
            turno.Mascota = mascota;
            turno.Veterinario = veterinario;
            turno.TipoConsulta = tipoConsulta;
            turno.Estado = estado;
            return turno;
        }
    }
}
