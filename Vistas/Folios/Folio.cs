﻿using MultimodeSales.Programacion;
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
        CFolioBD cFolio = new CFolioBD();
        CVenta cVenta = new CVenta();
        CCliente cCliente = new CCliente();
        private bool ventanaDevolucion;
        private bool ventanaFolio;
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
        private void dgvFolio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ventanaDevolucion)
            {
                cVenta.IDVenta = dgvFolio.Rows[e.RowIndex].Cells[0].Value.ToString();
                cCliente.IDCliente = dgvFolio.Rows[e.RowIndex].Cells[1].Value.ToString();
                Close();
            }
            else if (ventanaFolio)
            {
                FolioVenta folioVenta = new FolioVenta();
                folioVenta.ShowDialog();
            }
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
