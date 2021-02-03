using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion
{
    public class Validaciones
    {
        public static void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsSeparator(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public static void SoloDecimales(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.')
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        public static void NumerosNegativoYPositivo(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '-')
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        public static void SoloLetrasyNumeros(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
