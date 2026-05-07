using Libreria.Helpers;
using Libreria.Security;
using Libreria.Productos;
using System.Diagnostics;

namespace Libreria
{
    internal static class Program
    {
        public static List<Producto> productos = new();
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			//Persiste dos libros (en el archivo catálogo)
			Libro RussellA = new Libro("L234123", "Bertrand Russellio", "Pure Math", 1000, CategoriaArticulo.Libro, true);
			Libro NewtonB = new Libro("L444-9090", "Isaac Newton", "Principia Matemática", 800, CategoriaArticulo.Libro, false);

			Cuaderno Petete = new Cuaderno("C23234", 200, "Cuaderno Veraniego", 100, CategoriaArticulo.Cuaderno, true, "Petete");

			List<Libreria.Productos.Articulo> articulos = new List<Libreria.Productos.Articulo>();

			articulos.Add(RussellA);
			articulos.Add(NewtonB);
			articulos.Add(Petete);

			bool catalogoGuardado = DataManager.GuardaCatalogo(articulos);
			///FIN Bloque///


			//Lee el contenido del archivo catálogo
			List<Articulo> articulosLeidos = new List<Articulo>();

			articulosLeidos = DataManager.LeerCatalogo();

			Debug.WriteLine($"\nArtículos en el catálogo de productos:\n");

			foreach (Articulo articulo in articulosLeidos)
			{

				if (articulo.categoria == CategoriaArticulo.Libro)
					Debug.WriteLine($" Info Artículo : {((Libro)articulo).getArticleInfo()}");
				else
					Debug.WriteLine($" Info Artículo : {((Cuaderno)articulo).getArticleInfo()}");

			}
			///FIN Bloque///


			//Agrega al inventario y guarda en el disco

			Debug.WriteLine($"\n++++ INVENTARIO ++++\n");

			Inventario invent = new Inventario();

			invent.addArticulo(RussellA, 2);
			invent.addArticulo(NewtonB, 2);
			invent.addArticulo(Petete, 2);

			bool inventarioGuardado = DataManager.GuardarInventario(invent);

			///FIN Bloque///


			//Lee del inventario en el disco
			Inventario inventarioLeido = DataManager.LeerInventario();

			//Total y subtotales por categoría
			Debug.WriteLine($"Total de Items : {inventarioLeido.getTotaItems()}");
			Debug.WriteLine($"Total de Items por categoría:");

			foreach (CategoriaArticulo lacategoria in Enum.GetValues(typeof(CategoriaArticulo)))
			{
				Debug.WriteLine($"  Subtotal {lacategoria.ToString()} : {inventarioLeido.getTotaItems(lacategoria)}");
			}
			///FIN Bloque///


			//Borra un libro del inventario Leído del disco

			inventarioLeido.removerArticulo(CategoriaArticulo.Libro, "L234123");
			bool GuardadoLuegoDeEliminar = DataManager.GuardarInventario(inventarioLeido);

			///FIN Bloque///



			//Leyendo nuevamente todo el inventario para validar borrado en archivo

			Debug.WriteLine($"\n**Después de borrar un libro:\n");
			Inventario inventarioLeidoDeNuevo = DataManager.LeerInventario();

			//Total y subtotales por categoría
			Debug.WriteLine($"Total de Items : {inventarioLeidoDeNuevo.getTotaItems()}");
			Debug.WriteLine($"Total de Items por categoría:");

			//Recorriendo el enum de todas las categorías
			foreach (CategoriaArticulo lacategoria in Enum.GetValues(typeof(CategoriaArticulo)))
			{
				Debug.WriteLine($"Subtotal {lacategoria.ToString()} : {inventarioLeidoDeNuevo.getTotaItems(lacategoria)}");
			}
			///FIN Bloque///



			//Imprimiendo detalles de artículos en inventario  por cateoria

			//LIBROS
			Debug.WriteLine($"\nSolo categoría Libros:");
			foreach (Libro libro in inventarioLeidoDeNuevo.articulos[CategoriaArticulo.Libro])
			{

				Debug.WriteLine(libro.getArticleInfo());
			}


			//CUADERNOS
			Debug.WriteLine($" \nSolo categoría Cuadernos:");
			foreach (Cuaderno cuaderno in inventarioLeidoDeNuevo.articulos[CategoriaArticulo.Cuaderno])
			{

				Debug.WriteLine(cuaderno.getArticleInfo());

			}
			//FIN bloque




			//Imprimiendo todo el inventario sin filtro de categoría:
			Debug.WriteLine($" \nInventario Completo:");
			foreach (CategoriaArticulo lacategoria in Enum.GetValues(typeof(CategoriaArticulo)))
			{

				foreach (var itemInventario in inventarioLeidoDeNuevo.articulos[lacategoria])
				{

					Debug.WriteLine(itemInventario.getArticleInfo());

				}

			}



			//Imprimiendo Artículos que necestan reposición seegún parámetro: DataManager.minimoInventario
			Debug.WriteLine($" \nLos siguientes artículos necesitan reponerse, cantidad en inventario <= {DataManager.minimoInventario}:\n");

			List<Articulo> listaArticulosReponer = inventarioLeidoDeNuevo.getArticulosReponer();

			foreach (Articulo articuloReponer in listaArticulosReponer)
				Debug.WriteLine(articuloReponer.getArticleInfo());



			//Encoding/Decoding

			String password = "saimond";
			String encodedPassword = EncodeDecode.Encode(password);
			String decodedPassword = EncodeDecode.Decode(encodedPassword);

			Debug.WriteLine($"\n\nPlain: {password}");
			Debug.WriteLine($"Encoded: {encodedPassword}");
			Debug.WriteLine($"Decoded: {decodedPassword}");

			/*Credenciales validas en el archivo usuarios.json
          
            saimond/saimond
            carmen/metallica

             */
			String nombreUsuario = "";

			Debug.WriteLine($" \nValidando saimond/saimond:");
			nombreUsuario = DataManager.validateCredentials("saimond", "saimond");
			Debug.WriteLine($"Nombre Usuario:{nombreUsuario}");

			Debug.WriteLine($" \nValidando carmen/metallica:");
			nombreUsuario = DataManager.validateCredentials("carmen", "metallica");
			Debug.WriteLine($"Nombre Usuario:{nombreUsuario}");

			Debug.WriteLine($" \nValidando usuariomarciano/galileo:");
			nombreUsuario = DataManager.validateCredentials("usuariomarciano", "galileo");
			Debug.WriteLine($"Nombre Usuario:{nombreUsuario}");


			Debug.WriteLine("\nFin");


			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static bool RegistrarProducto( Producto _producto )
        {
			if ( CodigoEstaDisponible(_producto.codigo) )
			{
                productos.Add(_producto);
                return true;
			}
            return false;
		}

        public static bool CodigoEstaDisponible( string _codigo)
        {
			foreach (Producto producto in productos)
			{
				if ( producto.codigo == _codigo)
				{
                    return false;
				}
			}
            return true;
		}
        public static Producto? BuscarProductoPorCodigo( string _codigo)
        {
			foreach (Producto producto in productos)
			{
				if ( producto.codigo == _codigo)
				{
					return producto;
				}
			}
            return null;
		}
    }
}