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
	public partial class FormCatalogo : Form
	{
		public FormCatalogo()
		{
			InitializeComponent();
		}

		private void FormCatalogo_Load(object sender, EventArgs e)
		{
			// cargar los articulos.
			List<Articulo> catalogo = Helpers.DataManager.LeerCatalogo();

			lstvw_catalogo.View = View.Details;
			lstvw_catalogo.Columns.Add("Codigo", 120);
			lstvw_catalogo.Columns.Add("Nombre", 200);
			lstvw_catalogo.Columns.Add("Categoria", 120);
			lstvw_catalogo.Columns.Add("Precio", 80);

			foreach (Articulo articulo in catalogo)
			{
				ListViewItem item = new ListViewItem(articulo.codigoArticulo);

				item.SubItems.Add(articulo.nombre);
				item.SubItems.Add(articulo.categoria.ToString());
				item.SubItems.Add(articulo.precio.ToString());

				lstvw_catalogo.Items.Add(item);
			}
		}

		private void FormCatalogo_Resize(object sender, EventArgs e)
		{
			Form window = (Form)sender;
			lstvw_catalogo.Size = new Size(window.Size.Width-50, window.Size.Height-75);
		}
	}
}
