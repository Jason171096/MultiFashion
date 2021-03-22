using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion
{
    class CListaPedidosFinal
    {
        Conexion conexion = new Conexion();
        public DataTable ObtenerListaPedidosFinal(int pOpcion, string pBuscar, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerListaPedidoFinal", conexion.GetConnection());
            cmd.Parameters.Add(new MySqlParameter("opcion", pOpcion));
            cmd.Parameters.Add(new MySqlParameter("buscar", pBuscar));
            cmd.Parameters.Add(new MySqlParameter("fechaInicial", pFechaInicial));
            cmd.Parameters.Add(new MySqlParameter("fechaFinal", pFechaFinal));
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            conexion.CloseConnection();
            return dt;
        }
        public void UpdatePedidoLlego(string idpedido, string llego)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ActualizarPedidoFinal", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", idpedido));
            cmd.Parameters.Add(new MySqlParameter("llego", llego));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
        public DataTable ObtenerPedidoFinalLlego(string idcliente)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerClientesPedidoLlego", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conexion.CloseConnection();
            return dt;
        }
    }
}
