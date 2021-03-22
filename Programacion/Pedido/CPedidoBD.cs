using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace MultiFashion.Programacion
{
    class CPedidoBD
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public void AgregarPedido(string pIDPedido, string pIDModelo, string pIDCliente, string pColor, string pTalla)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.Parameters.Add(new MySqlParameter("idmodelo", pIDModelo));
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            cmd.Parameters.Add(new MySqlParameter("color", pColor));
            cmd.Parameters.Add(new MySqlParameter("talla", pTalla));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
        public DataTable CargarPedido(string pIDCliente)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerClientesPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void EliminarPedido(string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("EliminarPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public string AgregarPedidoProvisional(string pIDModelo, string pIDCliente, string pColor, string pTalla)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarPedidoProvisional", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idmodelo", pIDModelo));
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            cmd.Parameters.Add(new MySqlParameter("color", pColor));
            cmd.Parameters.Add(new MySqlParameter("talla", pTalla));
            string IDPedido = cmd.ExecuteScalar().ToString();
            conexion.CloseConnection();
            return IDPedido;
        }
        public bool confirmacionPedidoEliminar(string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ConfirmacionPedidoEliminar", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            bool confirmacionPedido = Convert.ToBoolean(cmd.ExecuteScalar());
            return confirmacionPedido;
        }
    }
}
