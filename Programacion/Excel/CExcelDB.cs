using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Excel
{
    class CExcelDB
    {
        Conexion conexion = new Conexion();
        public bool AgregarPedidosFinal(string modelo, string idusuario)
        {
            conexion.OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("AgregarPedidosFinal", conexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("idmodelo", modelo));
                cmd.Parameters.Add(new MySqlParameter("idcliente", idusuario));
                cmd.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                conexion.CloseConnection();
                return false;
            }
        }
    }
}
