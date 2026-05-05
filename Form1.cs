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
		//List<EntradaListaProducto> listaTemporalDeProductos = new List<EntradaListaProducto>();

		public Form1()
		{
			InitializeComponent();

			foreach (KeyValuePair<int, string> entry in Categoria.categorias)
			{
				combox_categoria.Items.Add(entry.Value);
				edit_combox_categoria.Items.Add(entry.Value);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Console.WriteLine(sender);
		}


		/// --------------------------------------
		/// Registrar producto
		/// --------------------------------------
		private void lb_regInfoBox_Validated(object sender, EventArgs e)
		{
			// infobox
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
				regis_btn_registrar.Enabled = true;
			}
			else
			{
				regis_btn_registrar.Enabled = false;
			}
			lb_regInfoBox.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// botón registrar
			Button button = (Button)sender;

			if (!Program.CodigoEstaDisponible(txt_codigo.Text))
			{
				lb_regInfoBox.Text = "Codigo duplicado";
				return;
			}

			// crear producto
			Producto producto = new Producto();
			producto.nombre = this.registrarState.nombre;
			producto.codigo = this.registrarState.codigo;
			producto.categoria = new Categoria(this.registrarState.categoria);
			producto.precio = this.registrarState.precio;
			producto.stockActual = this.registrarState.stock;
			producto.stockMinimo = this.registrarState.stockMinimo;

			if (!Program.RegistrarProducto(producto))
			{
				lb_regInfoBox.Text = "No se pudo registrar el producto.";
				return;
			}

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

		private void tabControl1_Enter(object sender, EventArgs e)
		{
			// regiustro - al entrar al tab

			UpdateBotonRegistrar();
		}

		//-------------------------------------------------------------------
		// editar
		//-------------------------------------------------------------------

		private void updateEditForm()
		{
			// edit form - update

			// borrar y rellenar la lista de prodeuctos
			combox_edit_listaProductos.Items.Clear();
			combox_edit_listaProductos.Items.Add("");
			foreach (Producto producto in Program.productos)
			{
				combox_edit_listaProductos.Items.Add(producto.codigo);
			}

			// bloquear el boton de editar
			if (edit_txt_nombre.Text == "" ||
				edit_combox_categoria.Text == "" ||
				edit_combox_categoria.SelectedIndex == 0)
			{
				edit_btn_edit.Enabled = false;
			}
			else
			{
				edit_btn_edit.Enabled = true;
			}
		}

		private void combox_edit_listaProductos_DisplayMemberChanged(object sender, EventArgs e)
		{
			// editar - al elegir producto

			ComboBox comboBox = (ComboBox)sender;

			if (comboBox.SelectedIndex == 0)
			{
				edit_txt_nombre.Enabled = false;
				edit_combox_categoria.Enabled = false;
				edit_nmrc_precio.Enabled = false;
				edit_nmrc_stock.Enabled = false;
				edit_nmrc_stock.Enabled = false;
				edit_nmrc_stockMinimo.Enabled = false;
				edit_btn_edit.Enabled = false;
				return;
			}

			Producto? producto = Program.BuscarProductoPorCodigo(comboBox.Text);
			if (producto == null)
			{
				lb_regInfoBox.Text = "Codigo de producto no encontrado.";
				return;
			}

			// activar todo
			edit_txt_nombre.Enabled = true;
			edit_combox_categoria.Enabled = true;
			edit_nmrc_precio.Enabled = true;
			edit_nmrc_stock.Enabled = true;
			edit_nmrc_stock.Enabled = true;
			edit_nmrc_stockMinimo.Enabled = true;
			edit_btn_edit.Enabled = true;

			// rellenar con la informacion de producto
			edit_txt_nombre.Text = producto.nombre;
			edit_nmrc_precio.Value = (decimal)producto.precio;
			edit_nmrc_stock.Value = (decimal)producto.stockActual;
			edit_nmrc_stockMinimo.Value = (decimal)producto.stockMinimo;

			// No sé cual es la forma correcta de seleccionar de un comboBox.
			int categoriaIndex = 0;
			foreach (var cat in Categoria.categorias)
			{
				if (producto.categoria.nombre == cat.Value)
				{
					categoriaIndex = cat.Key;
				}
			}
			edit_combox_categoria.SelectedIndex = categoriaIndex;

			//updateEditForm();
		}

		private void edit_btn_edit_Click(object sender, EventArgs e)
		{
			// boton editar
			Button button = (Button)sender;

			// editar el producto activo
			string? codigo = (string?)combox_edit_listaProductos.SelectedItem;
			if (codigo == null)
			{
				lb_regInfoBox.Text = "Producto no encontrado";
				return;
			}

			Producto? producto = Program.BuscarProductoPorCodigo(codigo);
			if (producto == null)
			{
				lb_regInfoBox.Text = "Producto no encontrado";
				return;
			}

			producto.nombre = edit_txt_nombre.Text;
			producto.categoria.nombre = Categoria.categorias[edit_combox_categoria.SelectedIndex];
			producto.precio = (int)edit_nmrc_precio.Value;
			producto.stockActual = (int)nmrc_stock.Value;
			producto.stockMinimo = (int)nmrc_stockMinimo.Value;

			lb_regInfoBox.Text = "Producto editado";

			// limpiar los campos
			combox_edit_listaProductos.SelectedIndex = 0;
			edit_txt_nombre.Clear();
			edit_combox_categoria.SelectedIndex = 0;
			edit_nmrc_precio.Value = 0.0M;
			edit_nmrc_stock.Value = 0.0M;
			edit_nmrc_stockMinimo.Value = 0.0M;
			updateEditForm();
		}

		private void edit_somethingChanged(object sender, EventArgs e)
		{
			lb_regInfoBox.Text = "";
		}

		private void Editar_tabPage_Enter(object sender, EventArgs e)
		{
			// editar - al entrar al tab
			updateEditForm();
		}
	}
}
