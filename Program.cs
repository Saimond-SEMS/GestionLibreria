using Libreria.Helpers;
using Libreria.Productos;
using Libreria.Security;
using System.Diagnostics;

namespace Libreria
{
	internal static class Program
	{

		public static Usuario? user = null;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			CheckJsons();
			ApplicationConfiguration.Initialize();
			FormSession session = new FormSession();
			Application.Run(session);
		}

		static void CheckJsons()
		{
			if (!Directory.Exists(Helpers.Rutas.carpetaDatos))
				Directory.CreateDirectory(Helpers.Rutas.carpetaDatos);

			if ( !File.Exists( Helpers.Rutas.archivousuarios ) )
				File.WriteAllText(Helpers.Rutas.archivousuarios, "{}");
			
			if (!File.Exists( Helpers.Rutas.archivoCatalogo) )
				File.WriteAllText(Helpers.Rutas.archivoCatalogo, "{}");
			
			if (!File.Exists( Helpers.Rutas.archivoInventario))
				File.WriteAllText(Helpers.Rutas.archivoInventario, "{}");
		}
	}
}