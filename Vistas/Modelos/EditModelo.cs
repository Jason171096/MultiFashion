using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Marca;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MultimodeSales.Vistas.Modelos
{
    public partial class EditModelo : Form
    {
        CMarcaBD marca = new CMarcaBD();
        CModelosDB modelo = new CModelosDB();
        private readonly bool Bandera;

        public EditModelo(bool agregar, string idmodelo, string idmarca, string color, string talla, string precioCliente)
        {
            InitializeComponent();
            this.Bandera = agregar;
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);

            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(mouseMove);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(mouseMove);
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;

            
            LlenarComboBoxMarca();
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (agregar)
            {
                UCBarraSuperior.lbTitle.Text = "Agregar Modelo";
                rbtnAgregarModelo.Text = "Agregar Modelo";
            }
            else
            {
                UCBarraSuperior.lbTitle.Text = "Editar Modelo";
                rbtnAgregarModelo.Text = "Editar Modelo";
                txtIDModelo.Tag = idmodelo;
                txtIDModelo.Text = idmodelo;
                cobxMarca.SelectedValue = idmarca;
                txtColor.Text = color;
                txtTalla.Text = talla;
                txtPrecioCliente.Text = precioCliente;
            }
        }
        public void LlenarComboBoxMarca()
        {
            List<object[]> list = marca.VerMarcas2();
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("0", "--Elegir Marca--");
            foreach (object[] item in list)
            {
                keyValues.Add(item[0].ToString(), item[1].ToString());
            }
            cobxMarca.DataSource = new BindingSource(keyValues, null);
            cobxMarca.DisplayMember = "Value";
            cobxMarca.ValueMember = "Key";
        }
        private void BorrarDatos() 
        {
            txtIDModelo.Text = "";
            txtColor.Text = "";
            txtTalla.Text = "";
            txtPrecioCliente.Text = "";
            txtPrecioPublico.Text = "";
            cobxMarca.SelectedIndex = 0;
        }
        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIDModelo.Text) || !String.IsNullOrWhiteSpace(txtColor.Text)
               || !String.IsNullOrWhiteSpace(txtTalla.Text) || !String.IsNullOrWhiteSpace(txtPrecioPublico.Text))
            {
                if (cobxMarca.SelectedIndex != 0)
                    if (Bandera)
                    {
                        modelo.AgregarModelo(txtIDModelo.Text, cobxMarca.SelectedValue + "", txtColor.Text, txtTalla.Text, txtPrecioPublico.Text);
                        BorrarDatos();
                    }
                    else
                    {
                        modelo.EditarModelo(txtIDModelo.Tag + "", txtIDModelo.Text, cobxMarca.SelectedValue + "", txtColor.Text, txtTalla.Text, txtPrecioCliente.Text.Trim('$'));
                        CMsgBox.DisplayInfo("Modelo editado correctamente");
                        BorrarDatos();
                        Close();
                    }
                else
                    CMsgBox.DisplayWarning("Por favor de escoger la marca para el modelo");
            }
            else
                CMsgBox.DisplayWarning("Por favor de rellenar los espacios");
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtPrecioCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(sender, e);
        }
        private void txtPrecioPublico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(sender, e);
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
    }
}
