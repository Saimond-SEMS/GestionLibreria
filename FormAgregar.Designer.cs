namespace Libreria
{
	partial class FormAgregar
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
			lb_producto = new Label();
			lstvw_articulos = new ListView();
			flowLayoutPanel6 = new FlowLayoutPanel();
			flowLayoutPanel7 = new FlowLayoutPanel();
			lb_cantidad = new Label();
			nmrc_cantidad = new NumericUpDown();
			flowLayoutPanel8 = new FlowLayoutPanel();
			btn_add = new Button();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel6.SuspendLayout();
			flowLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_cantidad).BeginInit();
			flowLayoutPanel8.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(lb_producto);
			flowLayoutPanel1.Controls.Add(lstvw_articulos);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel8);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(12, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(552, 324);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// lb_producto
			// 
			lb_producto.AutoSize = true;
			lb_producto.Location = new Point(3, 0);
			lb_producto.Name = "lb_producto";
			lb_producto.Size = new Size(58, 15);
			lb_producto.TabIndex = 1;
			lb_producto.Text = "Categoria";
			// 
			// lstvw_articulos
			// 
			lstvw_articulos.FullRowSelect = true;
			lstvw_articulos.GridLines = true;
			lstvw_articulos.Location = new Point(3, 18);
			lstvw_articulos.MultiSelect = false;
			lstvw_articulos.Name = "lstvw_articulos";
			lstvw_articulos.Size = new Size(549, 175);
			lstvw_articulos.TabIndex = 3;
			lstvw_articulos.UseCompatibleStateImageBehavior = false;
			lstvw_articulos.View = View.List;
			// 
			// flowLayoutPanel6
			// 
			flowLayoutPanel6.Controls.Add(flowLayoutPanel7);
			flowLayoutPanel6.Controls.Add(nmrc_cantidad);
			flowLayoutPanel6.Location = new Point(3, 199);
			flowLayoutPanel6.Name = "flowLayoutPanel6";
			flowLayoutPanel6.Size = new Size(549, 33);
			flowLayoutPanel6.TabIndex = 2;
			// 
			// flowLayoutPanel7
			// 
			flowLayoutPanel7.Controls.Add(lb_cantidad);
			flowLayoutPanel7.Location = new Point(3, 3);
			flowLayoutPanel7.Name = "flowLayoutPanel7";
			flowLayoutPanel7.Size = new Size(138, 30);
			flowLayoutPanel7.TabIndex = 3;
			// 
			// lb_cantidad
			// 
			lb_cantidad.AutoSize = true;
			lb_cantidad.Location = new Point(3, 0);
			lb_cantidad.Name = "lb_cantidad";
			lb_cantidad.Size = new Size(55, 15);
			lb_cantidad.TabIndex = 0;
			lb_cantidad.Text = "Cantidad";
			// 
			// nmrc_cantidad
			// 
			nmrc_cantidad.Location = new Point(147, 3);
			nmrc_cantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			nmrc_cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nmrc_cantidad.Name = "nmrc_cantidad";
			nmrc_cantidad.Size = new Size(252, 23);
			nmrc_cantidad.TabIndex = 4;
			nmrc_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// flowLayoutPanel8
			// 
			flowLayoutPanel8.Controls.Add(btn_add);
			flowLayoutPanel8.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel8.Location = new Point(3, 238);
			flowLayoutPanel8.Name = "flowLayoutPanel8";
			flowLayoutPanel8.Size = new Size(402, 50);
			flowLayoutPanel8.TabIndex = 3;
			// 
			// btn_add
			// 
			btn_add.Location = new Point(324, 3);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(75, 23);
			btn_add.TabIndex = 0;
			btn_add.Text = "Añadir";
			btn_add.UseVisualStyleBackColor = true;
			btn_add.Click += btn_add_Click;
			// 
			// FormAgregar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(576, 348);
			Controls.Add(flowLayoutPanel1);
			Name = "FormAgregar";
			Text = "FormAgregar";
			Load += FormAgregar_Load;
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			flowLayoutPanel6.ResumeLayout(false);
			flowLayoutPanel7.ResumeLayout(false);
			flowLayoutPanel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_cantidad).EndInit();
			flowLayoutPanel8.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label lb_producto;
		private FlowLayoutPanel flowLayoutPanel8;
		private Button btn_add;
		private ListView lstvw_articulos;
		private FlowLayoutPanel flowLayoutPanel6;
		private FlowLayoutPanel flowLayoutPanel7;
		private Label lb_cantidad;
		private NumericUpDown nmrc_cantidad;
	}
}