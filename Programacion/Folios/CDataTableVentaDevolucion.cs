using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Folios
{
    public class CDataTableVentaDevolucion
    {
        private DataTable dataTable;
        //public DataTable DataTable { get => dataTable; set => dataTable = value; }
        public CDataTableVentaDevolucion(DataTable dataTable)
        {
            dataTable.Columns.Add("IDPedido");
            dataTable.Columns.Add("Modelo");
            dataTable.Columns.Add("Marca");
            dataTable.Columns.Add("Color");
            dataTable.Columns.Add("Talla");
            dataTable.Columns.Add("PrecioCliente");
            this.dataTable = dataTable;
        }
        public DataTable returnDataTable()
        {
            return dataTable; 
        }
    }
}
