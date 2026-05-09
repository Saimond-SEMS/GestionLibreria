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

		private void btn_vender_Click(object sender, EventArgs e)
		{
			List<Articulo> catalogo = Helpers.DataManager.LeerCatalogo();
			Inventario inventario = Helpers.DataManager.LeerInventario();
			ListView.SelectedListViewItemCollection elegidos = lstvw_inventario.SelectedItems;
			if (elegidos.Count == 0)
			{
				MessageBox.Show("No se ha elegido ningun producto.");
				return;
			}

			string codigoElegido = elegidos[0].SubItems[0].Text;
			int fCantidad = (int)nmrc_cantidad.Value;

			Articulo? articuloElegido = null;
			foreach ( var cat_art in inventario.articulos)
			{
				foreach (Articulo art in cat_art.Value)
				{
					if (art.codigoArticulo == codigoElegido)
					{
						articuloElegido = art;
						break;
					}
				}
			}

			if ( articuloElegido == null )
				return;

			inventario.removerArticulo(articuloElegido.categoria, articuloElegido.codigoArticulo);
			Helpers.DataManager.GuardarInventario(inventario);
			ReLlenarLista();
		}
	}
}
