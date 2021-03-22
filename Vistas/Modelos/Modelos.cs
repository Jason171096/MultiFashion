using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MultiFashion.Programacion;
using MultiFashion.Programacion.Modelo;
using MultiFashion.Programacion.Utilerias;
using System.Drawing;
using MultiFashion.Vistas;
using MultiFashion.Vistas.Modelos;

namespace MultiFashion.Vistas
{
    public partial class Modeloss : Form
    {
        CModelosDB modelos = new CModelosDB();
        DataTable dt = new DataTable();
        DataTable Data = new DataTable();
        private int count = 0, opcion = 1;
        private bool stop = false, activateCellClick = false;
        CModelo modelo = new CModelo();
        public Modeloss(bool pactiveCellClick)
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvModelos);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnEditarModelo);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Modelos";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            rbtnNumPedido.Checked = true;
            rbtnNumPedido.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnFecha.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);

            dtpFecha.MinDate = DateTime.Parse("01/01/2020");
            dtpFecha.MaxDate = DateTime.Now;

            Data.Columns.Add("Modelo");
            Data.Columns.Add("IDMarca");
            Data.Columns.Add("Marca");
            Data.Columns.Add("Color");
            Data.Columns.Add("Talla");
            Data.Columns.Add("Precio Cliente");
            Data.Columns.Add("Fecha");
            CargarModelos();
            activateCellClick = pactiveCellClick;
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void radioButtonBuscar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.TabIndex == 10)
            {//RadioButtonBuscar
                dtpFecha.Value = dtpFecha.MaxDate;
                dtpFecha.Enabled = false;
                txtBuscarModelo.Enabled = true;
                opcion = 1;
                CargarModelos();
            }
            else if (rb.Checked && rb.TabIndex == 12)
            {//RadioButtonFecha
                txtBuscarModelo.Text = "";
                txtBuscarModelo.Enabled = false;
                dtpFecha.Enabled = true;
                opcion = 2;
                CargarModelos();
            }
        }
        private void CargarModelos()
        {
            dt = modelos.ObtenerModelos(count, opcion, txtBuscarModelo.Text, dtpFecha.Value);
            AsignarTable();
            dgvModelos.DataSource = Data;
            DarFormatoTabla();
        }
        private void DarFormatoTabla()
        {
            dgvModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvModelos.Columns[1].Visible = false;//IDMarca
            dgvModelos.Columns[0].Width = 175;//IDModelo
            dgvModelos.Columns[2].Width = 175;//NombreMarca
            dgvModelos.Columns[3].Width = 175;//Color
            dgvModelos.Columns[4].Width = 175;//Talla
            dgvModelos.Columns[5].Width = 175;//PrecioCliente
            dgvModelos.Columns[6].Width = 300;//Fecha  
        }
        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            new EditModelo(true, "", "", "", "", "").ShowDialog();
            BorrarTable();
            CargarModelos();
        }

        private void rbtnEditarModelo_Click(object sender, EventArgs e)
        {
            if (dgvModelos.SelectedRows.Count > 0)
            {
                string idmodelo = dgvModelos.CurrentRow.Cells[0].Value + "";
                string idmarca = dgvModelos.CurrentRow.Cells[1].Value + "";
                string color = dgvModelos.CurrentRow.Cells[3].Value + "";
                string talla = dgvModelos.CurrentRow.Cells[4].Value + "";
                string precioCliente = dgvModelos.CurrentRow.Cells[5].Value + "";

                new EditModelo(false, idmodelo, idmarca, color, talla, precioCliente).ShowDialog();
                BorrarTable();
                CargarModelos();
            }
            else
                CMsgBox.DisplayWarning("Ningun modelo fue seleccionado para editar");
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            count = 0;
            BorrarTable();
            CargarModelos();
        }
        private void dgvModelos_Scroll(object sender, ScrollEventArgs e)
        {
            if (dgvModelos.DisplayedRowCount(false) + dgvModelos.FirstDisplayedScrollingRowIndex >= dgvModelos.Rows.Count && stop == false)
            {   
                count += 100;
                stop = true;
                CargarModelos();
            }
            else
                stop = false;
        }
        private void AsignarTable()
        {
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow rows in dt.Rows)
                {
                    Data.ImportRow(rows);
                }
            }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            BorrarTable();
            CargarModelos();
        }
        private void BorrarTable()
        {
            dgvModelos.DataSource = null;
            Data.Clear();
        }

        private void dgvModelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(activateCellClick)
            {
                modelo.IDModelo = dgvModelos.Rows[e.RowIndex].Cells[0].Value.ToString();
                modelo.IDMarca = dgvModelos.Rows[e.RowIndex].Cells[2].Value.ToString();
                modelo.Color = dgvModelos.Rows[e.RowIndex].Cells[3].Value.ToString();
                modelo.Talla = dgvModelos.Rows[e.RowIndex].Cells[4].Value.ToString();
                modelo.PrecioCliente = dgvModelos.Rows[e.RowIndex].Cells[5].Value.ToString();
                Close();
            }
        }
        public CModelo returnModelo()
        {
            return modelo;
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
        private void Modeloss_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion
    }
}
