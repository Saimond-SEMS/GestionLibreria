using System;
using Libreria.Security;
using Libreria.Productos;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Libreria.Helpers
{
	public static class DataManager
	{

		public static int minimoInventario = 1;


		static List<Usuario> LeerUsuarios()
		{

			string jsonContent = File.ReadAllText(Rutas.archivousuarios);

			List<Usuario> usuariosLeidos = JsonConvert.DeserializeObject<List<Usuario>>(jsonContent);


			return usuariosLeidos;

		}

		public static string validateCredentials(string usuario, string clave)
		{


			string nombreUsuario = "0";

			List<Usuario> usuarios = LeerUsuarios();

			if (usuarios.Where(w => w.username.Trim() == usuario.Trim() && w.clave.Trim() == EncodeDecode.Encode(clave)).Any())
				nombreUsuario = usuarios.Where(w => w.username.Trim() == usuario.Trim() && w.clave.Trim() == EncodeDecode.Encode(clave)).Select(s => s.nombre).FirstOrDefault();


			return nombreUsuario;

		}


		public static bool GuardaCatalogo(List<Articulo> articulos)
		{
			try
			{

				if (articulos != null)
				{
					var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };

					string jsonString = JsonConvert.SerializeObject(articulos, settings);
					System.IO.File.WriteAllText(Rutas.archivoCatalogo, jsonString);
					return true;
				}
				else
				{
					Debug.WriteLine($"Listado recibido tiene valor NULO");
					return false;
				}

			}
			catch (Exception ex)
			{
				Debug.WriteLine($"No se pudo guardar la información del catálogo: {ex.Message}");
				return false;
			}


		}

		public static List<Articulo> LeerCatalogo()
		{

			List<Articulo> articulosLeidos;

			try
			{
				string jsonContent = File.ReadAllText(Rutas.archivoCatalogo);

				var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

				articulosLeidos = JsonConvert.DeserializeObject<List<Articulo>>(jsonContent, settings);
			}

			catch (Exception ex)
			{
				Debug.WriteLine($"No se pudo cargar el catálogo: {ex.Message}");
				return new List<Articulo>();
			}

			return articulosLeidos;

		}


		public static bool GuardarInventario(Inventario inventario)
		{
			try
			{

				if (inventario != null)
				{
					var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
					string jsonString = JsonConvert.SerializeObject(inventario, settings);
					System.IO.File.WriteAllText(Rutas.archivoInventario, jsonString);
					return true;
				}
				else
				{
					Debug.WriteLine($"No se puede guardar un inventario NULO");
					return false;
				}

			}
			catch (Exception ex)
			{
				Debug.WriteLine($"No se pudo guardar del Inventario: {ex.Message}");
				return false;
			}


		}

		public static Inventario LeerInventario()
		{

			Inventario inventarioLeido;

			try
			{
				string jsonContent = File.ReadAllText(Rutas.archivoInventario);

				var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
				inventarioLeido = JsonConvert.DeserializeObject<Inventario>(jsonContent, settings);
			}

			catch (Exception ex)
			{
				Debug.WriteLine($"No se pudo cargar el inventario: {ex.Message}");
				return new Inventario();
			}

			return inventarioLeido;

		}



	}

}