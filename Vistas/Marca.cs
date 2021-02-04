using MultimodeSales.Programacion;
using System;
using System.Data;
using System.Windows.Forms;
using MultimodeSales.Programacion.Marca;
using MultimodeSales.Programacion.Utilerias;
using System.Drawing;

namespace MultimodeSales.Vistas
{
    public partial class Marca : Form
    {
        CMarcaBD marca = new CMarcaBD();
        DataTable dt = new DataTable();
        private int Rowindex;

        public Marca()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvMarcas);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarMarca);
            CRoundButton.FormattedRoundButtonAceptar(rbtnEditarMarca);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Marcas";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            LlenarDataGridViewMarca();
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LlenarDataGridViewMarca()
        {
            dgvMarcas.DataSource = null;
            dt.Clear();
            dt = marca.VerMarcas();
            dgvMarcas.DataSource = dt;
            dgvMarcas.Columns[0].HeaderText = "ID Marca";
            dgvMarcas.Columns[0].Width = 200;
            dgvMarcas.Columns[1].Width = 650;
        }
        private void rbtnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombreMarca.Text) || String.IsNullOrWhiteSpace(txtIDMarca.Text))
                CMsgBox.DisplayWarning("No pueden estar los campos vacios de ID de Marca o Nombre");
            else
            {
                int cont = 0;
                for (int i = 0; i < dgvMarcas.Rows.Count; i++)
                {
                    if (txtIDMarca.Text == dgvMarcas.Rows[i].Cells[0].Value.ToString())
                        cont++;
                }
                if (cont >= 1)
                    CMsgBox.DisplayWarning("No pueden existir dos ID's iguales, intente con otro ID");
                else
                {
                    marca.AgregarMarca(txtIDMarca.Text, txtNombreMarca.Text);
                    CMsgBox.DisplayConfirmation("Se agrego nueva marca");
                    LlenarDataGridViewMarca();
                }
            }
        }

        private void rbtnEditarMarca_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (int i = 0; i < dgvMarcas.Rows.Count; i++)
            {
                if (txtIDMarca.Text == dgvMarcas.Rows[i].Cells[0].Value.ToString())
                    if (Rowindex != dgvMarcas.Rows[i].Index)
                        cont++;
            }
            if (cont >= 1)
                CMsgBox.DisplayWarning("No pueden existir dos marcas con ID's Iguales, intente con otro ID");
            else
            {
                rbtnAgregarMarca.Enabled = true;
                rbtnEditarMarca.Enabled = false;
                rbtnCancelar.Visible = false;
                marca.EditarMarca(txtIDMarca.Tag + "", txtIDMarca.Text, txtNombreMarca.Text);
                CMsgBox.DisplayInfo("Se edito la marca correctamente");
                BorrarDatos();
                LlenarDataGridViewMarca();
            }
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            BorrarDatos();
            rbtnAgregarMarca.Enabled = true;
            rbtnEditarMarca.Enabled = false;
            rbtnCancelar.Visible = false;
        }
        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                rbtnAgregarMarca.Enabled = false;
                rbtnEditarMarca.Enabled = true;
                rbtnCancelar.Visible = true;
                txtIDMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                txtNombreMarca.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
                txtIDMarca.Tag = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                Rowindex = e.RowIndex;
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert(IDMarca, 'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%'", txtBuscar.Text);
            dgvMarcas.DataSource = dv;
        }
        private void BorrarDatos()
        {
            txtIDMarca.Text = "";
            txtNombreMarca.Text = "";
        }
        #region Validaciones
        private void txtNumeroMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasyNumeros(sender, e);
        }
        #endregion
        #region Panel Barras
        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Marca_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion
    }
}
