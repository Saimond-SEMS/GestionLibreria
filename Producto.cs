using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Producto {
        public string codigo =  "";
        public string nombre = "";
        public double precio = 0;
        public int stockActual = 0;
        public int stockMinimo = 0;
        public Categoria categoria;

        public static List<Producto> productos = new List<Producto>();

        public static void RegistrarProducto( Producto producto ) {
            Producto.productos.Add( producto );
        }

        public Producto() {
            this.nombre = "";
            this.codigo = "";
            this.categoria = new Categoria();
        }
    }
}