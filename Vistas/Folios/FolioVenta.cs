using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Folios
{
    public partial class FolioVenta : Form
    {
        CVenta cVenta = new CVenta();
        private readonly string IDFolioVenta;
        public FolioVenta(string pIDFolioVenta)
        {
            InitializeComponent();
            IDFolioVenta = pIDFolioVenta;
            cargarFolioVentaModelos();
        }
        private void cargarFolioVentaModelos()
        {
            DataTable dt = cVenta.verFolioVentaPedidoCliente(IDFolioVenta);
            foreach (DataRow rows in dt.Rows)
            {
                string[] row = { rows[0].ToString(), rows[1].ToString(), rows[2].ToString(), rows[3].ToString(), rows[4].ToString(), rows[5].ToString() };
                var listViewItem = new ListViewItem(row);
                UCListViewItem.listView.Items.Add(listViewItem);
            }
        }
    }
}
