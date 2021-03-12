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
        DataTable dataTable;
        public CDataTableVentaDevolucion()
        {
            dataTable.Columns.Add("IDPedido");
            dataTable.Columns.Add("Modelo");
            dataTable.Columns.Add("Marca");
            dataTable.Columns.Add("Color");
            dataTable.Columns.Add("Talla");
            dataTable.Columns.Add("PrecioCliente");
        }
    }
}
