using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Devolucion;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Ventas
{
    public partial class AplicarFolioDevoluciones : Form
    {
        CDevolucionBD cDevolucion = new CDevolucionBD();
        DataTable dtPedidosDevueltos;
        DataTable dtAuxiliar = new DataTable();
        List<string> listIDPedidosAplicados;
        private string IDCLIENTE;
        public AplicarFolioDevoluciones(string pIDCliente, List<string> pListIDPedidosAplicados)
        {
            InitializeComponent();
            IDCLIENTE = pIDCliente;
            listIDPedidosAplicados = pListIDPedidosAplicados;
            styles();
            barraSuperior();
            cargarPedidosDevueltosCliente();
            agregarColumns();
        }
        private bool verificarSiYaEstaEnVenta()
        {
            foreach (DataGridViewRow rows in dgvDevoluciones.Rows)
            {
                foreach (string item in listIDPedidosAplicados)
                {
                    if (rows.Cells[0].Value.ToString() == item)
                    {
                        CMsgBox.DisplayWarning($"El pedido {item} ya existe en la ventana de Ventas");
                        return false;
                    }
                }
            }
            return true;
        }
        private void styles()
        {
            CRoundButton.FormattedRoundButtonAceptar(rbtnAceptar);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            CDataGridView.FormattedDataGridView(dgvDevoluciones);
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void barraSuperior()
        {
            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Pedidos Devueltos con Folio";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;
        }
        private void cargarPedidosDevueltosCliente()
        {
            dtPedidosDevueltos = cDevolucion.obtenerDevoluciones(IDCLIENTE);
            foreach (DataRow rows in dtPedidosDevueltos.Rows)
            {
                dgvDevoluciones.Rows.Add(rows[0].ToString(), rows[1].ToString(), rows[2].ToString(), rows[3].ToString(), rows[4].ToString(), rows[5].ToString(), rows[6].ToString());
            }
        }
        private void dgvDevoluciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvDevoluciones.CurrentRow.DefaultCellStyle.BackColor == Color.Green)
                {
                    dgvDevoluciones.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                    dgvDevoluciones.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                }
                else
                {
                    dgvDevoluciones.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                    dgvDevoluciones.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                }
            }
        }
        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void agregarColumns()
        {
            dtAuxiliar.Columns.Add("IDPedido");
            dtAuxiliar.Columns.Add("Modelo");
            dtAuxiliar.Columns.Add("Marca");
            dtAuxiliar.Columns.Add("Color");
            dtAuxiliar.Columns.Add("Talla");
            dtAuxiliar.Columns.Add("Precio Cliente");
        }
        private void rbtnAceptar_Click(object sender, EventArgs e)
        {
            if (verificarSiYaEstaEnVenta())
            {
                agregarDataGridViewaDatatable();
                Close();
            }
        }
        private void agregarDataGridViewaDatatable()
        {
            foreach (DataGridViewRow rows in dgvDevoluciones.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.Green)
                {
                    dtAuxiliar.Rows.Add(rows.Cells[0].Value.ToString(), rows.Cells[2].Value.ToString(),
                    rows.Cells[3].Value.ToString(), rows.Cells[4].Value.ToString(),
                    rows.Cells[5].Value.ToString(), rows.Cells[6].Value.ToString());
                }
            }
        }
        private void dgvDevoluciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (verificarSiYaEstaEnVenta())
            {
                agregarRowaDataTable(e);
                Close();
            }
        }

        private void agregarRowaDataTable(DataGridViewCellEventArgs e)
        {
            dtAuxiliar.Rows.Add(dgvDevoluciones.Rows[e.RowIndex].Cells[0].Value.ToString(),
                dgvDevoluciones.Rows[e.RowIndex].Cells[2].Value.ToString(),
                dgvDevoluciones.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dgvDevoluciones.Rows[e.RowIndex].Cells[4].Value.ToString(),
                dgvDevoluciones.Rows[e.RowIndex].Cells[5].Value.ToString(),
                dgvDevoluciones.Rows[e.RowIndex].Cells[6].Value.ToString());
        }
        public DataTable returnModelos()
        {
            return dtAuxiliar;
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
        private void AplicarFolioDevoluciones_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }


        #endregion
        
    }
}
