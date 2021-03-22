using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFashion.Programacion.Utilerias
{
    public static class CMsgBox
    {
        public static void DisplayInfo(string pMessage)
        {
            MessageBox.Show(pMessage, "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void DisplayWarning(string pMessage)
        {
            MessageBox.Show(pMessage, "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void DisplayError(string pMessage)
        {
            MessageBox.Show(pMessage, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult DisplayConfirmation(string pMessage)
        {
            return MessageBox.Show(pMessage, "¡Confirmación!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
        public static DialogResult DisplayRetry(string pMessage)
        {
            return MessageBox.Show(pMessage, "¡Reintentar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }
    }
}
