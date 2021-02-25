using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Folios;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MultimodeSales.Vistas.Folios;
using System;
using MultimodeSales.Programacion.Cliente;

namespace MultimodeSales.Vistas
{
    public partial class Folio : Form
    {
        CFolio cFolio = new CFolio();
        CFolioBD cFolioBD = new CFolioBD();
        CVenta cVenta = new CVenta();
        CCliente cCliente = new CCliente();
        private bool ventanaDevolucion;
        private bool ventanaFolio;
        private string IDFolio;
        private string IDCliente;
        private DateTime Fecha;
        private string Total;
        public Folio(){ }
        public Folio(bool pFolio, bool ventanaDevolucion)
        {
            InitializeComponent();
            this.ventanaDevolucion = ventanaDevolucion;
            ventanaFolio = pFolio;
            CDataGridView.FormattedDataGridView(dgvFolio);
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (pFolio)
            {
                UCBarraSuperior.lbTitle.Text = "Folios Ventas";
                cargarFoliosVentas();
            }
            else
            {
                UCBarraSuperior.lbTitle.Text = "Folios Devoluciones";
            }

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;
        }
        
        private void cargarFoliosVentas()
        {
            dgvFolio.DataSource = null;
            DataTable dtVentas = cFolioBD.verFoliosVentas();
            dgvFolio.DataSource = dtVentas;
            DarFormatoTabla();
        }

        private void DarFormatoTabla()
        {
            dgvFolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvFolio.Columns[0].Width = 100;//ID FOlio
            dgvFolio.Columns[1].Width = 125;//ID Cliente
            dgvFolio.Columns[2].Width = 250;//Fecha
            dgvFolio.Columns[3].Width = 150;//Total
        }
        private void dgvFolio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarVariables(e);
            if (ventanaDevolucion)
            {
                //cVenta.IDVenta = dgvFolio.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cCliente.IDCliente = dgvFolio.Rows[e.RowIndex].Cells[1].Value.ToString();
                //Close();
            }
            else if (ventanaFolio)
            {
                FolioVenta folioVenta = new FolioVenta(IDFolio, IDCliente, Fecha, Total);
                folioVenta.ShowDialog();
            }
        }
        private void asignarVariables(DataGridViewCellEventArgs e)
        {
            IDFolio = dgvFolio.Rows[e.RowIndex].Cells[0].Value.ToString();
            IDCliente = dgvFolio.Rows[e.RowIndex].Cells[1].Value.ToString();
            Fecha = DateTime.Parse(dgvFolio.Rows[e.RowIndex].Cells[2].Value.ToString());
            Total = dgvFolio.Rows[e.RowIndex].Cells[3].Value.ToString();
            cFolio.IDFolio = IDFolio;
            cFolio.IDCliente = IDCliente;
            cFolio.Fecha = Fecha;
            cFolio.Total = Total;
        }
        public CFolio returnFolioDetalles()
        {
            return cFolio;
        }
        public CVenta returnVenta()
        {
            return cVenta;
        }
        public CCliente returnCliente()
        {
            return cCliente;
        }

        #region Barra Superior
        private void picMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Folio_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion


    }
}
