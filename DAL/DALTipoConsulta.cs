using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class DALTipoConsulta
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<BETipoConsulta> GetAll()
        {
            List<BETipoConsulta> tipos = new List<BETipoConsulta>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM TIPO_CONSULTA";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tipos.Add(MapperTipoConsulta.Map(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return tipos;
        }

        public BETipoConsulta GetById(int id)
        {
            BETipoConsulta tipo = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "SELECT * FROM TIPO_CONSULTA WHERE ID_TIPO_CONSULTA = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tipo = MapperTipoConsulta.Map(reader);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return tipo;
        }
    }
}
