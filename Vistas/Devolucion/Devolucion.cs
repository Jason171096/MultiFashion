using MultimodeSales.Programacion.Utilerias;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;

namespace MultimodeSales.Vistas
{
    public partial class Devolucion : Form
    {
        CVenta cVenta = new CVenta();
        CCliente cCliente = new CCliente();
        DataTable dt = new DataTable();
        public Devolucion()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvDevolucion);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAceptar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnBuscarFolio);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);

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
            Folio folio = new Folio(true, true);
            folio.ShowDialog();
            cVenta = folio.returnVenta();
            cCliente = folio.returnCliente();
            txtIDFolio.Text = cVenta.IDVenta;
            UCcomboBox.cboxCliente.DisplayMember = cCliente.IDCliente;
            dt = cVenta.verVentaPedidoModelo(cVenta.IDVenta);
            foreach (DataRow rows in dt.Rows)
            {
                dgvDevolucion.Rows.Add(rows[0].ToString(), rows[1].ToString(), rows[2].ToString(), rows[3].ToString(), rows[4].ToString(), rows[5].ToString());
            }
            
        }
        private void darFormatoTabla()
        {

        }

        private void darFormatoForm()
        {
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
