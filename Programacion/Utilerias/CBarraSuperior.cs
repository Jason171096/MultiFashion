using System;
using System.Runtime.InteropServices;

namespace MultiFashion.Programacion
{
    public static class CBarraSuperior
    {
        private static IntPtr getInt;
        public static IntPtr GetInt { get => getInt; set => getInt = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static void Release(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(getInt, 0xA1, 0x2, 0);
        }
    }

    
}
