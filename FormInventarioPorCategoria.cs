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
	public partial class FormInventarioPorCategoria : Form
	{
		public FormInventarioPorCategoria()
		{
			InitializeComponent();
		}

		private void FormInventarioPorCategoria_Load(object sender, EventArgs e)
		{
			lstvw_inventarioPorCat.View = View.Details;
			lstvw_inventarioPorCat.Columns.Add("Codigo", 100);
			lstvw_inventarioPorCat.Columns.Add("Nombre", 160);
			lstvw_inventarioPorCat.Columns.Add("Categoria", 120);
			lstvw_inventarioPorCat.Columns.Add("Precio", 80);
			lstvw_inventarioPorCat.Columns.Add("Cantidad", 80);

			ReLlenarLista();
		}

		private void ReLlenarLista()
		{
			lstvw_inventarioPorCat.Items.Clear();

			// cargar los articulos.
			Inventario inv = Helpers.DataManager.LeerInventario();

			foreach (var pair in inv.articulos)
			{
				ListViewGroup group = new ListViewGroup(pair.Key.ToString());
				lstvw_inventarioPorCat.Groups.Add(group);

				foreach (Articulo articulo in pair.Value)
				{
					ListViewItem item = new ListViewItem(articulo.codigoArticulo);

					item.SubItems.Add(articulo.nombre);
					item.SubItems.Add(articulo.categoria.ToString());
					item.SubItems.Add(articulo.precio.ToString());
					item.SubItems.Add(inv.GetTotalItems(articulo.codigoArticulo, articulo.categoria).ToString());
					item.Group = group;

					bool repetido = false;
					foreach (ListViewItem lvi in lstvw_inventarioPorCat.Items)
					{
						if (item.SubItems[0].Text == lvi.SubItems[0].Text)
						{
							repetido = true;
						}
					}

					if (!repetido)
						lstvw_inventarioPorCat.Items.Add(item);
				}
			}
		}
	}
}
