using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Folios
{
    public class CListIDPedidosDevolucion
    {
        private List<string> listVentas;
        private List<string> listDevoluciones;
        public CListIDPedidosDevolucion(List<string> list)
        {
            listVentas = list;
        }
        public CListIDPedidosDevolucion(List<string> list, string textoinutil)
        {
            listDevoluciones = list;
        }
        public bool devolucionYaAgregadaVenta()
        {
            foreach (string IDVenta in listVentas)
            {
                foreach (string IDDevolucion in listDevoluciones)
                {
                    if (IDVenta == IDDevolucion)
                        return false;
                }
            }
            return true;
        }
    }
}
