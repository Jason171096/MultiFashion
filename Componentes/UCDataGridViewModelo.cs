using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiFashion.Programacion;

namespace MultiFashion.Componentes
{
    public partial class UCDataGridViewModelo : UserControl
    {
        CVenta cVenta = new CVenta();
        public UCDataGridViewModelo()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvModelosCliente);
        }
        public void cargarFolioVentaModelos(string pIDFolioVenta)
        {
            DataTable dt = cVenta.verFolioVentaPedidoCliente(pIDFolioVenta);
            dgvModelosCliente.DataSource = dt;
            FormattedDataGridView();
        }
        private void FormattedDataGridView()
        {
            dgvModelosCliente.Columns[0].Visible = false;//IDPedido
            dgvModelosCliente.Columns[6].Visible = false;//Llego
            dgvModelosCliente.Columns[7].Visible = false;//Vendido
            dgvModelosCliente.Columns[8].Visible = false;//DEvolucion
        }
    }
}
