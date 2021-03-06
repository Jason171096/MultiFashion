﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
using System.Linq;

namespace MultimodeSales.Vistas
{
    public partial class PedidosFinal : Form
    {
        CListaPedidosFinal listaPedidosFinal = new CListaPedidosFinal();
        DataTable dt;
        DataView dv;
        CModelo modelo = new CModelo();
        int activeCellClick = 0;
        int opcionBuscaroFecha = 0;

        public PedidosFinal(int pActiveCellClick)
        {
            InitializeComponent();
            activeCellClick = pActiveCellClick;
            rbtnNumPedido.Checked = true;
            rbtnTodos.Checked = true;

            styles();
            barraSuperior();
            radioButtonsEvents();
            
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void styles()
        {
            CDataGridView.FormattedDataGridView(dgvPedidosFinal);
            CRoundButton.FormattedRoundButtonAceptar(rbtnFinalizar);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
        }
        private void barraSuperior()
        {
            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Lista de pedidos";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;
        }
        private void radioButtonsEvents()
        {
            rbtnNumPedido.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnFecha.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnTodos.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
            rbtnLlegaron.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
            rbtnNoLlegaron.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
            rbtnVendidos.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
            rbtnDevueltos.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
        }

        private void PedidosFinal_Load(object sender, EventArgs e)
        {
            CargarLista();
            cargaDataView();
        }
        private void radioButtonBuscar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.TabIndex == 10)
            {//RadioButtonBuscar
                rbtnTodos.Checked = true;
                txtBuscar.Enabled = true;
                dtpFechaInicial.Enabled = dtpFechaFinal.Enabled = false;
                opcionBuscaroFecha = 0;
                CargarLista();
            }
            else if (rb.Checked && rb.TabIndex == 12)
            {//RadioButtonFecha
                rbtnTodos.Checked = true;
                txtBuscar.Enabled = false;
                dtpFechaInicial.Enabled = dtpFechaFinal.Enabled = true;
                opcionBuscaroFecha = 1;
                CargarLista();
            }
        }
        private void cargaDataView()
        {
            dv = new DataView(dt);
        }
        private void radioButtonOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.TabIndex == 20)
            {//RadioButtonTodos
                cargaDataView();
                borrarDataGridView();
                CargarLista();
                activarButtomFinalizarPedido(true);
            }
            else if (rb.Checked && rb.TabIndex == 25)
            {//RadioButtonLlegaron
                dv.RowFilter = "Llego = 1 AND Vendido = 0 AND Devuelto = 0";
                dgvPedidosFinal.DataSource = dv;
                DarFormatoTabla();
                activarButtomFinalizarPedido(false);
            }
            else if (rb.Checked && rb.TabIndex == 30)
            {//RadioButtonNoLlegaron
                dv.RowFilter = "Llego = 0 AND Vendido = 0 AND Devuelto = 0";
                dgvPedidosFinal.DataSource = dv;
                DarFormatoTabla();
                activarButtomFinalizarPedido(false);
            }
            else if(rb.Checked && rb.TabIndex == 35)
            {//RadioButtonVendieron
                dv.RowFilter = "Llego = 0 AND Vendido = 1 AND Devuelto = 0";
                dgvPedidosFinal.DataSource = dv;
                DarFormatoTabla();
                activarButtomFinalizarPedido(false);
            }
            else if(rb.Checked && rb.TabIndex == 40)
            {//RadioButtonDevueltos
                dv.RowFilter = "Llego = 0 AND Vendido = 0 AND Devuelto = 1";
                dgvPedidosFinal.DataSource = dv;
                DarFormatoTabla();
                activarButtomFinalizarPedido(false);
            }
        }

        private void CargarLista()
        {
            dgvPedidosFinal.DataSource = null;
            dt = listaPedidosFinal.ObtenerListaPedidosFinal(opcionBuscaroFecha, txtBuscar.Text, dtpFechaInicial.Value, dtpFechaFinal.Value);
            dgvPedidosFinal.DataSource = dt;
            paintRows();
            DarFormatoTabla();
        }

        private void DarFormatoTabla()
        {
            dgvPedidosFinal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvPedidosFinal.Columns[1].Width = 115;//IDCliente
            dgvPedidosFinal.Columns[1].HeaderText = "ID Cliente";
            dgvPedidosFinal.Columns[2].Width = 300;//NombreCliente
            dgvPedidosFinal.Columns[2].HeaderText = "Nombre Cliente";
            dgvPedidosFinal.Columns[3].Width = 150;//IDModelo
            dgvPedidosFinal.Columns[3].HeaderText = "ID Modelo";
            dgvPedidosFinal.Columns[4].Width = 150;//Marca
            dgvPedidosFinal.Columns[5].Width = 150;//Color
            dgvPedidosFinal.Columns[6].Width = 150;//Talla
            dgvPedidosFinal.Columns[7].Width = 170;//PrecioCliente
            dgvPedidosFinal.Columns[8].Width = 250;//Fecha
            dgvPedidosFinal.Columns[0].Visible = false;//IDPedido
            dgvPedidosFinal.Columns[9].Visible = false;//Llego
            dgvPedidosFinal.Columns[10].Visible = false;//Vendido
            dgvPedidosFinal.Columns[11].Visible = false;//Devuelto
        }
        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor != Color.OrangeRed && dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor != Color.Blue)
                {
                    if (dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor == Color.Green)
                    {
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                    }
                    else
                    {
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                    }
                }
            }
        }
        private void rbtnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.Green)
                    listaPedidosFinal.UpdatePedidoLlego(rows.Cells[0].Value.ToString(), "1");
                else
                    listaPedidosFinal.UpdatePedidoLlego(rows.Cells[0].Value.ToString(), "0");
            }
            CMsgBox.DisplayInfo("¡Pedido actualizado con exito!");
            CargarLista();
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            excel._Application app = new excel.Application();
            excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Rows.Font.Size = 14;
            try
            {
                for (int i = 0; i < dgvPedidosFinal.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvPedidosFinal.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvPedidosFinal.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPedidosFinal.Columns.Count; j++)
                    {
                        if (dgvPedidosFinal.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvPedidosFinal.Rows[i].Cells[j].Value.ToString();
                        else
                            worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            catch (Exception ex)
            {
                CMsgBox.DisplayError("Error al abrir Excel \n Mensaje: \n" + ex.Message);
            }
            finally
            {
                app.Quit();
                workbook = null;
                worksheet = null;
            }
        }
        private void borrarDataGridView()
        {
            dgvPedidosFinal.DataSource = null;
        }
        
        private void dgvPedidosFinal_Sorted(object sender, EventArgs e)
        {
            if (rbtnTodos.Checked)
                paintRows();
        }
        private void dgvPedidosFinal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activeCellClick == 1)
                asignarModeloNoVendido(e);
            else if (activeCellClick == 2)
                asignarModeloDevolucion(e);
        }
        private void asignarModeloNoVendido(DataGridViewCellEventArgs e)
        {
            if (dgvPedidosFinal.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.Indigo && dgvPedidosFinal.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.OrangeRed)
            {
                asignarModeloClase(e);
                Close();
            }
            else
                CMsgBox.DisplayWarning("No puede vender un pedido que ya esta vendido o que no llego");
        }
        private void asignarModeloDevolucion(DataGridViewCellEventArgs e)
        {
            if(dgvPedidosFinal.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.Blue && dgvPedidosFinal.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.Indigo)
            {
                asignarModeloClase(e);
                Close();
            }
            else
                CMsgBox.DisplayWarning("No puede devolver un pedido que no llego o ya devuelto");
        }
        private void asignarModeloClase(DataGridViewCellEventArgs e)
        {
            modelo.IDPedido = dgvPedidosFinal.Rows[e.RowIndex].Cells[0].Value.ToString();
            modelo.IDModelo = dgvPedidosFinal.Rows[e.RowIndex].Cells[3].Value.ToString();
            modelo.IDMarca = dgvPedidosFinal.Rows[e.RowIndex].Cells[4].Value.ToString();
            modelo.Color = dgvPedidosFinal.Rows[e.RowIndex].Cells[5].Value.ToString();
            modelo.Talla = dgvPedidosFinal.Rows[e.RowIndex].Cells[6].Value.ToString();
            modelo.PrecioCliente = dgvPedidosFinal.Rows[e.RowIndex].Cells[7].Value.ToString();
            Close();
        }
        private void paintRows()
        {
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if (rows.Cells[9].Value.ToString() == "0")
                {
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.BackColor = Color.Indigo;
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                }
                if (rows.Cells[9].Value.ToString() == "1" && rows.Cells[10].Value.ToString() == "0")
                {
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.BackColor = Color.Green;
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                }
                if(rows.Cells[10].Value.ToString() == "1")
                {
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                }
                if (rows.Cells[11].Value.ToString() == "1")
                {
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.BackColor = Color.Blue;
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                }
            }
        }
        public CModelo returnModelo()
        {
            return modelo;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarLista();
            //dv.RowFilter = $"IDModelo = {txtBuscar.Text}";
            //dgvPedidosFinal.DataSource = dv;
            //(dgvPedidosFinal.DataSource as DataTable).DefaultView.RowFilter = string.Format("IDModelo = {0}", txtBuscar.Text);
        }
        private void activarButtomFinalizarPedido(bool pActivo)
        {
            if (pActivo)
                rbtnFinalizar.Enabled = true;
            else
                rbtnFinalizar.Enabled = false;
        }
        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicial.Value > dtpFechaFinal.Value)
                dtpFechaInicial.Value = dtpFechaFinal.Value;
            changeDate();
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicial.Value > dtpFechaFinal.Value)
                dtpFechaFinal.Value = dtpFechaInicial.Value;
            changeDate();
        }
        private void changeDate()
        {
            CargarLista();
            cargaDataView();
            rbtnTodos.Checked = true;
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        #region Barra Superior
        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
        private void PedidosFinal_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }

        #endregion

        
    }
}


