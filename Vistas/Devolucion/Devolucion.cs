using MultimodeSales.Programacion.Utilerias;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Vistas;
using MultimodeSales.Programacion.Modelo;

namespace MultimodeSales.Vistas
{
    public partial class Devolucion : Form
    {
        CVenta cVenta = new CVenta();
        CCliente cCliente = new CCliente();
        DataTable dt = new DataTable();
        CModelo cModelo = new CModelo();
        public Devolucion()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvDevolucion);
            CDataGridView.FormattedDataGridView(dgvDevolucion2);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAceptar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnBuscarFolio);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelModelo);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Devolución";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Size = new Size(880, 475);
            rbtnCancelar.Location = new Point(11, 407);
            rbtnAceptar.Location = new Point(718, 407);
            mtDivider.Visible = false;
            gBoxCambio.Visible = false;
            darFormatoForm();
        }

        private void checkCambioModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCambioModelo.Checked)
            {
                Size = new Size(880, 695);
                rbtnCancelar.Location = new Point(17, 650);
                rbtnAceptar.Location = new Point(718, 650);
                mtDivider.Visible = true;
                gBoxCambio.Visible = true;
                darFormatoForm();
            }
            else
            {
                Size = new Size(880, 475);
                rbtnCancelar.Location = new Point(11, 407);
                rbtnAceptar.Location = new Point(718, 407);
                mtDivider.Visible = false;
                gBoxCambio.Visible = false;
                darFormatoForm();
            }
        }
        private void rbtnBuscarFolio_Click(object sender, EventArgs e)
        {
            borrar();
            Folio folio = new Folio(true, true);
            folio.ShowDialog();
            cVenta = folio.returnVenta();
            cCliente = folio.returnCliente();
            txtIDFolio.Text = cVenta.IDVenta;
            UCcomboBox.cboxCliente.SelectedValue = Convert.ToInt32(cCliente.IDCliente);
            dt = cVenta.verVentaPedidoModelo(cVenta.IDVenta);
            foreach (DataRow rows in dt.Rows)
            {
                dgvDevolucion.Rows.Add(rows[0].ToString(), rows[1].ToString(), rows[2].ToString(), rows[3].ToString(), rows[4].ToString(), rows[5].ToString());
            }
            totalLabels();
        }
        private void darFormatoTabla()
        {

        }

        private void darFormatoForm()
        {
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void rbtnSelPedido_Click(object sender, EventArgs e)
        {
            PedidosFinal pedidosFinal = new PedidosFinal(true);
            pedidosFinal.ShowDialog();
            cModelo = pedidosFinal.returnModelo();
            dgvDevolucion.Rows.Add(cModelo.IDPedido, cModelo.IDModelo, cModelo.IDMarca, cModelo.Color, cModelo.Talla, cModelo.PrecioCliente);
            totalLabels();
        }

        private void rbtnSelModelo_Click(object sender, EventArgs e)
        {
            Modeloss modelos = new Modeloss(true);
            modelos.ShowDialog();
            cModelo = modelos.returnModelo();
            dgvDevolucion2.Rows.Add(cModelo.IDPedido, cModelo.IDModelo, cModelo.IDMarca, cModelo.Color, cModelo.Talla, cModelo.PrecioCliente);
            totalLabels();
        }

        private void dgvDevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dgvDevolucion.Rows.Remove(dgvDevolucion.Rows[e.RowIndex]);
                totalLabels();
            }
        }

        private void dgvDevolucion2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dgvDevolucion2.Rows.Remove(dgvDevolucion2.Rows[e.RowIndex]);
                totalLabels();
            }
        }
        private void totalLabels()
        {
            float totalDev1 = 0, totalDev2 = 0;
            foreach (DataGridViewRow rows in dgvDevolucion.Rows)
            {
                totalDev1 += float.Parse(rows.Cells[5].Value.ToString().Trim('$'));
            }
            lbTotalDevolucion.Text = string.Format("{0:C}", totalDev1);
            foreach (DataGridViewRow rows in dgvDevolucion2.Rows)
            {
                totalDev2 += float.Parse(rows.Cells[5].Value.ToString().Trim('$'));
            }
            lbTotalDevolucion2.Text = string.Format("{0:C}", totalDev2);
        }
        private void borrar()
        {
            dgvDevolucion.Rows.Clear();
            lbTotalDevolucion.Text = "$0.00";
        }
        #region Panel Barras
        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Devolucion_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }

        #endregion
    }
}
