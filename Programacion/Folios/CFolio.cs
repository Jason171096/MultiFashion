using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFashion.Programacion.Folios
{
    public class CFolio
    {
        private string idfolio;
        private string idcliente;
        private DateTime fecha;
        private string total;

        public string IDFolio { get => idfolio; set => idfolio = value; }
        public string IDCliente { get => idcliente; set => idcliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Total { get => total; set => total = value; }
    }
}
