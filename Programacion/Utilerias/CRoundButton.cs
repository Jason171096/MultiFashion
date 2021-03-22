using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MultiFashion.Programacion.Utilerias
{
    public static class CRoundButton
    {
        public static void FormattedRoundButtonAceptar(RoundButton.RoundButton button)
        {
            button.BorderColor = Color.DarkBlue;
            button.ButtonColor = Color.Indigo;
            button.OnHoverBorderColor = Color.Indigo;
            button.OnHoverButtonColor = Color.DarkOrchid;
            FormatFontRoundButton(button);
        }
        public static void FormattedRoundButtonCancelar(RoundButton.RoundButton button)
        {
            button.BorderColor = Color.Indigo;
            button.ButtonColor = Color.DarkBlue;
            button.OnHoverBorderColor = Color.DarkBlue;
            button.OnHoverButtonColor = Color.Blue;
            FormatFontRoundButton(button);
        }
        public static void FormattedRoundButtonEliminar(RoundButton.RoundButton button)
        {
            
            button.BorderColor = Color.Brown;
            button.ButtonColor = Color.Red;
            button.OnHoverBorderColor = Color.Red;
            button.OnHoverButtonColor = Color.DarkRed;
            FormatFontRoundButton(button);
        }
        public static void FormattedRoundButtonExcel(RoundButton.RoundButton button)
        {

            button.BorderColor = Color.DarkGreen;
            button.ButtonColor = Color.Green;
            button.OnHoverBorderColor = Color.Green;
            button.OnHoverButtonColor = Color.DarkGreen;
            FormatFontRoundButton(button);
        }

        private static void FormatFontRoundButton(RoundButton.RoundButton button)
        {
            button.BackColor = Color.Transparent;
            button.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            button.FlatStyle = FlatStyle.Flat;
            button.OnHoverTextColor = Color.GhostWhite;
            button.TextColor = Color.GhostWhite;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.NavajoWhite;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.Cursor = Cursors.Hand;
        }
    }
}
