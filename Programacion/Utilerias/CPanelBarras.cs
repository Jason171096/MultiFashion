using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion
{
    public class CPanelBarras
    {
        //private int MX = 0;
        //private int MY = 0;

        public void MouseMove(object sender, MouseEventArgs e, int Left, int Top, int MX, int MY)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }
    }
}
