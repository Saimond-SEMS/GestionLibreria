namespace Libreria
{
	partial class Form1
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
			lstvw = new ListView();
			label1 = new Label();
			SuspendLayout();
			// 
			// lstvw
			// 
			lstvw.Location = new Point(12, 27);
			lstvw.Name = "lstvw";
			lstvw.Size = new Size(544, 250);
			lstvw.TabIndex = 0;
			lstvw.UseCompatibleStateImageBehavior = false;
			lstvw.SelectedIndexChanged += listView1_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(107, 15);
			label1.TabIndex = 1;
			label1.Text = "Articulos a reponer";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(568, 289);
			Controls.Add(label1);
			Controls.Add(lstvw);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView lstvw;
		private Label label1;
	}
}