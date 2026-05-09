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
			nmrc_cantidad = new NumericUpDown();
			flowLayoutPanel2 = new FlowLayoutPanel();
			btn_vender = new Button();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_cantidad).BeginInit();
			flowLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(lstvw_inventario);
			flowLayoutPanel1.Controls.Add(nmrc_cantidad);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(12, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(733, 305);
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
			lstvw_inventario.Location = new Point(3, 18);
			lstvw_inventario.Name = "lstvw_inventario";
			lstvw_inventario.Size = new Size(730, 172);
			lstvw_inventario.TabIndex = 0;
			lstvw_inventario.UseCompatibleStateImageBehavior = false;
			// 
			// nmrc_cantidad
			// 
			nmrc_cantidad.Location = new Point(3, 196);
			nmrc_cantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			nmrc_cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nmrc_cantidad.Name = "nmrc_cantidad";
			nmrc_cantidad.Size = new Size(254, 23);
			nmrc_cantidad.TabIndex = 3;
			nmrc_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(btn_vender);
			flowLayoutPanel2.Location = new Point(3, 225);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(624, 50);
			flowLayoutPanel2.TabIndex = 2;
			// 
			// btn_vender
			// 
			btn_vender.Location = new Point(3, 3);
			btn_vender.Name = "btn_vender";
			btn_vender.Size = new Size(75, 23);
			btn_vender.TabIndex = 0;
			btn_vender.Text = "Vender";
			btn_vender.UseVisualStyleBackColor = true;
			btn_vender.Click += btn_vender_Click;
			// 
			// FormVender
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(757, 329);
			Controls.Add(flowLayoutPanel1);
			Name = "FormVender";
			Text = "FormVender";
			Load += FormVender_Load;
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_cantidad).EndInit();
			flowLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label label1;
		private ListView lstvw_inventario;
		private FlowLayoutPanel flowLayoutPanel2;
		private Button btn_vender;
		private NumericUpDown nmrc_cantidad;
	}
}