using System;

namespace Libreria.Security
{
	class Usuario
	{
		public string username { get; set; }
		public string nombre { get; set; }
		public string clave { get; set; }

		public Usuario(string _username, string _nombre, string _clave)
		{
			this.nombre = _nombre;
			this.clave = _clave;
			this.username = _username;

		}

		public Usuario() {
			this.nombre = "";
			this.clave = "";
			this.username = "";
		}

	}
}