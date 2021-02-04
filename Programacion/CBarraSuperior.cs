using MultimodeSales.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MultimodeSales.Programacion
{
    public static class CBarraSuperior
    {
        private static IntPtr getInt;
        public static IntPtr GetInt { get => getInt; set => getInt = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static void Release(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(getInt, 0xA1, 0x2, 0);
        }
    }

    
}
