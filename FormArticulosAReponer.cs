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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

			lstvw.View = View.Details;
			lstvw.Columns.Add("Codigo", 100);
			lstvw.Columns.Add("Nombre", 160);
			lstvw.Columns.Add("Categoria", 120);
			lstvw.Columns.Add("Precio", 80);
			lstvw.Columns.Add("Cantidad", 80);

			Relistar();
		}

		private void Relistar()
		{
			lstvw.Items.Clear();

			// cargar los articulos.
			Inventario inv = Helpers.DataManager.LeerInventario();
			List<Articulo> aReponer = inv.getArticulosReponer();

			foreach (Articulo articulo in aReponer)
			{
				ListViewItem item = new ListViewItem(articulo.codigoArticulo);

				item.SubItems.Add(articulo.nombre);
				item.SubItems.Add(articulo.categoria.ToString());
				item.SubItems.Add(articulo.precio.ToString());
				item.SubItems.Add(inv.GetTotalItems(articulo.codigoArticulo, articulo.categoria).ToString());

				bool repetido = false;
				foreach (ListViewItem lvi in lstvw.Items)
				{
					if (item.SubItems[0].Text == lvi.SubItems[0].Text)
					{
						repetido = true;
					}
				}

				if (!repetido)
				{
					lstvw.Items.Add(item);
				}
			}
		}
	}
}
