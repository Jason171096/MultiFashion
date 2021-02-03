using System.Data;
using System.Windows.Forms;
using MultimodeSales.Programacion.Cliente;

namespace MultimodeSales.Componentes
{
    public partial class UCcomboBoxCliente : UserControl
    {
        CClienteDB cCliente = new CClienteDB();
        
        public UCcomboBoxCliente()
        {
            InitializeComponent();
            Clientes();
        }
        private void Clientes()
        {
            DataTable dt = cCliente.VerClientes();
            cboxCliente.DisplayMember = "Nombre";
            cboxCliente.ValueMember = "IDCliente";
            dt.Rows.Add(0, "--Seleccione el cliente--");
            cboxCliente.DataSource = dt;
            cboxCliente.SelectedIndex = cboxCliente.Items.Count - 1;
        }

    }
}
