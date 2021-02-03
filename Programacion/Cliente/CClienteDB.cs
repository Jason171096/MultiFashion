using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion.Cliente
{
    class CClienteDB
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable VerClientes()
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerClientes", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public List<object[]> VerClientes2()
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerClientes", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<object[]> res = new List<object[]>();
            while (rdr.Read())
            {
                res.Add(new object[] { rdr[0], rdr[1] });
            }
            return res;
        }
        public void AgregarCliente(string idcliente, string nombre)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarCliente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
        public void EditarCliente(string idclienteActual, string idcliente, string nombre)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("EditarCliente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idclienteActual", idclienteActual));
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
