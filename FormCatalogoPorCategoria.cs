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
	public partial class FormCatalogoPorCategoria : Form
	{
		public FormCatalogoPorCategoria()
		{
			InitializeComponent();
		}

		private void FormCatalogoPorCategoria_Load(object sender, EventArgs e)
		{
			// cargar los articulos.
			List<Articulo> catalogo = Helpers.DataManager.LeerCatalogo();
			lstvw_catalogoPorCategoria.View = View.Details;
			lstvw_catalogoPorCategoria.Columns.Add("Codigo", 120);
			lstvw_catalogoPorCategoria.Columns.Add("Nombre", 200);
			lstvw_catalogoPorCategoria.Columns.Add("Categoria", 120);
			lstvw_catalogoPorCategoria.Columns.Add("Precio", 80);

			Dictionary<CategoriaArticulo, ListViewGroup> categorias = new Dictionary<CategoriaArticulo, ListViewGroup>();
			foreach (CategoriaArticulo cat in Enum.GetValues(typeof(CategoriaArticulo)))
			{
				ListViewGroup group = new ListViewGroup(cat.ToString());
				categorias.Add(cat, group);
				lstvw_catalogoPorCategoria.Groups.Add( group );
			}

			foreach (Articulo articulo in catalogo)
			{
				ListViewItem item = new ListViewItem(articulo.codigoArticulo);

				item.SubItems.Add(articulo.nombre);
				item.SubItems.Add(articulo.categoria.ToString());
				item.SubItems.Add(articulo.precio.ToString());
				item.Group = categorias[articulo.categoria];

				lstvw_catalogoPorCategoria.Items.Add(item);
			}
		}
	}
}
