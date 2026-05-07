using System;

namespace Libreria.Productos
{
	//Clase de artículos. de esta heredan las clases Libro y Cuaderno
	public class Articulo
	{
		public string codigoArticulo { get; set; }
		public string nombre { get; set; }
		public float precio { get; set; }
		public CategoriaArticulo categoria { get; set; }

		public Articulo(string _nombre, float _precio, CategoriaArticulo _categoria, string _codigo)
		{
			this.nombre = _nombre;
			this.precio = _precio;
			this.categoria = _categoria;
			this.codigoArticulo = _codigo;

		}

		public virtual string getArticleInfo() { return String.Empty; }

	}
}