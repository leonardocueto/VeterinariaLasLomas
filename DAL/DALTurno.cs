using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace DAL
{
    public class DALTurno
    {
        private readonly string connectionString =
           ConfigurationManager
               .ConnectionStrings["connectionString"]
               .ConnectionString;

        public List<BETurno> GetAll()
        {
            List<BETurno> turnos =
                new List<BETurno>();

            string query = @"
    SELECT
        T.ID_TURNO,
        T.FECHA_HORA,
        T.DIAGNOSTICO,

        M.ID_MASCOTA,
        M.NOMBRE AS NOMBRE_MASCOTA,

        C.ID_CLIENTE,
        C.NOMBRE AS NOMBRE_CLIENTE,
        C.APELLIDO AS APELLIDO_CLIENTE,

        V.ID_VETERINARIO,
        V.NOMBRE AS NOMBRE_VETERINARIO,
        V.APELLIDO AS APELLIDO_VETERINARIO,

        TC.ID_TIPO_CONSULTA,
        TC.NOMBRE_TIPO,

        ET.ID_ESTADO_TURNO,
        ET.NOMBRE_ESTADO

        FROM TURNO T

        INNER JOIN MASCOTA M
        ON T.ID_MASCOTA = M.ID_MASCOTA

        INNER JOIN CLIENTE C
        ON M.ID_CLIENTE = C.ID_CLIENTE

        INNER JOIN VETERINARIO V
        ON T.ID_VETERINARIO = V.ID_VETERINARIO

        INNER JOIN TIPO_CONSULTA TC
        ON T.ID_TIPO_CONSULTA =
           TC.ID_TIPO_CONSULTA

        INNER JOIN ESTADO_TURNO ET
        ON T.ID_ESTADO_TURNO =
           ET.ID_ESTADO_TURNO";

            using (SqlConnection cn =
                new SqlConnection(connectionString))
            using (SqlCommand cmd =
                new SqlCommand(query, cn))
            {
                cn.Open();

                using (SqlDataReader reader =
                    cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        turnos.Add(
                            MapperTurno.Map(reader)
                        );
                    }
                }
            }

            return turnos;
        }
    }
}