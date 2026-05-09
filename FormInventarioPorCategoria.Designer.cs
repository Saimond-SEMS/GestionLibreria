namespace Libreria
{
	partial class FormInventarioPorCategoria
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
			lstvw_inventarioPorCat = new ListView();
			label1 = new Label();
			SuspendLayout();
			// 
			// lstvw_inventarioPorCat
			// 
			lstvw_inventarioPorCat.FullRowSelect = true;
			lstvw_inventarioPorCat.GridLines = true;
			lstvw_inventarioPorCat.Location = new Point(12, 30);
			lstvw_inventarioPorCat.Name = "lstvw_inventarioPorCat";
			lstvw_inventarioPorCat.Size = new Size(644, 230);
			lstvw_inventarioPorCat.TabIndex = 0;
			lstvw_inventarioPorCat.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 12);
			label1.Name = "label1";
			label1.Size = new Size(95, 15);
			label1.TabIndex = 1;
			label1.Text = "Inventario actual";
			// 
			// FormInventarioPorCategoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 272);
			Controls.Add(label1);
			Controls.Add(lstvw_inventarioPorCat);
			Name = "FormInventarioPorCategoria";
			Text = "FormInventarioPorCategoria";
			Load += FormInventarioPorCategoria_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView lstvw_inventarioPorCat;
		private Label label1;
	}
}