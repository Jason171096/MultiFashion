using MultimodeSales.Programacion;
using System;
using System.Drawing;
using System.Windows.Forms;
using MultimodeSales.Programacion.Utilerias;

namespace MultimodeSales.Vistas.Ventas
{
    public partial class DialogVenta : Form
    {
        CVenta venta = new CVenta();
        private bool ventaCompleta;
        private string total, idfolio, idcliente;
        public DialogVenta(string pIDFolio, string pIDCliente, string pTotal)
        {
            InitializeComponent();
            CRoundButton.FormattedRoundButtonAceptar(rbtnVender);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            rbtnVender.FlatAppearance.BorderColor = Color.Green;
            total = pTotal;
            idfolio = pIDFolio;
            idcliente = pIDCliente;
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void DialogVenta_Load(object sender, EventArgs e)
        {
            lbTotal.Text = total;
            lbCambio.Text = "$0.00";
            //txtCantidad.Text = "$0.00";
            lbCambio.ForeColor = Color.Red;
            txtCantidad.Focus();
            txtCantidad.SelectAll();
        }
        //float floatCantidad = float.Parse(txtCantidad.Text.Replace("$", ""));
        //txtCantidad.Text = string.Format("{0:C}", floatCantidad);

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(sender, e);
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            calcularCambio();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            calcularCambio();
        }

        private void rbtnVender_Click(object sender, EventArgs e)
        {
            if (lbCambio.ForeColor != Color.Red)
            {
                venta.ventaFolio(idfolio, idcliente, DateTime.Now, Convert.ToDouble(total.Trim('$')));
                CMsgBox.DisplayInfo("Venta concluida");
                Close();
                ventaCompleta = true;
            }
            else
            {
                CMsgBox.DisplayWarning("Ingrese una cantidad");
                ventaCompleta = false;
            }
        }

        public bool ventaCompletada()
        {
            return ventaCompleta;
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calcularCambio()
        {
            if (!String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                double doubleTotal = Double.Parse(total.Replace("$", ""));
                double doubleCantidad = Double.Parse(txtCantidad.Text);
                if (doubleTotal <= doubleCantidad)
                {
                    lbCambio.ForeColor = Color.Black;
                    rbtnVender.Enabled = true;
                    lbCambio.Text = string.Format("{0:C}", doubleCantidad - doubleTotal);
                }
                else
                {
                    lbCambio.ForeColor = Color.Red;
                    rbtnVender.Enabled = false;
                    lbCambio.Text = "$0.00";
                }
            }
        }
    }
}
