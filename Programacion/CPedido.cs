using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion
{
    class CPedido
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public void AgregarPedido(string idpedido, string idmodelo, string idcliente, string color, string talla)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", idpedido));
            cmd.Parameters.Add(new MySqlParameter("idmodelo", idmodelo));
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            cmd.Parameters.Add(new MySqlParameter("color", color));
            cmd.Parameters.Add(new MySqlParameter("talla", talla));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
        public DataTable CargarPedido(string idcliente)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerClientesPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void EliminarPedido(string idpedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("EliminarPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", idpedido));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
