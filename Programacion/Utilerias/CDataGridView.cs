using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion
{
    public static class CDataGridView
    {
        public static void FormattedDataGridView(DataGridView dataGrid)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.GridColor = Color.DarkSlateBlue;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGrid.RowsDefaultCellStyle.BackColor = Color.Indigo;
            dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            dataGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
