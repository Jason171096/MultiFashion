using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Devolucion;
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
        private string IDCLIENTE;
        public AplicarFolioDevoluciones(string pIDCliente)
        {
            InitializeComponent();
            IDCLIENTE = pIDCliente;
            styles();
            barraSuperior();
            cargarPedidosDevueltosCliente();
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

        
    }
}
