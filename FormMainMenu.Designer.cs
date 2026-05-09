namespace Libreria
{
	partial class FormMainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			flowLayoutPanel1 = new FlowLayoutPanel();
			flowLayoutPanel2 = new FlowLayoutPanel();
			lb_info1 = new Label();
			flowLayoutPanel3 = new FlowLayoutPanel();
			btn_consultarCatalogo = new Button();
			btn_consultarInventario = new Button();
			btn_vender = new Button();
			btn_nuevoProducto = new Button();
			btn_consultarInventarioPorCategoria = new Button();
			btn_add = new Button();
			btn_consultarCatalogoPorCategoria = new Button();
			btn_salir = new Button();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
			flowLayoutPanel1.Controls.Add(lb_info1);
			flowLayoutPanel1.Location = new Point(12, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(776, 41);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.Location = new Point(3, 3);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(0, 0);
			flowLayoutPanel2.TabIndex = 0;
			// 
			// lb_info1
			// 
			lb_info1.AutoSize = true;
			lb_info1.Location = new Point(9, 0);
			lb_info1.Name = "lb_info1";
			lb_info1.Size = new Size(128, 15);
			lb_info1.TabIndex = 0;
			lb_info1.Text = "Mensaje de bienvenida";
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Controls.Add(btn_consultarCatalogo);
			flowLayoutPanel3.Controls.Add(btn_consultarInventario);
			flowLayoutPanel3.Controls.Add(btn_vender);
			flowLayoutPanel3.Controls.Add(btn_nuevoProducto);
			flowLayoutPanel3.Controls.Add(btn_consultarInventarioPorCategoria);
			flowLayoutPanel3.Controls.Add(btn_add);
			flowLayoutPanel3.Controls.Add(btn_consultarCatalogoPorCategoria);
			flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel3.Location = new Point(12, 59);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(776, 189);
			flowLayoutPanel3.TabIndex = 1;
			// 
			// btn_consultarCatalogo
			// 
			btn_consultarCatalogo.Location = new Point(3, 3);
			btn_consultarCatalogo.Name = "btn_consultarCatalogo";
			btn_consultarCatalogo.Size = new Size(150, 40);
			btn_consultarCatalogo.TabIndex = 0;
			btn_consultarCatalogo.Text = "Consultar Catalogo";
			btn_consultarCatalogo.UseVisualStyleBackColor = true;
			btn_consultarCatalogo.Click += btn_consultarCatalogo_Click;
			// 
			// btn_consultarInventario
			// 
			btn_consultarInventario.Location = new Point(3, 49);
			btn_consultarInventario.Name = "btn_consultarInventario";
			btn_consultarInventario.Size = new Size(150, 40);
			btn_consultarInventario.TabIndex = 1;
			btn_consultarInventario.Text = "Consultar inventario";
			btn_consultarInventario.UseVisualStyleBackColor = true;
			btn_consultarInventario.Click += btn_consultarInventario_Click;
			// 
			// btn_vender
			// 
			btn_vender.Location = new Point(3, 95);
			btn_vender.Name = "btn_vender";
			btn_vender.Size = new Size(150, 40);
			btn_vender.TabIndex = 2;
			btn_vender.Text = "Hacer una venta";
			btn_vender.UseVisualStyleBackColor = true;
			btn_vender.Click += btn_vender_Click;
			// 
			// btn_nuevoProducto
			// 
			btn_nuevoProducto.Location = new Point(3, 141);
			btn_nuevoProducto.Name = "btn_nuevoProducto";
			btn_nuevoProducto.Size = new Size(150, 40);
			btn_nuevoProducto.TabIndex = 3;
			btn_nuevoProducto.Text = "Crear nuevo producto";
			btn_nuevoProducto.UseVisualStyleBackColor = true;
			btn_nuevoProducto.Click += btn_nuevoProducto_Click;
			// 
			// btn_consultarInventarioPorCategoria
			// 
			btn_consultarInventarioPorCategoria.Location = new Point(159, 3);
			btn_consultarInventarioPorCategoria.Name = "btn_consultarInventarioPorCategoria";
			btn_consultarInventarioPorCategoria.Size = new Size(150, 40);
			btn_consultarInventarioPorCategoria.TabIndex = 4;
			btn_consultarInventarioPorCategoria.Text = "Consultar inventario por categoria";
			btn_consultarInventarioPorCategoria.UseVisualStyleBackColor = true;
			btn_consultarInventarioPorCategoria.Click += btn_consultarInventarioPorCategoria_Click;
			// 
			// btn_add
			// 
			btn_add.Location = new Point(159, 49);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(150, 40);
			btn_add.TabIndex = 6;
			btn_add.Text = "Añadir articulo al inventario";
			btn_add.UseVisualStyleBackColor = true;
			btn_add.Click += btn_add_Click;
			// 
			// btn_consultarCatalogoPorCategoria
			// 
			btn_consultarCatalogoPorCategoria.Location = new Point(159, 95);
			btn_consultarCatalogoPorCategoria.Name = "btn_consultarCatalogoPorCategoria";
			btn_consultarCatalogoPorCategoria.Size = new Size(150, 40);
			btn_consultarCatalogoPorCategoria.TabIndex = 7;
			btn_consultarCatalogoPorCategoria.Text = "Consular catalogo por categoria";
			btn_consultarCatalogoPorCategoria.UseVisualStyleBackColor = true;
			btn_consultarCatalogoPorCategoria.Click += btn_consultarCatalogoPorCategoria_Click;
			// 
			// btn_salir
			// 
			btn_salir.Location = new Point(632, 398);
			btn_salir.Name = "btn_salir";
			btn_salir.RightToLeft = RightToLeft.Yes;
			btn_salir.Size = new Size(156, 40);
			btn_salir.TabIndex = 2;
			btn_salir.Text = "Salir de la aplicación";
			btn_salir.UseVisualStyleBackColor = true;
			btn_salir.Click += btn_salir_Click;
			// 
			// FormMainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_salir);
			Controls.Add(flowLayoutPanel3);
			Controls.Add(flowLayoutPanel1);
			Name = "FormMainMenu";
			Text = "MainMenu";
			FormClosing += FormMainMenu_FormClosing;
			Load += FormMainMenu_Load;
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel2;
		private Label lb_info1;
		private FlowLayoutPanel flowLayoutPanel3;
		private Button btn_consultarCatalogo;
		private Button btn_consultarInventario;
		private Button btn_vender;
		private Button btn_nuevoProducto;
		private Button btn_consultarInventarioPorCategoria;
		private Button btn_add;
		private Button btn_consultarCatalogoPorCategoria;
		private Button btn_salir;
	}
}