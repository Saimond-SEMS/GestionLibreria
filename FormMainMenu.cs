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
	public partial class FormMainMenu : Form
	{
		public FormMainMenu()
		{
			InitializeComponent();

		}

		private void FormMainMenu_Load(object sender, EventArgs e)
		{
			string username = "";
			if (Program.user != null)
				username = Program.user.username;

			List<Articulo> catalogo = Helpers.DataManager.LeerCatalogo();
			int nArticulos = catalogo.Count;

			lb_info1.Text = $"Ahoy {username}.";
		}

		private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			// La ventana original es el login y sigue activo todo el tiempo
			// Así que hay que forzar un cierre cuando se cierra el menu principal.
			Application.Exit();
		}

		private void btn_consultarCatalogo_Click(object sender, EventArgs e)
		{
			FormCatalogo form = new();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}

		private void btn_consultarInventario_Click(object sender, EventArgs e)
		{
			Inventario inventario = Helpers.DataManager.LeerInventario();
			if (inventario.getTotaItems() == 0)
			{
				MessageBox.Show("No hay articulos en el inventario.");
				return;
			}

			FormInventario form = new FormInventario();
			form.FormClosed += reactivarElMenu;
			form.Show(this);
			this.Enabled = false;
		}

		private void btn_consultarInventarioPorCategoria_Click(object sender, EventArgs e)
		{
			FormInventarioPorCategoria form = new FormInventarioPorCategoria();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}

		private void btn_nuevoProducto_Click(object sender, EventArgs e)
		{
			FormCrearArticulo form = new FormCrearArticulo();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			FormAgregar form = new FormAgregar();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}

		private void btn_consultarCatalogoPorCategoria_Click(object sender, EventArgs e)
		{
			FormCatalogoPorCategoria form = new FormCatalogoPorCategoria();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}

		private void btn_vender_Click(object sender, EventArgs e)
		{
			FormVender form = new FormVender();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show(this);
			form.FormClosed += reactivarElMenu;
			this.Enabled = false;
		}
		private void reactivarElMenu(object sender, EventArgs e)
		{
			this.Enabled = true;
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_reporteVentas_Click(object sender, EventArgs e)
		{
			string mensaje = "Hoy se han vendido: \n";
			float valorFinal = 0;

			foreach (Articulo art in Program.ventas)
			{
				mensaje += $"{art.nombre} {art.precio}\n";
				valorFinal += art.precio;
			}
			mensaje += $"\nPor un valor total de {valorFinal}$";
			MessageBox.Show(mensaje);
		}
	}
}
