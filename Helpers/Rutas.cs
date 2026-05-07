using System;

namespace Libreria.Helpers
{
	public static class Rutas
	{
		public static string archivoCatalogo =	$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}/datos/catalogo.json";
		public static string archivoInventario =$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}/datos/inventario.json";
		public static string archivousuarios =	$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}/datos/usuarios.json";
	}
}