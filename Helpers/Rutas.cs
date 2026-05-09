using System;

namespace Libreria.Helpers
{
	public static class Rutas
	{
		public static string archivoCatalogo =	$"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/libreria/catalogo.json";
		public static string archivoInventario =$"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/libreria/inventario.json";
		public static string archivousuarios =	$"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/libreria/usuarios.json";
	}
}