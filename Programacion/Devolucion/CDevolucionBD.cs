using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Devolucion
{
    class CDevolucionBD
    {
        MySqlDataAdapter da = new MySqlDataAdapter();
        Conexion conexion = new Conexion();
        public void agregarDevolucionFolio(string pIDFolio, string pIDCliente, DateTime pFecha, string pTotal)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DevolucionFolio", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            cmd.Parameters.Add(new MySqlParameter("fecha", pFecha));
            cmd.Parameters.Add(new MySqlParameter("total", float.Parse(pTotal.Trim('$'))));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
        public void agregarDevolucionPedido(string pIDFolio, string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DevolucionPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
        public bool verificarFolioDevolucionExistente(string pIDFolio)
        {
            bool result;
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("FolioDevolucionExistente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            object existeFolio = cmd.ExecuteScalar();
            cmd.Connection.Close();
            result = Convert.ToInt32(existeFolio) == 1 ? true : false;
            return result;
        }
        public bool existenFoliosDevolucionesPendientes(string pIDCliente)
        {
            bool result;
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ExistenFoliosDevolucionesClientes", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            object existenFoliosDevoluciones = cmd.ExecuteScalar();
            cmd.Connection.Close();
            result = Convert.ToInt32(existenFoliosDevoluciones) == 1 ? true : false;
            return result;
        }
        public DataTable obtenerIdFolioDevoluciones(string pIDCliente)
        {
            DataTable dt = new DataTable();
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ObtenerFolioDevolucionesClientes", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public DataTable obtenerDevoluciones(string pIDFolio)
        {
            DataTable dt = new DataTable();
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ObtenerDevolucionesPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDFolio));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void devolucionCompleta(string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DevolucionCompleta", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
