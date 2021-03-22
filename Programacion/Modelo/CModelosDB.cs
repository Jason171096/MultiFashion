using MultiFashion.Programacion.Utilerias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFashion.Programacion.Modelo
{
    class CModelosDB
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public DataTable ObtenerModelos(int inicio, int opcion, string buscar, DateTime dateTime)
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerModelosLimit", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("inicio", inicio));
            cmd.Parameters.Add(new MySqlParameter("opcion", opcion));
            cmd.Parameters.Add(new MySqlParameter("buscar", buscar));
            cmd.Parameters.Add(new MySqlParameter("fecha", dateTime.Date));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public DataTable ObtenerModelos2()
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerModelos", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void AgregarModelo(string pIDModelo, string pIDMarca, string pColor, string pTalla, string pPreciCliente)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarModelo", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idmodelo", pIDModelo));
            cmd.Parameters.Add(new MySqlParameter("idmarca", pIDMarca));
            cmd.Parameters.Add(new MySqlParameter("color", pColor));
            cmd.Parameters.Add(new MySqlParameter("talla", pTalla));
            cmd.Parameters.Add(new MySqlParameter("preciocliente", pPreciCliente));
            object existeModelo = cmd.ExecuteScalar();
            conexion.CloseConnection();
            if (Convert.ToInt32(existeModelo) != 1)
                CMsgBox.DisplayInfo("Modelo agregado correctamente");
            else
                CMsgBox.DisplayError($"Error en subir el modelo {pIDModelo} ya existe en la BASE de DATOS");
        }

        public void EditarModelo(string pIDModeloActual, string pIDModelo, string pIDMarca, string pColor, string pTalla, decimal pPrecioCliente)
        {
                conexion.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("EditarModelo", conexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("idmodeloActual", pIDModeloActual));
                cmd.Parameters.Add(new MySqlParameter("idmodelo", pIDModelo));
                cmd.Parameters.Add(new MySqlParameter("idmarca", pIDMarca));
                cmd.Parameters.Add(new MySqlParameter("color", pColor));
                cmd.Parameters.Add(new MySqlParameter("talla", pTalla));
                cmd.Parameters.Add(new MySqlParameter("preciocliente", pPrecioCliente));
                cmd.ExecuteNonQuery();
                conexion.CloseConnection();
        }
    }
}
