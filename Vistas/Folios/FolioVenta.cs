using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Folios;
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
        ToolTip tip = new ToolTip();
        Folio folio = new Folio();
        public FolioVenta(string pIDFolioVenta, string pIDCliente, DateTime pDate, string pTotal)
        {
            InitializeComponent();
            CFolio cFolio = folio.returnFolioDetalles();
            txtFolio.Text = cFolio.IDFolio;
            UCdgvModelos.cargarFolioVentaModelos(pIDFolioVenta);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Folio Venta";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            txtFolio.Text = pIDFolioVenta;
            UCcboxCliente.cboxCliente.SelectedValue = pIDCliente;
            dtpFecha.Value = pDate;
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picEditFolio_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(picEditFolio, "Editar Folio");
        }

        private void picImprimir_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(picImprimir, "Imprimir Folio");
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
        private void FolioVenta_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion
    }
}
