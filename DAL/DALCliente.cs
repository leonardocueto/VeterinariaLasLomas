using BE;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class DALCliente
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        
        public List<BECliente> GetAll()
        {
            List<BECliente> clientes = new List<BECliente>();
            using (SqlConnection cn = new SqlConnection(connectionString)) {

                string query = "SELECT * FROM CLIENTE";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clientes.Add(MapperCliente.Map(reader));
                            }
                         }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            return clientes;
        }

        public BECliente GetById(int id)
        {
            BECliente cliente = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {

                string query = "SELECT * FROM CLIENTE WHERE ID_CLIENTE = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader()){
                        if (reader.Read())
                        {
                            cliente = MapperCliente.Map(reader);
                        }
                    }
                }
                }
                catch
                {
                    throw;

                }
            }
            return cliente;
        }
        public void Add(BECliente cliente)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "INSERT INTO CLIENTE (NOMBRE, APELLIDO, DNI, TELEFONO, EMAIL, ACTIVO) VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Email, @Activo)";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@Dni", cliente.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@Email", cliente.Email);
                        cmd.Parameters.AddWithValue("@Activo", cliente.Activo);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public void Update(BECliente cliente)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                try
                {
                    string query = "UPDATE CLIENTE SET NOMBRE = @Nombre, APELLIDO = @Apellido, DNI = @Dni, TELEFONO = @Telefono, EMAIL = @Email WHERE ID_CLIENTE = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@Dni", cliente.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@Email", cliente.Email);
                        cmd.Parameters.AddWithValue("@Id", cliente.IdCliente);
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
                    string query = "UPDATE CLIENTE SET ACTIVO = 0 WHERE ID_CLIENTE = @Id";
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
