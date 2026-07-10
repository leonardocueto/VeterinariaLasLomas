using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class MapperCliente
    {
        public static BECliente Map(SqlDataReader reader)
        {
            BECliente cliente = new BECliente();
            cliente.IdCliente = Convert.ToInt32(reader["ID_CLIENTE"]);
            cliente.Nombre = Convert.ToString(reader["NOMBRE"]);
            cliente.Apellido = Convert.ToString(reader["APELLIDO"]);
            cliente.Dni = Convert.ToString(reader["DNI"]);
            cliente.Telefono = Convert.ToString(reader["TELEFONO"]);
            cliente.Email = Convert.ToString(reader["EMAIL"]);
            cliente.Activo = Convert.ToBoolean(reader["ACTIVO"]);
            return cliente;
        }
    }
}
