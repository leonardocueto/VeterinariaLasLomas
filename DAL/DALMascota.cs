using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace DAL
{
    public class DALMascota
    {
        private readonly string connectionString =
            ConfigurationManager
                .ConnectionStrings["connectionString"]
                .ConnectionString;

        public List<BEMascota> GetAll()
        {
            List<BEMascota> mascotas = new List<BEMascota>();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        M.ID_MASCOTA,
                        M.NOMBRE AS NOMBRE_MASCOTA,
                        M.ESPECIE,
                        M.RAZA,
                        M.FECHA_NACIMIENTO,
                        M.ACTIVO AS ACTIVO_MASCOTA,
                        C.ID_CLIENTE,
                        C.NOMBRE AS NOMBRE_CLIENTE,
                        C.APELLIDO,
                        C.DNI,
                        C.TELEFONO,
                        C.EMAIL,
                        C.ACTIVO AS ACTIVO_CLIENTE
                    FROM MASCOTA M
                    INNER JOIN CLIENTE C
                        ON M.ID_CLIENTE = C.ID_CLIENTE";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BECliente cliente = new BECliente
                            {
                                IdCliente =
                                    Convert.ToInt32(reader["ID_CLIENTE"]),

                                Nombre =
                                    Convert.ToString(reader["NOMBRE_CLIENTE"]),

                                Apellido =
                                    Convert.ToString(reader["APELLIDO"]),

                                Dni =
                                    Convert.ToString(reader["DNI"]),

                                Telefono =
                                    Convert.ToString(reader["TELEFONO"]),

                                Email =
                                    Convert.ToString(reader["EMAIL"]),

                                Activo =
                                    Convert.ToBoolean(reader["ACTIVO_CLIENTE"])
                            };

                            BEMascota mascota = new BEMascota
                            {
                                IdMascota =
                                    Convert.ToInt32(reader["ID_MASCOTA"]),

                                Nombre =
                                    Convert.ToString(reader["NOMBRE_MASCOTA"]),

                                Especie =
                                    Convert.ToString(reader["ESPECIE"]),

                                Raza =
                                    Convert.ToString(reader["RAZA"]),

                                FechaNacimiento =
                                    Convert.ToDateTime(
                                        reader["FECHA_NACIMIENTO"]
                                    ),

                                Activo =
                                    Convert.ToBoolean(
                                        reader["ACTIVO_MASCOTA"]
                                    ),

                                Cliente = cliente
                            };

                            mascotas.Add(mascota);
                        }
                    }
                }
            }

            return mascotas;
        }

        public BEMascota GetById(int idMascota)
        {
            BEMascota mascota = null;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        M.ID_MASCOTA,
                        M.NOMBRE AS NOMBRE_MASCOTA,
                        M.ESPECIE,
                        M.RAZA,
                        M.FECHA_NACIMIENTO,
                        M.ACTIVO AS ACTIVO_MASCOTA,
                        C.ID_CLIENTE,
                        C.NOMBRE AS NOMBRE_CLIENTE,
                        C.APELLIDO,
                        C.DNI,
                        C.TELEFONO,
                        C.EMAIL,
                        C.ACTIVO AS ACTIVO_CLIENTE
                    FROM MASCOTA M
                    INNER JOIN CLIENTE C
                        ON M.ID_CLIENTE = C.ID_CLIENTE
                    WHERE M.ID_MASCOTA = @IdMascota";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue(
                        "@IdMascota",
                        idMascota
                    );

                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BECliente cliente = new BECliente
                            {
                                IdCliente =
                                    Convert.ToInt32(reader["ID_CLIENTE"]),

                                Nombre =
                                    Convert.ToString(reader["NOMBRE_CLIENTE"]),

                                Apellido =
                                    Convert.ToString(reader["APELLIDO"]),

                                Dni =
                                    Convert.ToString(reader["DNI"]),

                                Telefono =
                                    Convert.ToString(reader["TELEFONO"]),

                                Email =
                                    Convert.ToString(reader["EMAIL"]),

                                Activo =
                                    Convert.ToBoolean(reader["ACTIVO_CLIENTE"])
                            };

                            mascota = new BEMascota
                            {
                                IdMascota =
                                    Convert.ToInt32(reader["ID_MASCOTA"]),

                                Nombre =
                                    Convert.ToString(reader["NOMBRE_MASCOTA"]),

                                Especie =
                                    Convert.ToString(reader["ESPECIE"]),

                                Raza =
                                    Convert.ToString(reader["RAZA"]),

                                FechaNacimiento =
                                    Convert.ToDateTime(
                                        reader["FECHA_NACIMIENTO"]
                                    ),

                                Activo =
                                    Convert.ToBoolean(
                                        reader["ACTIVO_MASCOTA"]
                                    ),

                                Cliente = cliente
                            };
                        }
                    }
                }
            }

            return mascota;
        }

        public void Add(BEMascota mascota)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
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

                using (SqlCommand cmd = new SqlCommand(query, cn))
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
            }
        }

        public void Update(BEMascota mascota)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
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

                using (SqlCommand cmd = new SqlCommand(query, cn))
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

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        throw new Exception(
                            "No se encontró la mascota."
                        );
                    }
                }
            }
        }

        public void Delete(int idMascota)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE MASCOTA
                    SET ACTIVO = 0
                    WHERE ID_MASCOTA = @IdMascota";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue(
                        "@IdMascota",
                        idMascota
                    );

                    cn.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        throw new Exception(
                            "No se encontró la mascota seleccionada."
                        );
                    }
                }
            }
        }
    }
}