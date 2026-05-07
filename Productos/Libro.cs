using System;

namespace Libreria.Productos
{
	//Hereda de Artículo y representa un libro
	public class Libro : Articulo
	{

		public string nombreAutor { get; set; }
		public bool tapaDura { get; set; }

		public Libro(string _codigo, string _nombreAutor, string _nombre, float _precio, CategoriaArticulo _categoria, bool _tapaDura)
			: base(_nombre, _precio, _categoria, _codigo)
		{
			this.nombreAutor = _nombreAutor;
			this.tapaDura = _tapaDura;

		}

		//Método para obtener información del libro
		public override string getArticleInfo()
		{

			return $"Categoria: {categoria.ToString()}, Título: {nombre}, Autor: {nombreAutor},Precio: {precio}, Tapa Dura: {tapaDura}";

		}

	}
}