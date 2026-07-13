using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class DALEstadoTurno
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<BEEstadoTurno> GetAll()
        {
            List<BEEstadoTurno> estados = new List<BEEstadoTurno>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM ESTADO_TURNO";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estados.Add(MapperEstadoTurno.Map(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return estados;
        }

        public BEEstadoTurno GetById(int id)
        {
            BEEstadoTurno estado = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM ESTADO_TURNO WHERE ID_ESTADO_TURNO = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                estado = MapperEstadoTurno.Map(reader);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return estado;
        }
    }
}
