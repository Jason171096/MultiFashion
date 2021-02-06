using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
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
        CListaPedidosFinal pedidosFinal = new CListaPedidosFinal();
        CModelo modelo = new CModelo();
        DataTable dtPedidos;
        private bool ventaCompleta;
        private string idcliente;

        public Venta()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvVentasPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelTodo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
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
            dgvVentasPedido.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvVentasPedido_ColumnHeaderMouseClick);
        }
        
        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcliente = UCcboxCliente.cboxCliente.SelectedValue + "";
            CargarPedidos(idcliente);
            borrarLabels();
        }
        private void CargarPedidos(string idcliente)
        {
            dgvVentasPedido.DataSource = null;
            dtPedidos = pedidosFinal.ObtenerPedidoFinalLlego(idcliente);
            dgvVentasPedido.DataSource = dtPedidos;
            darformatoTabla();
        }

        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvVentasPedido.SelectedRows.Count >= 1)
            {
                //try
                //{
                    if (e.KeyCode == Keys.Enter)
                    {
                        string lbprecioTotal = lbTotal.Text.Trim('$');
                        string cantidad = lbCantidad.Text;
                        string precioCliente = dgvVentasPedido.CurrentRow.Cells[5].Value.ToString();
                        if (dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                        {
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                            ActualizarLabels(1, lbprecioTotal, cantidad, precioCliente);
                        }
                        else
                        {
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                            dgvVentasPedido.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                            ActualizarLabels(2, lbprecioTotal, cantidad, precioCliente);
                        }
                    }
                //}
            }
            //catch(Exception ex)
            //{
                //CMsgBox.DisplayError($"Error al seleccionar un modelo \n Mensaje: \n {ex.Message}");
            //}
        }
        private void ActualizarLabels(int pSumaoResta, string plbPrecio, string pCantidad, string pPrecioCliente)
        {
            int totalCantidad = int.Parse(pCantidad);
            float precioCliente = float.Parse(pPrecioCliente.Trim('$'));
            float totalPrecio;
            if(pSumaoResta == 1)
            {
                totalPrecio = float.Parse(plbPrecio) - precioCliente;
                totalCantidad--;
            }
            else
            {    
                totalPrecio = float.Parse(plbPrecio) + precioCliente;
                totalCantidad++;
            }
            lbTotal.Text = string.Format("{0:C}", totalPrecio);
            lbCantidad.Text = totalCantidad + "";
        }
        private void rbtnSelTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor != Color.YellowGreen)
                {
                    rows.DefaultCellStyle.BackColor = Color.YellowGreen;
                    rows.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                    ActualizarLabels(2, lbTotal.Text.ToString().Trim('$'), lbCantidad.Text, rows.Cells[5].Value.ToString());
                }
            }
        }

        private void rbtnVender_Click(object sender, EventArgs e)
        {
            CVenta venta = new CVenta();
            int cont = 0;
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                    cont++;
            }
            if (UCcboxCliente.cboxCliente.SelectedIndex != UCcboxCliente.cboxCliente.Items.Count - 1)
            {
                if (txtFolio.Text != "")
                {
                    if (cont >= 1)
                    {
                        int idfolio = venta.verificarFolioExistente(txtFolio.Text);
                        if (idfolio == 1)
                            CMsgBox.DisplayWarning("Folio existente");
                        else
                        {
                            DialogVenta dialog = new DialogVenta(txtFolio.Text, UCcboxCliente.cboxCliente.SelectedValue.ToString(), lbTotal.Text);
                            dialog.ShowDialog();
                            ventaCompleta = dialog.ventaCompletada();
                            if(ventaCompleta)
                            {
                                foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
                                {
                                    venta.ventaPedido(txtFolio.Text, rows.Cells[0].Value.ToString());
                                }
                                txtFolio.Text = "";
                                CargarPedidos(idcliente);
                            }
                        }
                    }
                    else
                        CMsgBox.DisplayWarning("Seleccionar un articulo");
                }
                else
                    CMsgBox.DisplayWarning("No dejar el folio vacio");
            }
            else
                CMsgBox.DisplayWarning("Seleccionar un cliente");
        }

        private void rbtnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (UCcboxCliente.cboxCliente.SelectedIndex != UCcboxCliente.cboxCliente.Items.Count - 1)
            {
                borrarLabels();
                PedidosFinal final = new PedidosFinal(true);
                final.ShowDialog();
                modelo = final.returnModelo();
                agregarModelo();
            }
        }

        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            if (UCcboxCliente.cboxCliente.SelectedIndex != UCcboxCliente.cboxCliente.Items.Count - 1)
            {
                borrarLabels();
                Modeloss modelos = new Modeloss(true);
                modelos.ShowDialog();
                modelo = modelos.returnModelo();
                agregarModelo();
            }
        }

        private void borrarLabels()
        {
            lbCantidad.Text = "0";
            lbTotal.Text = "$0.00";
        }
        private void dgvVentasPedido_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            borrarLabels();
        }
        private void darformatoTabla()
        {
            dgvVentasPedido.Columns[0].Visible = false;//IDPedido
        }
        private void agregarModelo()
        {
            if (modelo.IDModelo != null)
            {
                dtPedidos.Rows.Add(modelo.IDPedido, modelo.IDModelo, modelo.IDMarca, modelo.Color, modelo.Talla, modelo.PrecioCliente);
                dgvVentasPedido.DataSource = null;
                dgvVentasPedido.DataSource = dtPedidos;
                darformatoTabla();
            }
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
