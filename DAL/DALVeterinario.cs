using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class DALVeterinario
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private DALEspecialidad dalEspecialidad = new DALEspecialidad();
        public List<BEVeterinario> GetAll()
        {
            List<BEVeterinario> veterinarios = new List<BEVeterinario>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM VETERINARIO";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idVet = Convert.ToInt32(reader["ID_VETERINARIO"]);
                                List<BEEspecialidad> especialidades = dalEspecialidad.GetByVeterinario(idVet);
                                veterinarios.Add(MapperVeterinario.Map(reader, especialidades));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return veterinarios;
        }
        public BEVeterinario GetById(int id)
        {
            BEVeterinario veterinario = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM VETERINARIO WHERE ID_VETERINARIO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idVet = Convert.ToInt32(reader["ID_VETERINARIO"]);
                                List<BEEspecialidad> especialidades = dalEspecialidad.GetByVeterinario(idVet);
                                veterinario = MapperVeterinario.Map(reader, especialidades);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return veterinario;
        }
        public BEVeterinario GetByMatricula(string matricula)
        {
            BEVeterinario veterinario = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM VETERINARIO WHERE MATRICULA = @Matricula";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Matricula", matricula);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idVet = Convert.ToInt32(reader["ID_VETERINARIO"]);
                                List<BEEspecialidad> especialidades = dalEspecialidad.GetByVeterinario(idVet);
                                veterinario = MapperVeterinario.Map(reader, especialidades);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return veterinario;
        }
        public void Add(BEVeterinario veterinario)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    int idVet;
                    string query = "INSERT INTO VETERINARIO (NOMBRE, APELLIDO, MATRICULA, ACTIVO) " +
                                   "VALUES (@Nombre, @Apellido, @Matricula, @Activo); " +
                                   "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", veterinario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", veterinario.Apellido);
                        cmd.Parameters.AddWithValue("@Matricula", veterinario.Matricula);
                        cmd.Parameters.AddWithValue("@Activo", veterinario.Activo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            idVet = Convert.ToInt32(reader[0]);
                        }
                    }

                    foreach (BEEspecialidad esp in veterinario.Especialidades)
                    {
                        string query2 = "INSERT INTO VETERINARIO_ESPECIALIDAD (ID_VETERINARIO, ID_ESPECIALIDAD) " +
                                             "VALUES (@IdVet, @IdEsp)";
                        using (SqlCommand cmd2 = new SqlCommand(query2, cn))
                        {
                            cmd2.Parameters.AddWithValue("@IdVet", idVet);
                            cmd2.Parameters.AddWithValue("@IdEsp", esp.IdEspecialidad);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Update(BEVeterinario veterinario)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE VETERINARIO SET NOMBRE = @Nombre, APELLIDO = @Apellido, " +
                                   "MATRICULA = @Matricula WHERE ID_VETERINARIO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", veterinario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", veterinario.Apellido);
                        cmd.Parameters.AddWithValue("@Matricula", veterinario.Matricula);
                        cmd.Parameters.AddWithValue("@Id", veterinario.IdVeterinario);
                        cmd.ExecuteNonQuery();
                    }
                    string queryDelete = "DELETE FROM VETERINARIO_ESPECIALIDAD WHERE ID_VETERINARIO = @Id";
                    using (SqlCommand cmdDelete = new SqlCommand(queryDelete, cn))
                    {
                        cmdDelete.Parameters.AddWithValue("@Id", veterinario.IdVeterinario);
                        cmdDelete.ExecuteNonQuery();
                    }

                    foreach (BEEspecialidad esp in veterinario.Especialidades)
                    {
                        string queryInsert = "INSERT INTO VETERINARIO_ESPECIALIDAD (ID_VETERINARIO, ID_ESPECIALIDAD) " +
                                            "VALUES (@IdVet, @IdEsp)";
                        using (SqlCommand cmdInsert = new SqlCommand(queryInsert, cn))
                        {
                            cmdInsert.Parameters.AddWithValue("@IdVet", veterinario.IdVeterinario);
                            cmdInsert.Parameters.AddWithValue("@IdEsp", esp.IdEspecialidad);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE VETERINARIO SET ACTIVO = 0 WHERE ID_VETERINARIO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
