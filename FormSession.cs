using Libreria.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
	public partial class FormSession : Form
	{
		public FormSession()
		{
			InitializeComponent();
		}

		private void btn_entrar_Click(object sender, EventArgs e)
		{
			string nombreUsuario = txt_nombre.Text;
			string clave = txt_clave.Text;

			if (nombreUsuario == "admin" || nombreUsuario == "Admin")
			{
				Program.user = new Security.Usuario("Admin", "Admin", "admin");
			}
			else
			{				
				if (nombreUsuario == "")
				{
					MessageBox.Show("Nombre de usuario vacío.");
					return;
				}
				if (clave == "")
				{
					MessageBox.Show("Clave de acceso vacía.");
					return;
				}

				string acceso = DataManager.validateCredentials(nombreUsuario, clave);

				if (acceso == "0")
				{
					MessageBox.Show("Usuario no encontrado.");
					return;
				}
				Program.user = new Security.Usuario(nombreUsuario, acceso, clave);
			}

			this.Hide();
			FormMainMenu mainMenu = new();
			mainMenu.Show(this);
		}

		private void btn_registrar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Esta función está en desarrollo.\n Usa el nombre de usuario Admin.");
		}
	}
}
