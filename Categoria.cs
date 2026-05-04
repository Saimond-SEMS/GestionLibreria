using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria {
	internal class Categoria {
		public static Dictionary<int, string> categorias = new Dictionary<int, string>() {
			{0, ""	},
			{1, "Útiles"	},
			{2, "Libros"	},
			{3, "Arte"		},
			{4, "Tecnología"},
			{5, "Papelera"	}
		};

		public string nombre = "";

		public Categoria() {
			this.nombre = "";
		}
		public Categoria( string _categoria) {
			this.nombre = _categoria;
		}
	}
}
