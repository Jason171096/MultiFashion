using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Devolucion;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Ventas
{
    public partial class Venta : Form
    {
        CDevolucionBD cDevolucion = new CDevolucionBD();
        CListaPedidosFinal pedidosFinal = new CListaPedidosFinal();
        CModelo cModelo = new CModelo();
        CVenta cVenta = new CVenta();
        CPedidoBD cPedido = new CPedidoBD();
        DataTable dtPedidos;
        DataTable dtPedidosDevueltos;
        private bool ventaCompleta;
        private string idcliente;

        public Venta()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvVentasPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelTodo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAplicarDevolucion);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarPedido);
            CRoundButton.FormattedRoundButtonCancelar(rbtnVender);

            UCcboxCliente.cboxCliente.SelectedIndexChanged += new EventHandler(cboxCliente_SelectedIndexChanged);
            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Venta";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        
        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtnAplicarDevolucion.Enabled = true;
            idcliente = UCcboxCliente.cboxCliente.SelectedValue + "";
            CargarPedidos(idcliente);
            CargaPedidosDevueltos(idcliente);
            borrarLabels();
        }
        private void CargarPedidos(string pIDCliente)
        {
            dgvVentasPedido.Rows.Clear();
            dtPedidos = pedidosFinal.ObtenerPedidoFinalLlego(pIDCliente);
            foreach (DataRow rows in dtPedidos.Rows)
            {
                dgvVentasPedido.Rows.Add(rows[0], rows[1], rows[2], rows[3], rows[4], rows[5]);
            }
        }
        private void CargaPedidosDevueltos(string pIDCliente)
        {
            dtPedidosDevueltos = cDevolucion.obtenerDevoluciones(pIDCliente);
            int countPedidosDevueltos = dtPedidosDevueltos.Rows.Count;
            if (countPedidosDevueltos > 0)
            {
                rbtnAplicarDevolucion.Visible = true;
            }
            else
            {
                rbtnAplicarDevolucion.Visible = false;
            }
        }

        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvVentasPedido.SelectedRows.Count >= 1)
            {
                //try
                //{
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                        {
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                            actualizarTotal();
                        }
                        else
                        {
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                            actualizarTotal();
                        }
                    }
                //}
            }
            //catch(Exception ex)
            //{
                //CMsgBox.DisplayError($"Error al seleccionar un modelo \n Mensaje: \n {ex.Message}");
            //}
        }
        private void rbtnSelTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor != Color.YellowGreen && rows.DefaultCellStyle.BackColor != Color.Blue)
                {
                    rows.DefaultCellStyle.BackColor = Color.YellowGreen;
                    rows.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                    actualizarTotal();
                }
            }
        }

        private void rbtnVender_Click(object sender, EventArgs e)
        {
            if (seleccioneCliente())
            {
                if(folioVacio())
                {
                    if (articulosVacios())
                    {
                        if(!verificarFolioExistente())
                        {
                            dialogVenta();
                            ventaConcreta();
                        }
                    }
                }
            }
        }

        private void rbtnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (seleccioneCliente())
            {
                PedidosFinal final = new PedidosFinal(true);
                final.ShowDialog();
                cModelo = final.returnModelo();
                agregarModelo();
            }
        }

        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            if (seleccioneCliente())
            {
                Modeloss modelos = new Modeloss(true);
                modelos.ShowDialog();
                cModelo = modelos.returnModelo();
                agregarModelo();
            }
        }
        private void borrarLabels()
        {
            lbCantidad.Text = "0";
            lbTotal.Text = "$0.00";
        }
        private void agregarModelo()
        {
            if (cModelo.IDModelo != null)
            {
                dgvVentasPedido.Rows.Add(cModelo.IDPedido, cModelo.IDModelo, cModelo.IDMarca, cModelo.Color, cModelo.Talla, cModelo.PrecioCliente);
            }
        }
        private void actualizarTotal()
        {
            float total = 0;
            int cantidad = 0;
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                {
                    total += float.Parse(rows.Cells[5].Value.ToString().Trim('$'));
                    cantidad++;
                }
                else if (rows.DefaultCellStyle.BackColor == Color.Blue)
                    total -= float.Parse(rows.Cells[5].Value.ToString().Trim('$'));
            }
            lbCantidad.Text = cantidad.ToString();
            lbTotal.Text = string.Format("{0:C}", total);
        }
        private void rbtnAplicarDevolucion_Click(object sender, EventArgs e)
        {
            foreach (DataRow rows in dtPedidosDevueltos.Rows)
            {
                dgvVentasPedido.Rows.Add(rows[0], rows[1], rows[2], rows[3], rows[4], rows[5]);
                int dgvTheLastRow = dgvVentasPedido.Rows.Count - 1;
                dgvVentasPedido.Rows[dgvTheLastRow].DefaultCellStyle.BackColor = Color.Blue;
                dgvVentasPedido.Rows[dgvTheLastRow].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            }
            actualizarTotal();
            rbtnAplicarDevolucion.Enabled = false;
        }
        private bool seleccioneCliente()
        {
            if (UCcboxCliente.cboxCliente.SelectedIndex != UCcboxCliente.cboxCliente.Items.Count - 1)
                return true;
            else
            {
                CMsgBox.DisplayWarning("Selecciona un cliente");
                return false;
            }

        }
        private bool folioVacio()
        {
            if (!string.IsNullOrWhiteSpace(txtFolioVenta.Text))
                return true;
            else
            {
                CMsgBox.DisplayWarning("No dejar el Folio vacio");
                return false;
            }
        }
        private bool articulosVacios()
        {
            int cont = 0;
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                    cont++;
            }
            if (cont > 0)
                return true;
            else
            {
                CMsgBox.DisplayWarning("Seleccionar un articulo");
                return false;
            }
        }
        private bool verificarFolioExistente()
        {

            bool verificarIDFolio = cVenta.verificarFolioVentaExistente(txtFolioVenta.Text);
            if (verificarIDFolio)
            {
                CMsgBox.DisplayWarning("Folio existente");
                return true;
            }
            else
                return false;
        }
        private void dialogVenta()
        {
            DialogVenta dialog = new DialogVenta(txtFolioVenta.Text, UCcboxCliente.cboxCliente.SelectedValue.ToString(), lbTotal.Text);
            dialog.ShowDialog();
            ventaCompleta = dialog.ventaCompletada();
        }
        private void agregarPedidoProvisional()
        {
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                {
                    if (rows.Cells[0].Value == null)
                    {
                        rows.Cells[0].Value = cPedido.AgregarPedidoProvisional(rows.Cells[1].Value.ToString(), UCcboxCliente.cboxCliente.SelectedValue.ToString(), rows.Cells[3].Value.ToString(), rows.Cells[4].Value.ToString());
                    }
                    cVenta.ventaPedido(txtFolioVenta.Text, rows.Cells[0].Value.ToString());
                }
            }
        }
        private void ventaConcreta()
        {
            if (ventaCompleta)
            {
                agregarPedidoProvisional();
                txtFolioVenta.Text = "";
                borrarLabels();
                CargarPedidos(idcliente);
            }
        }
        private void dgvVentasPedido_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            actualizarTotal();
        }
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
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
        private void Venta_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }

        #endregion
    }
}
