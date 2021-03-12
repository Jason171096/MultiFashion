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
        DataTable dtPedidosAplicados;
        DataTable dtReturnDevueltos = new DataTable();
        private string IDCLIENTE;
        public AplicarFolioDevoluciones(string pIDCliente, DataTable pdtPedidosAplicados)
        {
            InitializeComponent();
            IDCLIENTE = pIDCliente;
            dtPedidosAplicados = pdtPedidosAplicados;
            styles();
            barraSuperior();
            cargarPedidosDevueltosCliente();
            verificarSiYaEstaEnVenta();
        }
        private void verificarSiYaEstaEnVenta()
        {
            if (dtPedidosAplicados != null)
            {
                foreach (DataRow rows in dtPedidosAplicados.Rows)
                {
                    for (int i = 0; i < dgvDevoluciones.RowCount; i++)
                    {
                        string dgvIDPedido = dgvDevoluciones.Rows[i].Cells[0].Value.ToString();
                        string dtIDPedidoAplicado = rows[0].ToString();
                        if (dgvIDPedido == dtIDPedidoAplicado)
                        {
                            dgvDevoluciones.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                            dgvDevoluciones.Rows[i].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                        }
                    }
                }
            }
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

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addColumnsTable()
        {
            dtReturnDevueltos.Columns.Add("IDPedido");
            dtReturnDevueltos.Columns.Add("Modelo");
            dtReturnDevueltos.Columns.Add("Marca");
            dtReturnDevueltos.Columns.Add("Color");
            dtReturnDevueltos.Columns.Add("Talla");
            dtReturnDevueltos.Columns.Add("PrecioCliente");
        }
        private void rbtnAceptar_Click(object sender, EventArgs e)
        {
            addColumnsTable();
            foreach (DataGridViewRow rows in dgvDevoluciones.Rows)
            {
                if(rows.DefaultCellStyle.BackColor == Color.Green)
                {
                    dtReturnDevueltos.Rows.Add(rows.Cells[0].Value.ToString(), rows.Cells[2].Value.ToString(),
                        rows.Cells[3].Value.ToString(), rows.Cells[4].Value.ToString(),
                        rows.Cells[5].Value.ToString(), rows.Cells[6].Value.ToString());
                }
            }
            Close();
        }

        public DataTable returnsModelos()
        {
            return dtReturnDevueltos;
        }
    }
}
