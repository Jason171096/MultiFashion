using MultiFashion.Programacion;
using MultiFashion.Programacion.Utilerias;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MultiFashion.Vistas.Folios
{
    public partial class TipoFolio : Form
    {
        public TipoFolio()
        {
            InitializeComponent();
            CRoundButton.FormattedRoundButtonAceptar(rbtnFolioDevoluciones);
            CRoundButton.FormattedRoundButtonAceptar(rbtnFolioVentas);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void rbtnFolioVentas_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(true, false);
            Close();
            folio.Show();
        }

        private void rbtnFolioDevoluciones_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(false, false);
            Close();
            folio.Show();
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
