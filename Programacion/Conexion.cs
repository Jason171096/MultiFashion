using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultimodeSales.Programacion
{
    class Conexion
    {
        private string conststring = "Server=localhost;Database=multifashion;Uid=root;Pwd=''";
        private MySqlConnection cnn;
        private string ConnectionString()
        {          
            return conststring;
        }

        private void ProbarConexion()
        {
            MySqlConnection con = new MySqlConnection(ConnectionString());
            con.Open();
            if (con.State == ConnectionState.Open)
                MessageBox.Show("Conexion existosa");
            else
                MessageBox.Show("Conexion fallida");
        }

        public bool OpenConnection()
        {
            cnn = new MySqlConnection(ConnectionString());
            try
            {
                cnn.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar con el servidor: " + ex);
                return false;
            }          
        }
        public void CloseConnection()
        {
            cnn.Close();
        }

        public MySqlConnection GetConnection()
        {
            return cnn;
        }
    }
}
