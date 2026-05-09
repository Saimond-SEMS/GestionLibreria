namespace Libreria
{
	partial class FormVender
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
			label1 = new Label();
			lstvw_inventario = new ListView();
			flowLayoutPanel4 = new FlowLayoutPanel();
			flowLayoutPanel3 = new FlowLayoutPanel();
			nmrc_cantidad = new NumericUpDown();
			btn_agregarAlCarrito = new Button();
			flowLayoutPanel2 = new FlowLayoutPanel();
			label2 = new Label();
			lstvw_carrito = new ListView();
			lb_precioTotal = new Label();
			btn_vender = new Button();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel4.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_cantidad).BeginInit();
			flowLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(lstvw_inventario);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
			flowLayoutPanel1.Controls.Add(btn_vender);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(12, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(733, 411);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(97, 15);
			label1.TabIndex = 1;
			label1.Text = "Inventario Actual";
			// 
			// lstvw_inventario
			// 
			lstvw_inventario.FullRowSelect = true;
			lstvw_inventario.GridLines = true;
			lstvw_inventario.Location = new Point(3, 18);
			lstvw_inventario.Name = "lstvw_inventario";
			lstvw_inventario.Size = new Size(730, 139);
			lstvw_inventario.TabIndex = 0;
			lstvw_inventario.UseCompatibleStateImageBehavior = false;
			lstvw_inventario.ItemSelectionChanged += lstvw_inventario_ItemSelectionChanged;
			// 
			// flowLayoutPanel4
			// 
			flowLayoutPanel4.Controls.Add(flowLayoutPanel3);
			flowLayoutPanel4.Controls.Add(flowLayoutPanel2);
			flowLayoutPanel4.Location = new Point(3, 163);
			flowLayoutPanel4.Name = "flowLayoutPanel4";
			flowLayoutPanel4.Size = new Size(730, 160);
			flowLayoutPanel4.TabIndex = 6;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Controls.Add(nmrc_cantidad);
			flowLayoutPanel3.Controls.Add(btn_agregarAlCarrito);
			flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel3.Location = new Point(3, 3);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(218, 147);
			flowLayoutPanel3.TabIndex = 6;
			// 
			// nmrc_cantidad
			// 
			nmrc_cantidad.Location = new Point(3, 3);
			nmrc_cantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			nmrc_cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nmrc_cantidad.Name = "nmrc_cantidad";
			nmrc_cantidad.Size = new Size(155, 23);
			nmrc_cantidad.TabIndex = 3;
			nmrc_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// btn_agregarAlCarrito
			// 
			btn_agregarAlCarrito.Location = new Point(3, 32);
			btn_agregarAlCarrito.Name = "btn_agregarAlCarrito";
			btn_agregarAlCarrito.Size = new Size(136, 23);
			btn_agregarAlCarrito.TabIndex = 5;
			btn_agregarAlCarrito.Text = "Agregar al carrito.";
			btn_agregarAlCarrito.UseVisualStyleBackColor = true;
			btn_agregarAlCarrito.Click += btn_agregarAlCarrito_Click;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(label2);
			flowLayoutPanel2.Controls.Add(lstvw_carrito);
			flowLayoutPanel2.Controls.Add(lb_precioTotal);
			flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel2.Location = new Point(227, 3);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(489, 147);
			flowLayoutPanel2.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 7;
			label2.Text = "Carrito";
			// 
			// lstvw_carrito
			// 
			lstvw_carrito.Location = new Point(3, 18);
			lstvw_carrito.Name = "lstvw_carrito";
			lstvw_carrito.Size = new Size(486, 100);
			lstvw_carrito.TabIndex = 4;
			lstvw_carrito.UseCompatibleStateImageBehavior = false;
			lstvw_carrito.SelectedIndexChanged += lstvw_carrito_TabIndexChanged;
			// 
			// lb_precioTotal
			// 
			lb_precioTotal.AutoSize = true;
			lb_precioTotal.Location = new Point(3, 121);
			lb_precioTotal.Name = "lb_precioTotal";
			lb_precioTotal.Size = new Size(32, 15);
			lb_precioTotal.TabIndex = 8;
			lb_precioTotal.Text = "Total";
			// 
			// btn_vender
			// 
			btn_vender.Location = new Point(3, 329);
			btn_vender.Name = "btn_vender";
			btn_vender.Size = new Size(161, 23);
			btn_vender.TabIndex = 0;
			btn_vender.Text = "Registrar venta";
			btn_vender.UseVisualStyleBackColor = true;
			btn_vender.Click += btn_vender_Click;
			// 
			// FormVender
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(757, 427);
			Controls.Add(flowLayoutPanel1);
			Name = "FormVender";
			Text = "FormVender";
			Load += FormVender_Load;
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			flowLayoutPanel4.ResumeLayout(false);
			flowLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)nmrc_cantidad).EndInit();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label label1;
		private ListView lstvw_inventario;
		private Button btn_vender;
		private NumericUpDown nmrc_cantidad;
		private FlowLayoutPanel flowLayoutPanel4;
		private Button btn_agregarAlCarrito;
		private ListView lstvw_carrito;
		private FlowLayoutPanel flowLayoutPanel3;
		private FlowLayoutPanel flowLayoutPanel2;
		private Label label2;
		private Label lb_precioTotal;
	}
}