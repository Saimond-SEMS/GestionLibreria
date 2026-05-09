namespace Libreria
{
	partial class FormInventario
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
			lstvw_inventario = new ListView();
			SuspendLayout();
			// 
			// lstvw_inventario
			// 
			lstvw_inventario.FullRowSelect = true;
			lstvw_inventario.GridLines = true;
			lstvw_inventario.Location = new Point(12, 12);
			lstvw_inventario.Name = "lstvw_inventario";
			lstvw_inventario.Size = new Size(644, 248);
			lstvw_inventario.TabIndex = 0;
			lstvw_inventario.UseCompatibleStateImageBehavior = false;
			// 
			// FormInventario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 272);
			Controls.Add(lstvw_inventario);
			Name = "FormInventario";
			Text = "FormInventario";
			Load += FormInventario_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListView lstvw_inventario;
	}
}