using BE;
using BE.DTO;
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
        public static DTOTurno Map(BETurno turno)
        {
            string dueño = turno.Mascota.Cliente.Apellido + ", " + turno.Mascota.Cliente.Nombre;

            return new DTOTurno(
                turno.IdTurno,
                turno.FechaHora,
                dueño,
                turno.Mascota.Nombre,
                turno.Veterinario.Apellido + ", " + turno.Veterinario.Nombre,
                turno.TipoConsulta.NombreTipo,
                turno.Estado.NombreEstado
            );
        }
        public static List<DTOTurno> Map(List<BETurno> turnos)
        {
            List<DTOTurno> lista = new List<DTOTurno>();
            foreach (BETurno turno in turnos)
            {
                lista.Add(Map(turno));
            }
            return lista;
        }
    }
}
