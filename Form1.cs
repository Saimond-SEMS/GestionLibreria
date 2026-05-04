using System.Diagnostics;

namespace Libreria
{
	public struct FormRegistrarState
	{
		public string nombre = "";
		public string codigo = "";
		public string categoria = "";
		public int precio = 0;
		public int stock = 0;
		public int stockMinimo = 0;

		public FormRegistrarState() {
		}
	};

	public struct EntradaListaProducto
	{
		public string codigo = "";
		public string nombre = "";

		public EntradaListaProducto(string _codigo, string _nombre)
		{
			this.codigo = _codigo;
			this.nombre = _nombre;
		}
		public EntradaListaProducto() { }
	};

	public partial class Form1 : Form
	{
		FormRegistrarState registrarState = new FormRegistrarState();
		List<EntradaListaProducto> listaTemporalDeProductos = new List<EntradaListaProducto>();

		public Form1()
		{
			InitializeComponent();

			foreach (KeyValuePair<int, string> entry in Categoria.categorias)
			{
				combox_categoria.Items.Add(entry.Value);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine(sender);
		}


		/// --------------------------------------
		/// Registrar producto
		/// --------------------------------------
		private void lb_regInfoBox_Validated(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			label.Text = "";
		}

		private void UpdateBotonRegistrar()
		{
			if (this.registrarState.nombre != "" &&
				this.registrarState.codigo != "" &&
				this.registrarState.categoria != ""
			)
			{
				bttn_registrar.Enabled = true;
			}
			else
			{
				bttn_registrar.Enabled = false;
			}
			lb_regInfoBox.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// botón registrar
			Button button = (Button)sender;

			// crear producto
			Producto producto = new Producto();
			producto.nombre = this.registrarState.nombre;
			producto.codigo = this.registrarState.codigo;
			producto.categoria = new Categoria(this.registrarState.categoria);
			producto.precio = this.registrarState.precio;
			producto.stockActual = this.registrarState.stock;
			producto.stockMinimo = this.registrarState.stockMinimo;

			Producto.RegistrarProducto(producto);

			// limpiar los datos
			txt_nombre.Clear();
			txt_codigo.Clear();
			combox_categoria.SelectedIndex = 0;
			nmrc_precio.Value = 0;
			nmrc_stock.Value = 0;
			nmrc_stockMinimo.Value = 0;

			lb_regInfoBox.Text = "Producto registrado";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			// registro - nombre
			TextBox textBox = (TextBox)sender;
			this.registrarState.nombre = textBox.Text;
			UpdateBotonRegistrar();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			// registro - codigo
			TextBox textBox = (TextBox)sender;
			this.registrarState.codigo = textBox.Text;
			UpdateBotonRegistrar();
		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			// registro - categoria
			ComboBox comboBox = (ComboBox)sender;
			this.registrarState.categoria = Categoria.categorias[comboBox.SelectedIndex];
			UpdateBotonRegistrar();
		}
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			// registro - precio
			NumericUpDown numeric = (NumericUpDown)sender;
			this.registrarState.precio = (int)numeric.Value;
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			// registro - stock actual
			NumericUpDown numeric = (NumericUpDown)sender;
			this.registrarState.stock = (int)numeric.Value;
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			// registro - stock minimo
			NumericUpDown numeric = (NumericUpDown)sender;
			this.registrarState.stockMinimo = (int)numeric.Value;
		}


		private void tabControl1_Click(object sender, EventArgs e)
		{
			// editar - tab

			// actualizar lista de productos
			combox_edit_listaProductos.Items.Clear();
			combox_edit_listaProductos.Items.Add("");
			foreach (Producto prod in Producto.productos)
			{
				combox_edit_listaProductos.Items.Add(prod.codigo);
			}
		}
	}
}
