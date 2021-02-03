using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Folios;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MultimodeSales.Vistas.Folios;

namespace MultimodeSales.Vistas
{
    public partial class Folio : Form
    {
        CFolio cFolio = new CFolio();
        CVenta cVenta = new CVenta();
        private bool ventanaDevolucion;
        private bool ventanaFolio;
        private int MX;
        private int MY;
        public Folio(bool pFolio, bool ventanaDevolucion)
        {
            InitializeComponent();
            this.ventanaDevolucion = ventanaDevolucion;
            ventanaFolio = pFolio;
            CDataGridView.FormattedDataGridView(dgvFolio);
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if(pFolio)
            {
                lbFolio.Text = "Folios Ventas";
                cargarFoliosVentas();
            }
            else
            {
                lbFolio.Text = "Folios Devoluciones";
            }
        }

        private void cargarFoliosVentas()
        {
            dgvFolio.DataSource = null;
            DataTable dtVentas = cFolio.verFoliosVentas();
            dgvFolio.DataSource = dtVentas;
            DarFormatoTabla();
        }

        private void DarFormatoTabla()
        {
            dgvFolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvFolio.Columns[0].HeaderText = "ID Folio";//IDFolio
            dgvFolio.Columns[0].Width = 100;
            //dgvFolio.Columns[1].HeaderText = "ID Cliente";//IDCliente
            dgvFolio.Columns[1].Width = 125;
            dgvFolio.Columns[2].Width = 250;//Fecha
            dgvFolio.Columns[3].Width = 150;//Total
        }

        #region Barra Superior
        private void picMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbFolio_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }
        #endregion

        private void dgvFolio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ventanaDevolucion)
            {
                cVenta.IDVenta = dgvFolio.Rows[e.RowIndex].Cells[0].Value.ToString();
                Close();
            }
            else if(ventanaFolio)
            {
                FolioVenta folioVenta = new FolioVenta();
                folioVenta.ShowDialog();
            }
        }

        public CVenta returnVenta()
        {
            return cVenta;
        }
    }
}
