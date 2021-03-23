using MultimodeSales.Programacion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MultimodeSales
{
    public class CVenta
    {
        private string idVenta;

        public string IDVenta { get => idVenta; set => idVenta = value; }
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();

        public void ventaFolio(string pIDFolio, string pIDCliente, DateTime pFecha, double pTotal)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VentaFolio", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            cmd.Parameters.Add(new MySqlParameter("fecha", pFecha));
            cmd.Parameters.Add(new MySqlParameter("total", pTotal));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public bool verificarFolioVentaExistente(string pIDFolio)
        {
            bool result;
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("FolioVentaExistente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            object existeFolio = cmd.ExecuteScalar();
            cmd.Connection.Close();
            result = Convert.ToInt32(existeFolio) == 1 ? true : false;
            return result;
        }

        public void ventaPedido(string pIDFolio, string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VentaPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public DataTable verFolioVentaPedidoCliente(string pIDFolio)
        {
            DataTable dt = new DataTable();
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerFolioVentaPedidoCliente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
    }
}
