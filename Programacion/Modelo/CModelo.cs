using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Modelo
{
    public class CModelo
    {
        private string idPedido;
        private string idModelo;
        private string idMarca;
        private string color;
        private string talla;
        private string precioCliente;

        public string IDPedido { get => idPedido; set => idPedido = value; }
        public string IDModelo { get => idModelo; set => idModelo = value; }
        public string IDMarca { get => idMarca; set => idMarca = value; }
        public string Color { get => color; set => color = value; }
        public string Talla { get => talla; set => talla = value; }
        public string PrecioCliente { get => precioCliente; set => precioCliente = value; }

        
    }
}