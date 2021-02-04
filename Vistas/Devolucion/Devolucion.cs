using MultimodeSales.Programacion.Utilerias;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MultimodeSales.Programacion;

namespace MultimodeSales.Vistas
{
    public partial class Devolucion : Form
    {
        CVenta cVenta = new CVenta();
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
            UCBarraSuperior.MouseMove += new MouseEventHandler(mouseMove);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(mouseMove);
            UCBarraSuperior.lbTitle.Text = "Devolución";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Size = new Size(880, 475);
            rbtnCancelar.Location = new Point(11, 407);
            rbtnAceptar.Location = new Point(718, 407);
            mtDivider.Visible = false;
            gBoxCambio.Visible = false;
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
            }
            else
            {
                Size = new Size(880, 475);
                rbtnCancelar.Location = new Point(11, 407);
                rbtnAceptar.Location = new Point(718, 407);
                mtDivider.Visible = false;
                gBoxCambio.Visible = false;
            }
        }
        private void rbtnBuscarFolio_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(true, true);
            folio.ShowDialog();
            cVenta = folio.returnVenta();
            txtIDFolio.Text = cVenta.IDVenta;
            dt = cVenta.verVentaPedidoModelo(cVenta.IDVenta);
            foreach (DataRow rows in dt.Rows)
            {
                dgvDevolucion.Rows.Add(rows[0].ToString(), rows[1].ToString(), rows[2].ToString(), rows[3].ToString(), rows[4].ToString(), rows[5].ToString());
            }
        }
        private void darFormatoTabla()
        {

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
        private void mouseMove(object sender, MouseEventArgs e)
        {
            CBarraSuperior.ReleaseCapture();
            CBarraSuperior.SendMessage(Handle, 0xA1, 0x2, 0);
        }
        #endregion
    }
}
