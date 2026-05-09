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
	public partial class FormCrearArticulo : Form
	{
		public FormCrearArticulo()
		{
			InitializeComponent();
		}

		private void FormCrearArticulo_Load(object sender, EventArgs e)
		{
			cmbbx_categoria.Items.Add(" ");
			foreach (CategoriaArticulo lacategoria in Enum.GetValues(typeof(CategoriaArticulo)))
			{
				cmbbx_categoria.Items.Add(lacategoria);
			}
		}

		private void btn_registrar_Click(object sender, EventArgs e)
		{
			string fNombre = txt_nombre.Text;
			string fCodigo = txt_codigo.Text;
			CategoriaArticulo fCategoria = (CategoriaArticulo)cmbbx_categoria.SelectedIndex;
			Decimal fPrecio = nmrc_precio.Value;

			if (fNombre == "")
			{
				MessageBox.Show("Nombre vacío.");
				return;
			}
			if ( fCodigo == "")
			{
				MessageBox.Show("Codigo vacío");
				return;
			}
			if (fCategoria == 0)
			{
				MessageBox.Show("Categoría invalida");
				return;
			}

			// chequear codigo repetido.
			List<Articulo> inv = Helpers.DataManager.LeerCatalogo();
			foreach ( Articulo art in inv)
			{
				if ( art.codigoArticulo == fCodigo)
				{
					MessageBox.Show("El codigo ya está en uso.");
				}
			}

			// crear y cerrrar
			inv.Add( new Articulo( fNombre, (float)fPrecio, fCategoria, fCodigo ));
			Helpers.DataManager.GuardaCatalogo(inv);

			// reiniciar ventana
			txt_nombre.Text = "";
			txt_codigo.Text = "";
			cmbbx_categoria.SelectedIndex = 0;
			nmrc_precio.Value = 0.0M;
		}
	}
}
