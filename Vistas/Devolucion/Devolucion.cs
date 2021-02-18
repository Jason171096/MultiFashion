using MultimodeSales.Programacion.Utilerias;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Vistas;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Devolucion;

namespace MultimodeSales.Vistas
{
    public partial class Devolucion : Form
    {
        CDevolucionBD cDevolucion = new CDevolucionBD();
        CVenta cVenta = new CVenta();
        CCliente cCliente = new CCliente();
        DataTable dt = new DataTable();
        CModelo cModelo = new CModelo();
        public Devolucion()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvDevolucion);
            CDataGridView.FormattedDataGridView(dgvDevolucion2);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAceptar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnBuscarFolio);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelModelo);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Devolución";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Size = new Size(880, 450);
            rbtnCancelar.Location = new Point(11, 407);
            rbtnAceptar.Location = new Point(718, 407);
            mtDivider.Visible = false;
            gBoxCambio.Visible = false;
            darFormatoForm();
        }

        private void checkCambioModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCambioModelo.Checked)
            {
                Size = new Size(880, 695);
                rbtnCancelar.Location = new Point(11, 650);
                rbtnAceptar.Location = new Point(718, 650);
                mtDivider.Visible = true;
                gBoxCambio.Visible = true;
                darFormatoForm();
            }
            else
            {
                Size = new Size(880, 450);
                rbtnCancelar.Location = new Point(11, 407);
                rbtnAceptar.Location = new Point(718, 407);
                mtDivider.Visible = false;
                gBoxCambio.Visible = false;
                darFormatoForm();
            }
        }
        private void darFormatoForm()
        {
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void rbtnBuscarFolio_Click(object sender, EventArgs e)
        {
            borrarTodo();
            Folio folio = new Folio(true, true);
            folio.ShowDialog();
            cVenta = folio.returnVenta();
            cCliente = folio.returnCliente();
            txtFolioVenta.Text = cVenta.IDVenta;
            UCcboxCliente.cboxCliente.SelectedValue = Convert.ToInt32(cCliente.IDCliente);
            dt = cVenta.verVentaPedidoModelo(cVenta.IDVenta);
            foreach (DataRow rows in dt.Rows)
            {
                if(rows[8].ToString() != "1")
                    dgvDevolucion.Rows.Add(rows[0].ToString(), rows[1].ToString(), rows[2].ToString(), rows[3].ToString(), rows[4].ToString(), rows[5].ToString());
            }
            actualizarTotal();
        }
        private void rbtnSelPedido_Click(object sender, EventArgs e)
        {
            PedidosFinal pedidosFinal = new PedidosFinal(true);
            pedidosFinal.ShowDialog();
            cModelo = pedidosFinal.returnModelo();
            dgvDevolucion.Rows.Add(cModelo.IDPedido, cModelo.IDModelo, cModelo.IDMarca, cModelo.Color, cModelo.Talla, cModelo.PrecioCliente);
            actualizarTotal();
        }

        private void rbtnSelModelo_Click(object sender, EventArgs e)
        {
            Modeloss modelos = new Modeloss(true);
            modelos.ShowDialog();
            cModelo = modelos.returnModelo();
            dgvDevolucion2.Rows.Add(cModelo.IDPedido, cModelo.IDModelo, cModelo.IDMarca, cModelo.Color, cModelo.Talla, cModelo.PrecioCliente);
            actualizarTotal();
        }
        private void actualizarTotal()
        {
            float totalDev1 = 0, totalDev2 = 0;
            foreach (DataGridViewRow rows in dgvDevolucion.Rows)
            {
                totalDev1 += float.Parse(rows.Cells[5].Value.ToString().Trim('$'));
            }
            lbTotalDevolucion.Text = string.Format("{0:C}", totalDev1);
            foreach (DataGridViewRow rows in dgvDevolucion2.Rows)
            {
                totalDev2 += float.Parse(rows.Cells[5].Value.ToString().Trim('$'));
            }
            lbTotalDevolucion2.Text = string.Format("{0:C}", totalDev2);
            if (totalDev2 > totalDev1)
            {
                lbTotalDevolucion2.ForeColor = Color.Red;
            }
            else
            {
                lbTotalDevolucion2.ForeColor = Color.Black;
            }
        }
        private void borrarTodo()
        {
            dgvDevolucion.Rows.Clear();
            dgvDevolucion2.Rows.Clear();
            txtFolioVenta.Text = "";
            actualizarTotal();
        }
        private void checkBuscarFolio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBuscarFolio.Checked)
            {
                borrarTodo();
                rbtnBuscarFolio.Enabled = true;
                UCcboxCliente.cboxCliente.Enabled = false;
            }
            else
            {
                borrarTodo();
                rbtnBuscarFolio.Enabled = false;
                UCcboxCliente.cboxCliente.Enabled = true;
            }
        }

        private void rbtnAceptar_Click(object sender, EventArgs e)
        {
            if (seleccioneCliente())
                if (folioVacio())
                    if (articulosVacios())
                        if (!verificarFolioExistente())
                        {
                            checarCambioModelo();
                        }
        }
        private void dgvDevolucion_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            actualizarTotal();
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
            if (!string.IsNullOrWhiteSpace(txtFolioDevolucion.Text))
                return true;
            else
            {
                CMsgBox.DisplayWarning("No dejar el Folio vacio");
                return false;
            }
        }
        private bool articulosVacios()
        {
            if (dgvDevolucion.Rows.Count > 0)
                return true;
            else
            {
                CMsgBox.DisplayWarning("Seleccionar un articulo");
                return false;
            }
        }
        private bool verificarFolioExistente()
        {
            bool verificarIDFolio = cDevolucion.verificarFolioDevolucionExistente(txtFolioDevolucion.Text);
            if (verificarIDFolio)
            {
                CMsgBox.DisplayWarning("Folio existente");
                return true;
            }
            else
                return false;
        }
        private void checarCambioModelo()
        {
            if (!checkCambioModelo.Checked)
            {
                agregarDevolucion();
            }

        }
        private void agregarDevolucion()
        {
            foreach (DataGridViewRow rows in dgvDevolucion.Rows)
            {
                cDevolucion.agregarDevolucionFolio(txtFolioDevolucion.Text, UCcboxCliente.cboxCliente.SelectedValue.ToString(), DateTime.Now, lbTotalDevolucion.Text);
                cDevolucion.agregarDevolucionPedido(txtFolioDevolucion.Text, rows.Cells[0].Value.ToString());
            }
            CMsgBox.DisplayInfo("Devolucion confirmada");
            borrarTodo();
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
        private void Devolucion_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }

        #endregion
    }
}
