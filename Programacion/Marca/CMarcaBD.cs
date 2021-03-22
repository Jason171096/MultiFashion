using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFashion.Programacion.Marca
{
    class CMarcaBD
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        

        public DataTable VerMarcas()
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerMarcas", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public List<object[]> VerMarcas2()
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerMarcas", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<object[]> res = new List<object[]>();
            while(rdr.Read())
            {
                res.Add(new object[] { rdr[0], rdr[1] });
            }
            return res;
        }

        public void AgregarMarca(string idmarca, string nombre)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarMarca", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idmarca", idmarca));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void EditarMarca(string idmarcaActual, string idmarca, string nombre)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("EditarMarca", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idmarcaActual", idmarcaActual));
            cmd.Parameters.Add(new MySqlParameter("idmarca", idmarca));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.ExecuteNonQuery();         
            cmd.Connection.Close();
        }
        
    }
}
