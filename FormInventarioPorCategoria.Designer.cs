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
			SuspendLayout();
			// 
			// lstvw_inventarioPorCat
			// 
			lstvw_inventarioPorCat.Location = new Point(12, 12);
			lstvw_inventarioPorCat.Name = "lstvw_inventarioPorCat";
			lstvw_inventarioPorCat.Size = new Size(644, 248);
			lstvw_inventarioPorCat.TabIndex = 0;
			lstvw_inventarioPorCat.UseCompatibleStateImageBehavior = false;
			// 
			// FormInventarioPorCategoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 272);
			Controls.Add(lstvw_inventarioPorCat);
			Name = "FormInventarioPorCategoria";
			Text = "FormInventarioPorCategoria";
			Load += FormInventarioPorCategoria_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListView lstvw_inventarioPorCat;
	}
}