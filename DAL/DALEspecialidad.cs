using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class DALEspecialidad
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public List<BEEspecialidad> GetAll()
        {
            List<BEEspecialidad> especialidades = new List<BEEspecialidad>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM ESPECIALIDAD";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                especialidades.Add(MapperEspecialidad.Map(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return especialidades;
        }

        public BEEspecialidad GetById(int id)
        {
            BEEspecialidad especialidad = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM ESPECIALIDAD WHERE ID_ESPECIALIDAD = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                especialidad = MapperEspecialidad.Map(reader);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return especialidad;
        }
        public List<BEEspecialidad> GetByVeterinario(int idVeterinario)
        {
            List<BEEspecialidad> especialidades = new List<BEEspecialidad>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT E.* FROM ESPECIALIDAD E " +
                                   "INNER JOIN VETERINARIO_ESPECIALIDAD VE ON E.ID_ESPECIALIDAD = VE.ID_ESPECIALIDAD " +
                                   "WHERE VE.ID_VETERINARIO = @IdVeterinario";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdVeterinario", idVeterinario);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                especialidades.Add(MapperEspecialidad.Map(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return especialidades;
        }

        public void Add(BEEspecialidad especialidad)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "INSERT INTO ESPECIALIDAD (NOMBRE_ESPECIALIDAD) VALUES (@Nombre)";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", especialidad.NombreEspecialidad);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Update(BEEspecialidad especialidad)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE ESPECIALIDAD SET NOMBRE_ESPECIALIDAD = @Nombre WHERE ID_ESPECIALIDAD = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", especialidad.NombreEspecialidad);
                        cmd.Parameters.AddWithValue("@Id", especialidad.IdEspecialidad);
                        cmd.ExecuteNonQuery();
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
                    string query = "DELETE FROM ESPECIALIDAD WHERE ID_ESPECIALIDAD = @Id";
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
        public int ContarVeterinarios(int idEspecialidad)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT COUNT(*) FROM VETERINARIO_ESPECIALIDAD WHERE ID_ESPECIALIDAD = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idEspecialidad);
                        return Convert.ToInt32(cmd.ExecuteScalar());
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
