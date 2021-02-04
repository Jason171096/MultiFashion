using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
using MultimodeSales.Vistas.Modelos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MultimodeSales.Vistas
{
    public partial class Pedido : Form
    {
        CClienteDB cliente = new CClienteDB();
        CModelosDB modelos = new CModelosDB();
        CPedido pedido = new CPedido();
        CColoresyTallas ColoresyTallas = new CColoresyTallas();
        DataTable DataModels = new DataTable();
        private bool CellValueChange = false, SelectIndexChange = false;

        public Pedido()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarColorTalla);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnFinalizarPedido);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Pedido";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Clientes();
            Modelos();
            Colores();
            Tallas();
            IDMarca.ReadOnly = true;
            dgvPedido.Columns[0].Visible = false;
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Clientes()
        {
            DataTable dt = cliente.VerClientes();
            UCcboxCliente.cboxCliente.DisplayMember = "Nombre";
            UCcboxCliente.cboxCliente.ValueMember = "IDCliente";
            dt.Rows.Add(0, "--Seleccione el cliente--");
            UCcboxCliente.cboxCliente.DataSource = dt;
            UCcboxCliente.cboxCliente.SelectedIndex = UCcboxCliente.cboxCliente.Items.Count - 1;
        }
        private void Modelos()
        {
            DataTable dt = modelos.ObtenerModelos2();
            IDModelo.DisplayMember = "IDModelo";
            IDModelo.DataSource = dt;
            DataModels = dt;
        }
        private void Colores()
        {
            DataTable dt = ColoresyTallas.VerColores();
            IDColor.DisplayMember = "Nombre";
            IDColor.DataSource = dt;
        }
        private void Tallas()
        {
            DataTable dt = ColoresyTallas.VerTallas();
            IDTalla.DisplayMember = "Numero";
            IDTalla.DataSource = dt;
        }
        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            EditModelo modelo = new EditModelo(true, "", "", "", "", "");
            modelo.ShowDialog();
            Modelos();
        }

        private void rbtnAgTaCo_Click(object sender, EventArgs e)
        {
            TallasyColores tallasyColores = new TallasyColores();
            tallasyColores.ShowDialog();
            Colores();
            Tallas();
        }
        private void rbtnFinalizarPedido_Click(object sender, EventArgs e)
        {
            int index = UCcboxCliente.cboxCliente.Items.Count - 1;
            if (index != UCcboxCliente.cboxCliente.SelectedIndex)
            {
                foreach (DataGridViewRow rows in dgvPedido.Rows)
                {

                    if (rows.Cells[1].Value + "" != "")
                    {
                        pedido.AgregarPedido(rows.Cells[0].Value + "", rows.Cells[1].Value + "", UCcboxCliente.cboxCliente.SelectedValue + "", rows.Cells[3].Value + "", rows.Cells[4].Value + "");
                    }
                }
                CMsgBox.DisplayInfo("Pedido ingresado correctamente");
            }
            else
                CMsgBox.DisplayWarning("Seleccione un cliente");
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = CMsgBox.DisplayConfirmation("¿Seguro que desea cerrar?");
            if (result == DialogResult.Yes)
                Close();
        }
        private void dgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 1)
            {
                if (CellValueChange)
                {
                    string value = dgvPedido.Rows[e.RowIndex].Cells[1].Value + "";
                    string marca = "";
                    foreach (DataRow rows in DataModels.Rows)
                    {
                        if (value == rows[0] + "")
                        {
                            marca = rows[2] + "";
                            break;
                        }
                    }
                    dgvPedido.Rows[e.RowIndex].Cells[2].Value = marca;
                }
                CellValueChange = true;
            }
        }
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (dgvPedido.Rows[e.RowIndex].Cells[0].Value != null)
                        pedido.EliminarPedido(dgvPedido.Rows[e.RowIndex].Cells[0].Value + "");
                    dgvPedido.Rows.Remove(dgvPedido.Rows[e.RowIndex]);
                }
            }
            catch
            {
                CMsgBox.DisplayWarning("No se puede eliminar");
            }
        }
        private void dgvPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPedido.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.basura24px;
        }
        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectIndexChange)
            {
                dgvPedido.Rows.Clear();
                DataTable dt = pedido.CargarPedido(UCcboxCliente.cboxCliente.SelectedValue + "");
                int i = 0;
                foreach (DataRow rows in dt.Rows)
                {
                    dgvPedido.Rows.Add();
                    dgvPedido.Rows[i].Cells[0].Value = rows[0];
                    dgvPedido.Rows[i].Cells[1].Value = rows[1];
                    dgvPedido.Rows[i].Cells[3].Value = rows[2];
                    dgvPedido.Rows[i].Cells[4].Value = rows[3];
                    i++;
                }
            }
            SelectIndexChange = true;
        }

        #region Panel Barra
        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            DialogResult result = CMsgBox.DisplayConfirmation("¿Seguro que desea cerrar?");
            if (result == DialogResult.Yes)
                Close();
        }
        private void Pedido_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion
    }
}
