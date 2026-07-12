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

        public static BETurno Map(SqlDataReader reader)
        {
            BECliente cliente = new BECliente();

            cliente.IdCliente =
                Convert.ToInt32(reader["ID_CLIENTE"]);

            cliente.Nombre =
                Convert.ToString(reader["NOMBRE_CLIENTE"]);

            cliente.Apellido =
                Convert.ToString(reader["APELLIDO_CLIENTE"]);


            BEMascota mascota = new BEMascota();

            mascota.IdMascota =
                Convert.ToInt32(reader["ID_MASCOTA"]);

            mascota.Nombre =
                Convert.ToString(reader["NOMBRE_MASCOTA"]);

            mascota.Cliente = cliente;


            BEVeterinario veterinario =
                new BEVeterinario();

            veterinario.IdVeterinario =
                Convert.ToInt32(reader["ID_VETERINARIO"]);

            veterinario.Nombre =
                Convert.ToString(reader["NOMBRE_VETERINARIO"]);

            veterinario.Apellido =
                Convert.ToString(reader["APELLIDO_VETERINARIO"]);


            BETipoConsulta tipoConsulta =
                new BETipoConsulta();

            tipoConsulta.IdTipoConsulta =
                Convert.ToInt32(reader["ID_TIPO_CONSULTA"]);

            tipoConsulta.NombreTipo =
                Convert.ToString(reader["NOMBRE_TIPO"]);


            BEEstadoTurno estado =
                new BEEstadoTurno();

            estado.IdEstadoTurno =
                Convert.ToInt32(reader["ID_ESTADO_TURNO"]);

            estado.NombreEstado =
                Convert.ToString(reader["NOMBRE_ESTADO"]);


            BETurno turno = new BETurno();

            turno.IdTurno =
                Convert.ToInt32(reader["ID_TURNO"]);

            turno.FechaHora =
                Convert.ToDateTime(reader["FECHA_HORA"]);

            turno.Diagnostico =
                Convert.ToString(reader["DIAGNOSTICO"]);

            turno.Mascota = mascota;
            turno.Veterinario = veterinario;
            turno.TipoConsulta = tipoConsulta;
            turno.Estado = estado;

            return turno;
        }
    }
}
