namespace Libreria
{
	partial class FormCatalogoPorCategoria
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
			lstvw_catalogoPorCategoria = new ListView();
			SuspendLayout();
			// 
			// lstvw_catalogoPorCategoria
			// 
			lstvw_catalogoPorCategoria.FullRowSelect = true;
			lstvw_catalogoPorCategoria.GridLines = true;
			lstvw_catalogoPorCategoria.Location = new Point(12, 12);
			lstvw_catalogoPorCategoria.Name = "lstvw_catalogoPorCategoria";
			lstvw_catalogoPorCategoria.Size = new Size(631, 290);
			lstvw_catalogoPorCategoria.TabIndex = 0;
			lstvw_catalogoPorCategoria.UseCompatibleStateImageBehavior = false;
			// 
			// FormCatalogoPorCategoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(655, 314);
			Controls.Add(lstvw_catalogoPorCategoria);
			Name = "FormCatalogoPorCategoria";
			Text = "FormCatalogoPorCategoria";
			Load += FormCatalogoPorCategoria_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListView lstvw_catalogoPorCategoria;
	}
}