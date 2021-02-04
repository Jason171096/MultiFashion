using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MultimodeSales.Vistas
{
    public partial class TallasyColores : Form
    {
        CColoresyTallas colorytallas = new CColoresyTallas();
        public TallasyColores()
        {
            InitializeComponent();
            CargarColores();
            CargarTallas();

            CDataGridView.FormattedDataGridView(dgvColores);
            CDataGridView.FormattedDataGridView(dgvTallas);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarColor);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarTalla);
            CRoundButton.FormattedRoundButtonAceptar(rbtnEditarColor);
            CRoundButton.FormattedRoundButtonAceptar(rbtnEditarTalla);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelarColor);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelarTalla);
            CRoundButton.FormattedRoundButtonEliminar(rbtnEliminarColor);
            CRoundButton.FormattedRoundButtonEliminar(rbtnEliminarTalla);

            CBarraSuperior.GetInt = Handle;
            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.Text = "Tallas y Colores";
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void CargarColores()
        {
            dgvColores.DataSource = null;
            DataTable dt = colorytallas.VerColores();
            dgvColores.DataSource = dt;
            dgvColores.Columns[0].Visible = false;
        }
        public void CargarTallas()
        {
            dgvTallas.DataSource = null;
            DataTable dt = colorytallas.VerTallas();
            dgvTallas.DataSource = dt;
            dgvTallas.Columns[0].Visible = false;
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
        private void mouseMove(object sender, MouseEventArgs e)
        {
            CBarraSuperior.ReleaseCapture();
            CBarraSuperior.SendMessage(Handle, 0xA1, 0x2, 0);
        }
        #endregion
        #region Colores
        private void rbtnAgregarColor_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtColor.Text))
            {
                colorytallas.EditarColoresyTallas(1, 1, 0, txtColor.Text);
                CargarColores();
                BorrarSelectColor();
            }
            else
                CMsgBox.DisplayWarning("No se puede agregar un campo vacio");
        }

        private void rbtnEditarColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtTalla.Text))
                {
                    colorytallas.EditarColoresyTallas(1, 2, int.Parse(txtColor.Tag + ""), txtColor.Text);
                    rbtnEditarColor.Enabled = false;
                    rbtnAgregarColor.Enabled = true;
                    rbtnEliminarColor.Enabled = true;
                    rbtnCancelarColor.Visible = false;
                    CargarColores();
                    BorrarSelectColor();
                }
                else
                    CMsgBox.DisplayWarning("No se puede editar un campo vacio");
            }
            catch
            {
                CMsgBox.DisplayError("No se puede editar sin seleccionar nada");
            }
        }

        private void rbtnEliminarColor_Click(object sender, EventArgs e)
        {
            if (dgvColores.Rows.Count != 0)
            {
                colorytallas.EditarColoresyTallas(1, 3, int.Parse(dgvColores.CurrentRow.Cells[0].Value + ""), txtColor.Text);
                CargarColores();
                BorrarSelectColor();
            }
            else
                CMsgBox.DisplayWarning("No se puede eliminar sin seleccionar nada");
        }

        private void rbtnCancelarColor_Click(object sender, EventArgs e)
        {
            rbtnAgregarColor.Enabled = true;
            rbtnEliminarColor.Enabled = true;
            rbtnEditarColor.Enabled = false;
            rbtnCancelarColor.Visible = false;
            BorrarSelectColor();
        }
        private void dgvColores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtColor.Tag = dgvColores.CurrentRow.Cells[0].Value + "";
            txtColor.Text = dgvColores.CurrentRow.Cells[1].Value + "";
            rbtnAgregarColor.Enabled = false;
            rbtnEditarColor.Enabled = true;
            rbtnEliminarColor.Enabled = false;
            rbtnCancelarColor.Visible = true;
        }
        #endregion
        #region Tallas
        private void rbtnAgregarTalla_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTalla.Text))
            {
                colorytallas.EditarColoresyTallas(2, 1, 0, txtTalla.Text);
                CargarTallas();
                BorrarSelectTalla();
            }
            else
                CMsgBox.DisplayWarning("No se puede agregar un campo vacio");
        }

        private void rbtnEditarTalla_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtTalla.Text))
                {
                    colorytallas.EditarColoresyTallas(2, 2, int.Parse(txtTalla.Tag + ""), txtTalla.Text);
                    rbtnEditarTalla.Enabled = false;
                    rbtnEliminarTalla.Enabled = true;
                    rbtnAgregarTalla.Enabled = true;
                    rbtnCancelarTalla.Visible = false;
                    CargarTallas();
                    BorrarSelectTalla();
                }
                else
                    CMsgBox.DisplayWarning("No se puede editar un campo vacio");
            }
            catch
            {
                CMsgBox.DisplayError("No se puede editar sin seleccionar nada");
            }
        }

        private void rbtnEliminarTalla_Click(object sender, EventArgs e)
        {
            if (dgvTallas.Rows.Count != 0)
            {
                colorytallas.EditarColoresyTallas(2, 3, int.Parse(dgvTallas.CurrentRow.Cells[0].Value + ""), txtTalla.Text);
                CargarTallas();
                BorrarSelectTalla();
            }
            else
                CMsgBox.DisplayWarning("No se puede eliminar sin seleccionar nada");
        }

        private void rbtnCancelarTalla_Click(object sender, EventArgs e)
        {
            rbtnAgregarTalla.Enabled = true;
            rbtnEliminarTalla.Enabled = true;
            rbtnEditarTalla.Enabled = false;
            rbtnCancelarTalla.Visible = false;
            BorrarSelectTalla();
        }

        private void dgvTallas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTalla.Tag = dgvTallas.CurrentRow.Cells[0].Value + "";
            txtTalla.Text = dgvTallas.CurrentRow.Cells[1].Value + "";
            rbtnEliminarTalla.Enabled = false;
            rbtnAgregarTalla.Enabled = false;
            rbtnEditarTalla.Enabled = true;
            rbtnCancelarTalla.Visible = true;
        }
        #endregion

        private void BorrarSelectColor()
        {
            txtColor.Text = "";
            if(dgvColores.Rows.Count != 0)
                dgvColores.CurrentCell = dgvColores.Rows[0].Cells[1];
        }
        private void BorrarSelectTalla()
        {
            txtTalla.Text = "";
            if (dgvTallas.Rows.Count != 0)
                dgvTallas.CurrentCell = dgvTallas.Rows[0].Cells[1];
        }
    }
}
