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
    }
}
