using MultiFashion.Programacion;
using MultiFashion.Programacion.Modelo;
using MultiFashion.Programacion.Utilerias;
using MultiFashion.Vistas.Modelos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MultiFashion.Vistas
{
    public partial class Pedido : Form
    {
        CModelosDB cModelos = new CModelosDB();
        CPedidoBD cPedido = new CPedidoBD();
        CColoresyTallas cColoresyTallas = new CColoresyTallas();
        DataTable DataModels = new DataTable();
        private bool CellValueChange = false;

        public Pedido()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarColorTalla);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnFinalizarPedido);

            UCcboxCliente.cboxCliente.SelectedIndexChanged += new EventHandler(cboxCliente_SelectedIndexChanged);
            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Pedido";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Modelos();
            Colores();
            Tallas();
            IDMarca.ReadOnly = true;
            dgvPedido.Columns[0].Visible = false;
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            agregarIconoBasura(0);

        }
        private void Modelos()
        {
            DataTable dt = cModelos.ObtenerModelos2();
            IDModelo.DisplayMember = "IDModelo";
            IDModelo.DataSource = dt;
            DataModels = dt;
        }
        private void Colores()
        {
            DataTable dt = cColoresyTallas.VerColores();
            IDColor.DisplayMember = "Nombre";
            foreach (DataRow rows in dt.Rows)
            {
                IDColor.Items.Add(rows[1]);
            }
        }
        private void Tallas()
        {
            DataTable dt = cColoresyTallas.VerTallas();
            IDTalla.DisplayMember = "Numero";
            foreach (DataRow rows in dt.Rows)
            {
                IDTalla.Items.Add(rows[1]);
            }
        }
        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            EditModelo modelo = new EditModelo(true, "", "", "", "", "");
            modelo.ShowDialog();
            Modelos();
        }

        private void rbtnAgTaCo_Click(object sender, EventArgs e)
        {
            TallasyColores tallasyColores = new TallasyColores();
            tallasyColores.ShowDialog();
            Colores();
            Tallas();
        }
        private void rbtnFinalizarPedido_Click(object sender, EventArgs e)
        {
            int index = UCcboxCliente.cboxCliente.Items.Count - 1;
            if (index != UCcboxCliente.cboxCliente.SelectedIndex)
            {
                foreach (DataGridViewRow rows in dgvPedido.Rows)
                { 
                    if (rows.Cells[1].Value != null)
                    {
                        cPedido.AgregarPedido(rows.Cells[0].Value + "", rows.Cells[1].Value + "", UCcboxCliente.cboxCliente.SelectedValue + "", rows.Cells[3].Value + "", rows.Cells[4].Value + "");
                    }
                }
                CMsgBox.DisplayInfo("Pedido ingresado correctamente");
            }
            else
                CMsgBox.DisplayWarning("Seleccione un cliente");
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = CMsgBox.DisplayConfirmation("¿Seguro que desea cerrar?");
            if (result == DialogResult.Yes)
                Close();
        }
        private void dgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (CellValueChange)
                {
                    string value = dgvPedido.Rows[e.RowIndex].Cells[1].Value + "";
                    string marca = "";
                    foreach (DataRow rows in DataModels.Rows)
                    {
                        if (value == rows[0] + "")
                        {
                            marca = rows[2] + "";
                            break;
                        }
                    }
                    dgvPedido.Rows[e.RowIndex].Cells[2].Value = marca;
                }
                CellValueChange = true;
            }
        }
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (dgvPedido.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        bool confirmaPedidoEliminar = cPedido.confirmacionPedidoEliminar(dgvPedido.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (confirmaPedidoEliminar)
                            CMsgBox.DisplayWarning("No se puede eliminar un pedido que se vendio o que llego");
                        else
                            cPedido.EliminarPedido(dgvPedido.Rows[e.RowIndex].Cells[0].Value + "");
                    }
                    else
                        dgvPedido.Rows.Remove(dgvPedido.Rows[e.RowIndex]);
                }
            }
            catch
            {
                CMsgBox.DisplayWarning("No se puede eliminar");
            }
}
        private void dgvPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            agregarIconoBasura(e.RowIndex);
        }
        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPedido.Rows.Clear();
            DataTable dt = cPedido.CargarPedido(UCcboxCliente.cboxCliente.SelectedValue + "");
            int i = 0;
            foreach (DataRow rows in dt.Rows)
            {
                dgvPedido.Rows.Add();
                dgvPedido.Rows[i].Cells[0].Value = rows[0];
                dgvPedido.Rows[i].Cells[1].Value = rows[1];
                dgvPedido.Rows[i].Cells[3].Value = rows[2];
                dgvPedido.Rows[i].Cells[4].Value = rows[3];
                i++;
            }
        }
        private void agregarIconoBasura(int pRowIndex)
        {
            dgvPedido.Rows[pRowIndex].Cells[5].Value = Properties.Resources.basura24px;
        }

        private void dgvPedido_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    IDColor.Items.Add(dgvPedido.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    break;
                case 4:
                    IDTalla.Items.Add(dgvPedido.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    break;
                default:
                    break;
            }
        }
        #region Panel Barra
        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            DialogResult result = CMsgBox.DisplayConfirmation("¿Seguro que desea cerrar?");
            if (result == DialogResult.Yes)
                Close();
        }
        private void Pedido_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion
    }
}
