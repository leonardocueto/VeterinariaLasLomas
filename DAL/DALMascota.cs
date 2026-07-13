using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace DAL
{
    public class DALMascota
    {
        private string connectionString =
            ConfigurationManager
                .ConnectionStrings["connectionString"]
                .ConnectionString;

        private DALCliente dalCliente = new DALCliente();

        public List<BEMascota> GetAll()
        {
            List<BEMascota> mascotas =
                new List<BEMascota>();

            using (SqlConnection cn =
                new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        ID_MASCOTA,
                        NOMBRE,
                        ESPECIE,
                        RAZA,
                        FECHA_NACIMIENTO,
                        ACTIVO,
                        ID_CLIENTE
                    FROM MASCOTA";

                using (SqlCommand cmd =
                    new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();

                        using (SqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idCliente =
                                    Convert.ToInt32(
                                        reader["ID_CLIENTE"]
                                    );

                                BECliente cliente =
                                    dalCliente.GetById(idCliente);

                                BEMascota mascota =
                                    MapperMascota.Map(
                                        reader,
                                        cliente
                                    );

                                mascotas.Add(mascota);
                            }
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            return mascotas;
        }

        public BEMascota GetById(int idMascota)
        {
            BEMascota mascota = null;

            using (SqlConnection cn =
                new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        ID_MASCOTA,
                        NOMBRE,
                        ESPECIE,
                        RAZA,
                        FECHA_NACIMIENTO,
                        ACTIVO,
                        ID_CLIENTE
                    FROM MASCOTA
                    WHERE ID_MASCOTA = @IdMascota";

                using (SqlCommand cmd =
                    new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue(
                        "@IdMascota",
                        idMascota
                    );

                    try
                    {
                        cn.Open();

                        using (SqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idCliente =
                                    Convert.ToInt32(
                                        reader["ID_CLIENTE"]
                                    );

                                BECliente cliente =
                                    dalCliente.GetById(idCliente);

                                mascota =
                                    MapperMascota.Map(
                                        reader,
                                        cliente
                                    );
                            }
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            return mascota;
        }

        public void Add(BEMascota mascota)
        {
            using (SqlConnection cn =
                new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO MASCOTA
                    (
                        NOMBRE,
                        ESPECIE,
                        RAZA,
                        FECHA_NACIMIENTO,
                        ACTIVO,
                        ID_CLIENTE
                    )
                    VALUES
                    (
                        @Nombre,
                        @Especie,
                        @Raza,
                        @FechaNacimiento,
                        @Activo,
                        @IdCliente
                    )";

                using (SqlCommand cmd =
                    new SqlCommand(query, cn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue(
                            "@Nombre",
                            mascota.Nombre
                        );

                        cmd.Parameters.AddWithValue(
                            "@Especie",
                            mascota.Especie
                        );

                        cmd.Parameters.AddWithValue(
                            "@Raza",
                            mascota.Raza
                        );

                        cmd.Parameters.AddWithValue(
                            "@FechaNacimiento",
                            mascota.FechaNacimiento
                        );

                        cmd.Parameters.AddWithValue(
                            "@Activo",
                            mascota.Activo
                        );

                        cmd.Parameters.AddWithValue(
                            "@IdCliente",
                            mascota.Cliente.IdCliente
                        );

                        cn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public void Update(BEMascota mascota)
        {
            using (SqlConnection cn =
                new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE MASCOTA
                    SET
                        NOMBRE = @Nombre,
                        ESPECIE = @Especie,
                        RAZA = @Raza,
                        FECHA_NACIMIENTO = @FechaNacimiento,
                        ID_CLIENTE = @IdCliente
                    WHERE ID_MASCOTA = @IdMascota";

                using (SqlCommand cmd =
                    new SqlCommand(query, cn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue(
                            "@Nombre",
                            mascota.Nombre
                        );

                        cmd.Parameters.AddWithValue(
                            "@Especie",
                            mascota.Especie
                        );

                        cmd.Parameters.AddWithValue(
                            "@Raza",
                            mascota.Raza
                        );

                        cmd.Parameters.AddWithValue(
                            "@FechaNacimiento",
                            mascota.FechaNacimiento
                        );

                        cmd.Parameters.AddWithValue(
                            "@IdCliente",
                            mascota.Cliente.IdCliente
                        );

                        cmd.Parameters.AddWithValue(
                            "@IdMascota",
                            mascota.IdMascota
                        );

                        cn.Open();

                        int filasAfectadas =
                            cmd.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception(
                                "No se encontró la mascota."
                            );
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public void Delete(int idMascota)
        {
            using (SqlConnection cn =
                new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE MASCOTA
                    SET ACTIVO = 0
                    WHERE ID_MASCOTA = @IdMascota";

                using (SqlCommand cmd =
                    new SqlCommand(query, cn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue(
                            "@IdMascota",
                            idMascota
                        );

                        cn.Open();

                        int filasAfectadas =
                            cmd.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception(
                                "No se encontró la mascota."
                            );
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }
    }
}