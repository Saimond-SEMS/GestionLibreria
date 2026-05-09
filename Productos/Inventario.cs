using System;
using System.Diagnostics;
using Libreria.Helpers;

namespace Libreria.Productos
{
	public class Inventario
	{

		public Dictionary<CategoriaArticulo, List<Articulo>> articulos = new Dictionary<CategoriaArticulo, List<Articulo>>();

		public int getTotaItems(CategoriaArticulo _categoria)
		{

			if (this.articulos == null || !this.articulos.ContainsKey(_categoria))
			{
				return 0;
			}
			else
			{

				return this.articulos[_categoria].Count();
			}
		}

		public int getTotaItems()
		{
			int count = 0;

			if (this.articulos == null)
			{
				return 0;
			}
			else
			{
				foreach (CategoriaArticulo lacategoria in Enum.GetValues(typeof(CategoriaArticulo)))
					count += this.articulos[lacategoria].Count();

				return count;

			}
		}

		public int GetTotalItems( string _codigo, CategoriaArticulo _categoria )
		{
			int count = 0;
			foreach (Articulo art in this.articulos[_categoria])
			{
				if( art.codigoArticulo == _codigo )
					count++;
			}
			return count;
		}

		public void addArticulo(Articulo _articulo, int cantidad)
		{
			if (cantidad >= 1)
			{
				CategoriaArticulo cat = _articulo.categoria;

				if (!this.articulos.ContainsKey(cat))
				{
					this.articulos[cat] = new List<Articulo>();
				}

				for (int i = 1; i <= cantidad; i++)
					this.articulos[cat].Add(_articulo);
			}
			else
			{

				Debug.WriteLine($"La cantidad de artículos debe ser mayor o igual a 1");

			}

		}// FIN public void addArticulo(Articulo _articulo, int cantidad)


		public bool removerArticulo(CategoriaArticulo cat, string id)
		{

			bool removido = false;


			if (!id.Trim().Equals(""))
			{

				if (this.articulos.ContainsKey(cat))
				{

					var itemToRemove = this.articulos[cat].FirstOrDefault(x => x.codigoArticulo.Trim() == id.Trim());

					if (itemToRemove != null)
					{
						this.articulos[cat].Remove(itemToRemove);
						removido = true;
					}


				}


			}
			else
			{
				Debug.WriteLine($"Debe indicarse el identificador del artículo");
			}

			return removido;

		} // FIN public bool removerArticulo(CategoriaArticulo cat, string id)


		public List<Articulo> getArticulosReponer()
		{

			List<Articulo> catalogoArticulos = DataManager.LeerCatalogo();
			List<Articulo> listaArticulosReponer = new List<Articulo>();
			List<Articulo> listaSimpleInventario = new List<Articulo>();

			int countArticulo = 0;

			foreach (List<Articulo> listaInventario in this.articulos.Values)
				listaSimpleInventario.AddRange(listaInventario);


			foreach (Articulo itemCatalogo in catalogoArticulos)
			{

				countArticulo =
					listaSimpleInventario.Where(
						w => w.codigoArticulo.Trim() == itemCatalogo.codigoArticulo.Trim()
						&& w.categoria == itemCatalogo.categoria
					).Count();

				if (countArticulo <= DataManager.minimoInventario)
					listaArticulosReponer.Add(itemCatalogo);

				countArticulo = 0;
			}

			return listaArticulosReponer.Distinct().ToList();

		}

		public Inventario()
		{
			foreach (CategoriaArticulo lacategoria in Enum.GetValues(typeof(CategoriaArticulo)))
			{
				this.articulos.Add(lacategoria, new List<Articulo>() );
			}
		}


	} // FIN public class Inventario 
}