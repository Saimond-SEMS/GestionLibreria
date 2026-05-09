using Libreria.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
	public partial class FormAgregar : Form
	{
		public FormAgregar()
		{
			InitializeComponent();
		}

		private void FormAgregar_Load(object sender, EventArgs e)
		{
			// cargar los articulos.
			List<Articulo> articulos = Helpers.DataManager.LeerCatalogo();

			lstvw_articulos.View = View.Details;
			lstvw_articulos.Columns.Add("Codigo", 120);
			lstvw_articulos.Columns.Add("Nombre", 200);
			lstvw_articulos.Columns.Add("Categoria", 120);
			lstvw_articulos.Columns.Add("Precio", 80);

			foreach (Articulo articulo in articulos)
			{
				ListViewItem item = new ListViewItem(articulo.codigoArticulo);

				item.SubItems.Add(articulo.nombre);
				item.SubItems.Add(articulo.categoria.ToString());
				item.SubItems.Add(articulo.precio.ToString());

				lstvw_articulos.Items.Add(item);
			}

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			List<Articulo> catalogo = Helpers.DataManager.LeerCatalogo();
			Inventario inventario = Helpers.DataManager.LeerInventario();
			ListView.SelectedListViewItemCollection elegidos = lstvw_articulos.SelectedItems;
			if ( elegidos.Count == 0 )
			{
				MessageBox.Show("No se ha elegido ningun producto.");
				return;
			}

			string codigoElegido = elegidos[0].SubItems[0].Text;
			Decimal fCantidad = nmrc_cantidad.Value;

			Articulo? articulo = null;
			foreach ( Articulo art in catalogo ) {
				if ( art.codigoArticulo == codigoElegido)
				{
					articulo = art;
				}
			}
			if ( articulo == null)
				return;

			inventario.addArticulo(articulo, (int)fCantidad);
			Helpers.DataManager.GuardarInventario(inventario);

			nmrc_cantidad.Value = 1.0M;
			this.Close();
		}
	}
}
