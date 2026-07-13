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
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        private DALMascota dalMascota = new DALMascota();
        private DALVeterinario dalVeterinario = new DALVeterinario();
        private DALTipoConsulta dalTipoConsulta = new DALTipoConsulta();
        private DALEstadoTurno dalEstadoTurno = new DALEstadoTurno();

        public List<BETurno> GetAll()
        {
            List<BETurno> turnos = new List<BETurno>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM TURNO";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                turnos.Add(MapearTurnoCompleto(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return turnos;
        }

        public BETurno GetById(int id)
        {
            BETurno turno = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM TURNO WHERE ID_TURNO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                turno = MapearTurnoCompleto(reader);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return turno;
        }
        public List<BETurno> GetByVeterinarioYFecha(int idVeterinario, DateTime fecha)
        {
            List<BETurno> turnos = new List<BETurno>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM TURNO " +
                                   "WHERE ID_VETERINARIO = @IdVet " +
                                   "AND CAST(FECHA_HORA AS DATE) = @Fecha " +
                                   "AND ID_ESTADO_TURNO = 1";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdVet", idVeterinario);
                        cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                turnos.Add(MapearTurnoCompleto(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return turnos;
        }
        public List<BETurno> GetHistorialPorMascota(int idMascota)
        {
            List<BETurno> turnos = new List<BETurno>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM TURNO " +
                                   "WHERE ID_MASCOTA = @IdMascota " +
                                   "AND ID_ESTADO_TURNO = 2 " + 
                                   "ORDER BY FECHA_HORA DESC";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdMascota", idMascota);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                turnos.Add(MapearTurnoCompleto(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return turnos;
        }

        public void Add(BETurno turno)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "INSERT INTO TURNO (FECHA_HORA, ID_MASCOTA, ID_VETERINARIO, ID_TIPO_CONSULTA, ID_ESTADO_TURNO) " +
                                   "VALUES (@FechaHora, @IdMascota, @IdVet, @IdTipo, @IdEstado)";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@FechaHora", turno.FechaHora);
                        cmd.Parameters.AddWithValue("@IdMascota", turno.Mascota.IdMascota);
                        cmd.Parameters.AddWithValue("@IdVet", turno.Veterinario.IdVeterinario);
                        cmd.Parameters.AddWithValue("@IdTipo", turno.TipoConsulta.IdTipoConsulta);
                        cmd.Parameters.AddWithValue("@IdEstado", turno.Estado.IdEstadoTurno);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Update(BETurno turno)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE TURNO SET FECHA_HORA = @FechaHora WHERE ID_TURNO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@FechaHora", turno.FechaHora);
                        cmd.Parameters.AddWithValue("@Id", turno.IdTurno);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void CambiarEstado(int idTurno, int idEstado)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE TURNO SET ID_ESTADO_TURNO = @IdEstado WHERE ID_TURNO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstado", idEstado);
                        cmd.Parameters.AddWithValue("@Id", idTurno);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void GuardarDiagnostico(int idTurno, string diagnostico)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE TURNO SET DIAGNOSTICO = @Diagnostico WHERE ID_TURNO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Diagnostico", diagnostico);
                        cmd.Parameters.AddWithValue("@Id", idTurno);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private BETurno MapearTurnoCompleto(SqlDataReader reader)
        {
            int idMascota = Convert.ToInt32(reader["ID_MASCOTA"]);
            int idVet = Convert.ToInt32(reader["ID_VETERINARIO"]);
            int idTipo = Convert.ToInt32(reader["ID_TIPO_CONSULTA"]);
            int idEstado = Convert.ToInt32(reader["ID_ESTADO_TURNO"]);

            BEMascota mascota = dalMascota.GetById(idMascota);
            BEVeterinario veterinario = dalVeterinario.GetById(idVet);
            BETipoConsulta tipoConsulta = dalTipoConsulta.GetById(idTipo);
            BEEstadoTurno estado = dalEstadoTurno.GetById(idEstado);

            return MapperTurno.Map(reader, mascota, veterinario, tipoConsulta, estado);
        }
    }
}