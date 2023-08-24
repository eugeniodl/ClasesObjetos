using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletaVenta
{
    public class Boleta
    {
        public int numero { get; set; }
        public string nombreCliente { get; set; }
        public string direccionCliente { get; set; }
        public string cedulaCliente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string descripcionProducto { get; set; }
        public int cantidadProducto { get; set; }

        // Método para determinar el precio del producto
        public double DeterminaPrecio()
        {
            switch (descripcionProducto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PS4 (1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5 / DS5": return 69;
                case "MANDO PS4 / DS4": return 60;
            }

            return 0;
        }

        // Método para determinar el importe
        public double CalculaImporte()
        {
            return cantidadProducto * DeterminaPrecio();
        }
    }
}
