using System;

namespace Libreria.Productos
{
	//Hereda de Artículo y representa un cuaderno
	public class Cuaderno : Articulo
	{

		public int paginas { get; set; }
		public bool cosido { get; set; }
		public string marca { get; set; }

		public Cuaderno(string _codigo, int _paginas, string _nombre, float _precio, CategoriaArticulo _categoria, bool _cosido, string _marca)
			: base(_nombre, _precio, _categoria, _codigo)
		{
			this.paginas = _paginas;
			this.cosido = _cosido;
			this.marca = _marca;
		}

		//Método para obtener información del cuaderno
		public override string getArticleInfo()
		{

			return $"Categoria: {categoria.ToString()}, Marca: {marca}, Páginas: {paginas}, Precio: {precio}, Cosido: {cosido}";

		}

	}
}