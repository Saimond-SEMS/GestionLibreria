namespace Libreria
{
	partial class FormSession
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
			flowLayoutPanel4 = new FlowLayoutPanel();
			label1 = new Label();
			txt_nombre = new TextBox();
			flowLayoutPanel3 = new FlowLayoutPanel();
			flowLayoutPanel5 = new FlowLayoutPanel();
			label2 = new Label();
			txt_clave = new TextBox();
			flowLayoutPanel6 = new FlowLayoutPanel();
			btn_entrar = new Button();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			flowLayoutPanel4.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			flowLayoutPanel5.SuspendLayout();
			flowLayoutPanel6.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(85, 54);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(532, 277);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
			flowLayoutPanel2.Controls.Add(txt_nombre);
			flowLayoutPanel2.Location = new Point(3, 3);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(529, 35);
			flowLayoutPanel2.TabIndex = 0;
			// 
			// flowLayoutPanel4
			// 
			flowLayoutPanel4.Controls.Add(label1);
			flowLayoutPanel4.Location = new Point(3, 3);
			flowLayoutPanel4.Name = "flowLayoutPanel4";
			flowLayoutPanel4.Size = new Size(200, 23);
			flowLayoutPanel4.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(112, 15);
			label1.TabIndex = 0;
			label1.Text = "Nombre de  usuario";
			// 
			// txt_nombre
			// 
			txt_nombre.Location = new Point(209, 3);
			txt_nombre.Name = "txt_nombre";
			txt_nombre.Size = new Size(307, 23);
			txt_nombre.TabIndex = 1;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
			flowLayoutPanel3.Controls.Add(txt_clave);
			flowLayoutPanel3.Location = new Point(3, 44);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(529, 35);
			flowLayoutPanel3.TabIndex = 1;
			// 
			// flowLayoutPanel5
			// 
			flowLayoutPanel5.Controls.Add(label2);
			flowLayoutPanel5.Location = new Point(3, 3);
			flowLayoutPanel5.Name = "flowLayoutPanel5";
			flowLayoutPanel5.Size = new Size(200, 23);
			flowLayoutPanel5.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 0;
			label2.Text = "Clave";
			// 
			// txt_clave
			// 
			txt_clave.Location = new Point(209, 3);
			txt_clave.Name = "txt_clave";
			txt_clave.PasswordChar = '*';
			txt_clave.Size = new Size(307, 23);
			txt_clave.TabIndex = 1;
			// 
			// flowLayoutPanel6
			// 
			flowLayoutPanel6.Controls.Add(btn_entrar);
			flowLayoutPanel6.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel6.Location = new Point(3, 85);
			flowLayoutPanel6.Name = "flowLayoutPanel6";
			flowLayoutPanel6.Size = new Size(516, 35);
			flowLayoutPanel6.TabIndex = 2;
			// 
			// btn_entrar
			// 
			btn_entrar.Location = new Point(438, 3);
			btn_entrar.Name = "btn_entrar";
			btn_entrar.Size = new Size(75, 23);
			btn_entrar.TabIndex = 0;
			btn_entrar.Text = "Entrar";
			btn_entrar.UseVisualStyleBackColor = true;
			btn_entrar.Click += btn_entrar_Click;
			// 
			// FormSession
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(flowLayoutPanel1);
			Name = "FormSession";
			Text = "FormSession";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			flowLayoutPanel4.ResumeLayout(false);
			flowLayoutPanel4.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			flowLayoutPanel5.ResumeLayout(false);
			flowLayoutPanel5.PerformLayout();
			flowLayoutPanel6.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel2;
		private FlowLayoutPanel flowLayoutPanel4;
		private Label label1;
		private TextBox txt_nombre;
		private FlowLayoutPanel flowLayoutPanel3;
		private FlowLayoutPanel flowLayoutPanel5;
		private Label label2;
		private TextBox txt_clave;
		private FlowLayoutPanel flowLayoutPanel6;
		private Button btn_entrar;
		private Button btn_registrar;
	}
}