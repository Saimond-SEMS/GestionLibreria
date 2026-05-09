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
					for (int i = 0; i < int.Parse(item.SubItems[4].Text); i++)
					{
						lista.Add(art);
					}
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

			foreach (Articulo art in enCarrito)
			{
				Articulo articulo = inventario.GetArticulo(art.codigoArticulo);
				if (articulo == null)
				{
					continue;
				}
				Program.ventas.Add(articulo);
				inventario.removerArticulo(articulo.categoria, articulo.codigoArticulo);
			}


			Helpers.DataManager.GuardarInventario(inventario);
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

			int cantidadEnInventario = int.Parse(seleccionado.SubItems[4].Text);

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
				foreach (ListViewItem item in lstvw_carrito.Items)
				{
					if (item.SubItems[0].Text == seleccionado.SubItems[0].Text)
					{
						item.SubItems[4].Text = (int.Parse(item.SubItems[4].Text) + (int)nmrc_cantidad.Value).ToString();
					}
				}
			}
		}

		private void lstvw_carrito_TabIndexChanged(object sender, EventArgs e)
		{
		}

		private void lstvw_inventario_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (lstvw_inventario.SelectedItems.Count == 0)
				return;

			ListViewItem? item = lstvw_inventario.SelectedItems[0];

			nmrc_cantidad.Maximum = int.Parse(item.SubItems[4].Text);
		}
	}
}
