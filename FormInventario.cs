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
	public partial class FormInventario : Form
	{
		public FormInventario()
		{
			InitializeComponent();
		}

		private void FormInventario_Load(object sender, EventArgs e)
		{
			lstvw_inventario.View = View.Details;
			lstvw_inventario.Columns.Add("Codigo", 100);
			lstvw_inventario.Columns.Add("Nombre", 160);
			lstvw_inventario.Columns.Add("Categoria", 120);
			lstvw_inventario.Columns.Add("Precio", 80);
			lstvw_inventario.Columns.Add("Cantidad", 80);

			Relistar();
		}

		private void Relistar()
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
					item.SubItems.Add(inv.GetTotalItems( articulo.codigoArticulo, articulo.categoria).ToString() );

					lstvw_inventario.Items.Add(item);
				}
			}
		}
	}
}
