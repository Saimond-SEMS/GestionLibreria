using Libreria.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
	public partial class FormVender : Form
	{
		public Dictionary<Articulo, int> ventasRegistradas = new();

		public FormVender()
		{
			InitializeComponent();
		}

		private void FormVender_Load(object sender, EventArgs e)
		{
			lstvw_inventario.View = View.Details;
			lstvw_inventario.Columns.Add("Codigo", 100);
			lstvw_inventario.Columns.Add("Nombre", 160);
			lstvw_inventario.Columns.Add("Categoria", 120);
			lstvw_inventario.Columns.Add("Precio", 80);
			lstvw_inventario.Columns.Add("Cantidad", 80);

			lstvw_carrito.View = View.Details;
			lstvw_carrito.Columns.Add("Codigo", 80);
			lstvw_carrito.Columns.Add("Nombre", 140);
			lstvw_carrito.Columns.Add("Categoria", 100);
			lstvw_carrito.Columns.Add("Precio", 60);
			lstvw_carrito.Columns.Add("Cantidad", 60);

			ReLlenarLista();
		}

		private void ReLlenarLista()
		{
			lstvw_inventario.Items.Clear();

			// cargar los articulos.
			Inventario inv = Helpers.DataManager.LeerInventario();

			foreach (var pair in inv.articulos)
			{
				foreach (Articulo articulo in pair.Value)
				{
					ListViewItem item = new ListViewItem(articulo.codigoArticulo);
					item.SubItems.Add(articulo.nombre);
					item.SubItems.Add(articulo.categoria.ToString());
					item.SubItems.Add(articulo.precio.ToString());
					item.SubItems.Add(inv.GetTotalItems(articulo.codigoArticulo, articulo.categoria).ToString());

					bool repetido = false;
					foreach (ListViewItem lvi in lstvw_inventario.Items)
					{
						if (item.SubItems[0].Text == lvi.SubItems[0].Text)
						{
							repetido = true;
						}
					}

					if (!repetido)
						lstvw_inventario.Items.Add(item);
				}
			}
		}

		private List<Articulo> ListarCarrito()
		{
			List<Articulo> lista = new();
			Inventario inventario = Helpers.DataManager.LeerInventario();

			foreach (ListViewItem item in lstvw_carrito.Items)
			{
				Articulo? art = inventario.GetArticulo(item.SubItems[0].Text);
				if (art != null)
				{
					lista.Add(art);
				}
			}
			
			return lista;
		}

		private void btn_vender_Click(object sender, EventArgs e)
		{
			List<Articulo> catalogo = Helpers.DataManager.LeerCatalogo();
			Inventario inventario = Helpers.DataManager.LeerInventario();
			List<Articulo> enCarrito = ListarCarrito();

			if (enCarrito.Count == 0)
			{
				MessageBox.Show("No se ha elegido ningun producto.");
				return;
			}

			//string codigoElegido = elegidos[0].SubItems[0].Text;
			//int fCantidad = (int)nmrc_cantidad.Value;

			//Articulo? articuloElegido = null;
			//foreach (var cat_art in inventario.articulos)
			//{
			//	foreach (Articulo art in cat_art.Value)
			//	{
			//		if (art.codigoArticulo == codigoElegido)
			//		{
			//			articuloElegido = art;
			//			break;
			//		}
			//	}
			//}

			//if (articuloElegido == null)
			//	return;

			//inventario.removerArticulo(articuloElegido.categoria, articuloElegido.codigoArticulo);
			//Helpers.DataManager.GuardarInventario(inventario);
			ReLlenarLista();
			this.Close();
		}

		private void btn_agregarAlCarrito_Click(object sender, EventArgs e)
		{
			ListViewItem seleccionado = lstvw_inventario.SelectedItems[0];
			bool repetido = false;
			foreach (ListViewItem lvi in lstvw_carrito.Items)
			{
				if (seleccionado.SubItems[0].Text == lvi.SubItems[0].Text)
					repetido = true;
			}
			if (!repetido)
			{
				// copiar el elemento.
				ListViewItem newItem = new(seleccionado.SubItems[0].Text);
				newItem.SubItems.Add(seleccionado.SubItems[1].Text);
				newItem.SubItems.Add(seleccionado.SubItems[2].Text);
				newItem.SubItems.Add(seleccionado.SubItems[3].Text);
				int newCantidad = (int)nmrc_cantidad.Value;
				newItem.SubItems.Add(newCantidad.ToString());
				lstvw_carrito.Items.Add(newItem);
			}
			else
			{
				foreach(ListViewItem item in lstvw_carrito.Items)
				{
					if ( item.SubItems[0].Text == seleccionado.SubItems[0].Text )
					{
						item.SubItems[4].Text = (int.Parse(item.SubItems[4].Text) + (int)nmrc_cantidad.Value).ToString();
					}
				}
			}
		}

	}
}
