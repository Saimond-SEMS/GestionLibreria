namespace Libreria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			openFileDialog1 = new OpenFileDialog();
			tabControl1 = new TabControl();
			registrar_tabPage = new TabPage();
			flowLayoutPanel3 = new FlowLayoutPanel();
			flowLayoutPanel4 = new FlowLayoutPanel();
			label2 = new Label();
			flowLayoutPanel5 = new FlowLayoutPanel();
			flowLayoutPanel8 = new FlowLayoutPanel();
			label3 = new Label();
			txt_nombre = new TextBox();
			flowLayoutPanel7 = new FlowLayoutPanel();
			flowLayoutPanel9 = new FlowLayoutPanel();
			label4 = new Label();
			txt_codigo = new TextBox();
			button1 = new Button();
			flowLayoutPanel6 = new FlowLayoutPanel();
			flowLayoutPanel10 = new FlowLayoutPanel();
			label5 = new Label();
			combox_categoria = new ComboBox();
			flowLayoutPanel11 = new FlowLayoutPanel();
			flowLayoutPanel12 = new FlowLayoutPanel();
			label6 = new Label();
			nmrc_precio = new NumericUpDown();
			flowLayoutPanel13 = new FlowLayoutPanel();
			flowLayoutPanel14 = new FlowLayoutPanel();
			label7 = new Label();
			nmrc_stock = new NumericUpDown();
			flowLayoutPanel15 = new FlowLayoutPanel();
			flowLayoutPanel16 = new FlowLayoutPanel();
			label8 = new Label();
			flowLayoutPanel17 = new FlowLayoutPanel();
			flowLayoutPanel18 = new FlowLayoutPanel();
			label9 = new Label();
			nmrc_stockMinimo = new NumericUpDown();
			flowLayoutPanel19 = new FlowLayoutPanel();
			regis_btn_registrar = new Button();
			Editar_tabPage = new TabPage();
			flowLayoutPanel1 = new FlowLayoutPanel();
			flowLayoutPanel2 = new FlowLayoutPanel();
			label1 = new Label();
			flowLayoutPanel20 = new FlowLayoutPanel();
			flowLayoutPanel21 = new FlowLayoutPanel();
			label10 = new Label();
			combox_edit_listaProductos = new ComboBox();
			flowLayoutPanel22 = new FlowLayoutPanel();
			flowLayoutPanel28 = new FlowLayoutPanel();
			label11 = new Label();
			edit_txt_nombre = new TextBox();
			flowLayoutPanel23 = new FlowLayoutPanel();
			flowLayoutPanel29 = new FlowLayoutPanel();
			label12 = new Label();
			edit_combox_categoria = new ComboBox();
			flowLayoutPanel25 = new FlowLayoutPanel();
			flowLayoutPanel33 = new FlowLayoutPanel();
			label13 = new Label();
			edit_nmrc_precio = new NumericUpDown();
			flowLayoutPanel24 = new FlowLayoutPanel();
			flowLayoutPanel30 = new FlowLayoutPanel();
			label14 = new Label();
			edit_nmrc_stock = new NumericUpDown();
			flowLayoutPanel27 = new FlowLayoutPanel();
			flowLayoutPanel31 = new FlowLayoutPanel();
			label15 = new Label();
			edit_nmrc_stockMinimo = new NumericUpDown();
			flowLayoutPanel26 = new FlowLayoutPanel();
			flowLayoutPanel32 = new FlowLayoutPanel();
			label16 = new Label();
			edit_btn_edit = new Button();
			tabPage1 = new TabPage();
			lb_regInfoBox = new Label();
			toolTip1 = new ToolTip(components);
			entradaListaProductoBindingSource = new BindingSource(components);
			entradaListaProductoBindingSource1 = new BindingSource(components);
			listBindingSource = new BindingSource(components);
			tabControl1.SuspendLayout();
			registrar_tabPage.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			flowLayoutPanel4.SuspendLayout();
			flowLayoutPanel5.SuspendLayout();
			flowLayoutPanel8.SuspendLayout();
			flowLayoutPanel7.SuspendLayout();
			flowLayoutPanel9.SuspendLayout();
			flowLayoutPanel6.SuspendLayout();
			flowLayoutPanel10.SuspendLayout();
			flowLayoutPanel11.SuspendLayout();
			flowLayoutPanel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_precio).BeginInit();
			flowLayoutPanel13.SuspendLayout();
			flowLayoutPanel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_stock).BeginInit();
			flowLayoutPanel15.SuspendLayout();
			flowLayoutPanel16.SuspendLayout();
			flowLayoutPanel17.SuspendLayout();
			flowLayoutPanel18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_stockMinimo).BeginInit();
			flowLayoutPanel19.SuspendLayout();
			Editar_tabPage.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			flowLayoutPanel20.SuspendLayout();
			flowLayoutPanel21.SuspendLayout();
			flowLayoutPanel22.SuspendLayout();
			flowLayoutPanel28.SuspendLayout();
			flowLayoutPanel23.SuspendLayout();
			flowLayoutPanel29.SuspendLayout();
			flowLayoutPanel25.SuspendLayout();
			flowLayoutPanel33.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)edit_nmrc_precio).BeginInit();
			flowLayoutPanel24.SuspendLayout();
			flowLayoutPanel30.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)edit_nmrc_stock).BeginInit();
			flowLayoutPanel27.SuspendLayout();
			flowLayoutPanel31.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)edit_nmrc_stockMinimo).BeginInit();
			flowLayoutPanel26.SuspendLayout();
			flowLayoutPanel32.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)entradaListaProductoBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)entradaListaProductoBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)listBindingSource).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(registrar_tabPage);
			tabControl1.Controls.Add(Editar_tabPage);
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Location = new Point(1, 2);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(542, 420);
			tabControl1.TabIndex = 0;
			tabControl1.Enter += tabControl1_Enter;
			// 
			// registrar_tabPage
			// 
			registrar_tabPage.Controls.Add(flowLayoutPanel3);
			registrar_tabPage.Location = new Point(4, 24);
			registrar_tabPage.Name = "registrar_tabPage";
			registrar_tabPage.Padding = new Padding(3);
			registrar_tabPage.Size = new Size(534, 392);
			registrar_tabPage.TabIndex = 2;
			registrar_tabPage.Text = "Registrar";
			registrar_tabPage.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel7);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel6);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel11);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel13);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel17);
			flowLayoutPanel3.Controls.Add(flowLayoutPanel19);
			flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel3.ImeMode = ImeMode.On;
			flowLayoutPanel3.Location = new Point(5, 6);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(528, 343);
			flowLayoutPanel3.TabIndex = 0;
			// 
			// flowLayoutPanel4
			// 
			flowLayoutPanel4.Controls.Add(label2);
			flowLayoutPanel4.Location = new Point(3, 3);
			flowLayoutPanel4.Name = "flowLayoutPanel4";
			flowLayoutPanel4.Size = new Size(522, 53);
			flowLayoutPanel4.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Cyan;
			label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(310, 45);
			label2.TabIndex = 0;
			label2.Text = "Registrar Producto";
			// 
			// flowLayoutPanel5
			// 
			flowLayoutPanel5.Controls.Add(flowLayoutPanel8);
			flowLayoutPanel5.Controls.Add(txt_nombre);
			flowLayoutPanel5.Location = new Point(3, 62);
			flowLayoutPanel5.Name = "flowLayoutPanel5";
			flowLayoutPanel5.Size = new Size(522, 27);
			flowLayoutPanel5.TabIndex = 1;
			// 
			// flowLayoutPanel8
			// 
			flowLayoutPanel8.Controls.Add(label3);
			flowLayoutPanel8.Location = new Point(3, 3);
			flowLayoutPanel8.Name = "flowLayoutPanel8";
			flowLayoutPanel8.Size = new Size(98, 24);
			flowLayoutPanel8.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 3;
			label3.Text = "Nombre";
			// 
			// txt_nombre
			// 
			txt_nombre.Location = new Point(107, 3);
			txt_nombre.Name = "txt_nombre";
			txt_nombre.Size = new Size(327, 23);
			txt_nombre.TabIndex = 1;
			txt_nombre.TextChanged += textBox1_TextChanged;
			// 
			// flowLayoutPanel7
			// 
			flowLayoutPanel7.Controls.Add(flowLayoutPanel9);
			flowLayoutPanel7.Controls.Add(txt_codigo);
			flowLayoutPanel7.Controls.Add(button1);
			flowLayoutPanel7.Location = new Point(3, 95);
			flowLayoutPanel7.Name = "flowLayoutPanel7";
			flowLayoutPanel7.Size = new Size(522, 27);
			flowLayoutPanel7.TabIndex = 3;
			// 
			// flowLayoutPanel9
			// 
			flowLayoutPanel9.Controls.Add(label4);
			flowLayoutPanel9.Location = new Point(3, 3);
			flowLayoutPanel9.Name = "flowLayoutPanel9";
			flowLayoutPanel9.Size = new Size(98, 24);
			flowLayoutPanel9.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 0;
			label4.Text = "Codigo";
			// 
			// txt_codigo
			// 
			txt_codigo.Location = new Point(107, 3);
			txt_codigo.Name = "txt_codigo";
			txt_codigo.Size = new Size(287, 23);
			txt_codigo.TabIndex = 2;
			txt_codigo.TextChanged += textBox2_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(400, 3);
			button1.Name = "button1";
			button1.Size = new Size(34, 23);
			button1.TabIndex = 3;
			button1.Text = "R";
			button1.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel6
			// 
			flowLayoutPanel6.Controls.Add(flowLayoutPanel10);
			flowLayoutPanel6.Controls.Add(combox_categoria);
			flowLayoutPanel6.Location = new Point(3, 128);
			flowLayoutPanel6.Name = "flowLayoutPanel6";
			flowLayoutPanel6.Size = new Size(522, 27);
			flowLayoutPanel6.TabIndex = 2;
			// 
			// flowLayoutPanel10
			// 
			flowLayoutPanel10.Controls.Add(label5);
			flowLayoutPanel10.Location = new Point(3, 3);
			flowLayoutPanel10.Name = "flowLayoutPanel10";
			flowLayoutPanel10.Size = new Size(98, 24);
			flowLayoutPanel10.TabIndex = 2;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 0);
			label5.Name = "label5";
			label5.Size = new Size(58, 15);
			label5.TabIndex = 0;
			label5.Text = "Categoría";
			// 
			// combox_categoria
			// 
			combox_categoria.FormattingEnabled = true;
			combox_categoria.Location = new Point(107, 3);
			combox_categoria.Name = "combox_categoria";
			combox_categoria.Size = new Size(327, 23);
			combox_categoria.TabIndex = 3;
			combox_categoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
			// 
			// flowLayoutPanel11
			// 
			flowLayoutPanel11.Controls.Add(flowLayoutPanel12);
			flowLayoutPanel11.Controls.Add(nmrc_precio);
			flowLayoutPanel11.Location = new Point(3, 161);
			flowLayoutPanel11.Name = "flowLayoutPanel11";
			flowLayoutPanel11.Size = new Size(522, 27);
			flowLayoutPanel11.TabIndex = 4;
			// 
			// flowLayoutPanel12
			// 
			flowLayoutPanel12.Controls.Add(label6);
			flowLayoutPanel12.Location = new Point(3, 3);
			flowLayoutPanel12.Name = "flowLayoutPanel12";
			flowLayoutPanel12.Size = new Size(98, 24);
			flowLayoutPanel12.TabIndex = 0;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 0);
			label6.Name = "label6";
			label6.Size = new Size(40, 15);
			label6.TabIndex = 0;
			label6.Text = "Precio";
			// 
			// nmrc_precio
			// 
			nmrc_precio.Location = new Point(107, 3);
			nmrc_precio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nmrc_precio.Name = "nmrc_precio";
			nmrc_precio.Size = new Size(327, 23);
			nmrc_precio.TabIndex = 4;
			nmrc_precio.ThousandsSeparator = true;
			nmrc_precio.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// flowLayoutPanel13
			// 
			flowLayoutPanel13.Controls.Add(flowLayoutPanel14);
			flowLayoutPanel13.Controls.Add(nmrc_stock);
			flowLayoutPanel13.Controls.Add(flowLayoutPanel15);
			flowLayoutPanel13.Location = new Point(3, 194);
			flowLayoutPanel13.Name = "flowLayoutPanel13";
			flowLayoutPanel13.Size = new Size(522, 27);
			flowLayoutPanel13.TabIndex = 5;
			// 
			// flowLayoutPanel14
			// 
			flowLayoutPanel14.Controls.Add(label7);
			flowLayoutPanel14.Location = new Point(3, 3);
			flowLayoutPanel14.Name = "flowLayoutPanel14";
			flowLayoutPanel14.Size = new Size(98, 24);
			flowLayoutPanel14.TabIndex = 0;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(3, 0);
			label7.Name = "label7";
			label7.Size = new Size(36, 15);
			label7.TabIndex = 0;
			label7.Text = "Stock";
			// 
			// nmrc_stock
			// 
			nmrc_stock.Location = new Point(107, 3);
			nmrc_stock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nmrc_stock.Name = "nmrc_stock";
			nmrc_stock.Size = new Size(327, 23);
			nmrc_stock.TabIndex = 5;
			nmrc_stock.ValueChanged += numericUpDown2_ValueChanged;
			// 
			// flowLayoutPanel15
			// 
			flowLayoutPanel15.Controls.Add(flowLayoutPanel16);
			flowLayoutPanel15.Location = new Point(3, 33);
			flowLayoutPanel15.Name = "flowLayoutPanel15";
			flowLayoutPanel15.Size = new Size(522, 27);
			flowLayoutPanel15.TabIndex = 6;
			// 
			// flowLayoutPanel16
			// 
			flowLayoutPanel16.Controls.Add(label8);
			flowLayoutPanel16.Location = new Point(3, 3);
			flowLayoutPanel16.Name = "flowLayoutPanel16";
			flowLayoutPanel16.Size = new Size(98, 24);
			flowLayoutPanel16.TabIndex = 0;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(3, 0);
			label8.Name = "label8";
			label8.Size = new Size(36, 15);
			label8.TabIndex = 0;
			label8.Text = "Stock";
			// 
			// flowLayoutPanel17
			// 
			flowLayoutPanel17.Controls.Add(flowLayoutPanel18);
			flowLayoutPanel17.Controls.Add(nmrc_stockMinimo);
			flowLayoutPanel17.Location = new Point(3, 227);
			flowLayoutPanel17.Name = "flowLayoutPanel17";
			flowLayoutPanel17.Size = new Size(522, 27);
			flowLayoutPanel17.TabIndex = 6;
			// 
			// flowLayoutPanel18
			// 
			flowLayoutPanel18.Controls.Add(label9);
			flowLayoutPanel18.Location = new Point(3, 3);
			flowLayoutPanel18.Name = "flowLayoutPanel18";
			flowLayoutPanel18.Size = new Size(98, 24);
			flowLayoutPanel18.TabIndex = 0;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(3, 0);
			label9.Name = "label9";
			label9.Size = new Size(81, 15);
			label9.TabIndex = 0;
			label9.Text = "Stock mínimo";
			// 
			// nmrc_stockMinimo
			// 
			nmrc_stockMinimo.Location = new Point(107, 3);
			nmrc_stockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nmrc_stockMinimo.Name = "nmrc_stockMinimo";
			nmrc_stockMinimo.Size = new Size(327, 23);
			nmrc_stockMinimo.TabIndex = 6;
			nmrc_stockMinimo.ValueChanged += numericUpDown3_ValueChanged;
			// 
			// flowLayoutPanel19
			// 
			flowLayoutPanel19.Controls.Add(regis_btn_registrar);
			flowLayoutPanel19.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel19.Location = new Point(3, 260);
			flowLayoutPanel19.Name = "flowLayoutPanel19";
			flowLayoutPanel19.Size = new Size(434, 27);
			flowLayoutPanel19.TabIndex = 7;
			// 
			// regis_btn_registrar
			// 
			regis_btn_registrar.Location = new Point(356, 3);
			regis_btn_registrar.Name = "regis_btn_registrar";
			regis_btn_registrar.Size = new Size(75, 23);
			regis_btn_registrar.TabIndex = 8;
			regis_btn_registrar.Text = "Registrar";
			regis_btn_registrar.UseVisualStyleBackColor = true;
			regis_btn_registrar.Click += button2_Click;
			// 
			// Editar_tabPage
			// 
			Editar_tabPage.BackColor = SystemColors.Window;
			Editar_tabPage.Controls.Add(flowLayoutPanel1);
			Editar_tabPage.Location = new Point(4, 24);
			Editar_tabPage.Name = "Editar_tabPage";
			Editar_tabPage.Padding = new Padding(3);
			Editar_tabPage.Size = new Size(534, 392);
			Editar_tabPage.TabIndex = 1;
			Editar_tabPage.Text = "Editar";
			Editar_tabPage.Enter += Editar_tabPage_Enter;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel20);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel22);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel23);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel25);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel24);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel27);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel26);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(3, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(525, 371);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(label1);
			flowLayoutPanel2.Location = new Point(3, 3);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(443, 53);
			flowLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Cyan;
			label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(263, 45);
			label1.TabIndex = 0;
			label1.Text = "Editar Producto";
			// 
			// flowLayoutPanel20
			// 
			flowLayoutPanel20.Controls.Add(flowLayoutPanel21);
			flowLayoutPanel20.Controls.Add(combox_edit_listaProductos);
			flowLayoutPanel20.Location = new Point(3, 62);
			flowLayoutPanel20.Name = "flowLayoutPanel20";
			flowLayoutPanel20.Size = new Size(522, 27);
			flowLayoutPanel20.TabIndex = 1;
			// 
			// flowLayoutPanel21
			// 
			flowLayoutPanel21.Controls.Add(label10);
			flowLayoutPanel21.Location = new Point(3, 3);
			flowLayoutPanel21.Name = "flowLayoutPanel21";
			flowLayoutPanel21.Size = new Size(200, 27);
			flowLayoutPanel21.TabIndex = 1;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(3, 0);
			label10.Name = "label10";
			label10.Size = new Size(56, 15);
			label10.TabIndex = 0;
			label10.Text = "Producto";
			// 
			// combox_edit_listaProductos
			// 
			combox_edit_listaProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
			combox_edit_listaProductos.DisplayMember = "Dispatcher";
			combox_edit_listaProductos.FormattingEnabled = true;
			combox_edit_listaProductos.Location = new Point(209, 3);
			combox_edit_listaProductos.Name = "combox_edit_listaProductos";
			combox_edit_listaProductos.Size = new Size(188, 23);
			combox_edit_listaProductos.TabIndex = 0;
			combox_edit_listaProductos.ValueMember = "Dispatcher";
			combox_edit_listaProductos.SelectedIndexChanged += combox_edit_listaProductos_DisplayMemberChanged;
			// 
			// flowLayoutPanel22
			// 
			flowLayoutPanel22.Controls.Add(flowLayoutPanel28);
			flowLayoutPanel22.Controls.Add(edit_txt_nombre);
			flowLayoutPanel22.Location = new Point(3, 95);
			flowLayoutPanel22.Name = "flowLayoutPanel22";
			flowLayoutPanel22.Size = new Size(522, 27);
			flowLayoutPanel22.TabIndex = 2;
			// 
			// flowLayoutPanel28
			// 
			flowLayoutPanel28.Controls.Add(label11);
			flowLayoutPanel28.Location = new Point(3, 3);
			flowLayoutPanel28.Name = "flowLayoutPanel28";
			flowLayoutPanel28.Size = new Size(200, 24);
			flowLayoutPanel28.TabIndex = 0;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(3, 0);
			label11.Name = "label11";
			label11.Size = new Size(51, 15);
			label11.TabIndex = 0;
			label11.Text = "Nombre";
			// 
			// edit_txt_nombre
			// 
			edit_txt_nombre.Enabled = false;
			edit_txt_nombre.Location = new Point(209, 3);
			edit_txt_nombre.Name = "edit_txt_nombre";
			edit_txt_nombre.Size = new Size(297, 23);
			edit_txt_nombre.TabIndex = 1;
			edit_txt_nombre.TextChanged += edit_somethingChanged;
			// 
			// flowLayoutPanel23
			// 
			flowLayoutPanel23.Controls.Add(flowLayoutPanel29);
			flowLayoutPanel23.Controls.Add(edit_combox_categoria);
			flowLayoutPanel23.Location = new Point(3, 128);
			flowLayoutPanel23.Name = "flowLayoutPanel23";
			flowLayoutPanel23.Size = new Size(522, 27);
			flowLayoutPanel23.TabIndex = 3;
			// 
			// flowLayoutPanel29
			// 
			flowLayoutPanel29.Controls.Add(label12);
			flowLayoutPanel29.Location = new Point(3, 3);
			flowLayoutPanel29.Name = "flowLayoutPanel29";
			flowLayoutPanel29.Size = new Size(200, 24);
			flowLayoutPanel29.TabIndex = 0;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(3, 0);
			label12.Name = "label12";
			label12.Size = new Size(58, 15);
			label12.TabIndex = 0;
			label12.Text = "Categoria";
			// 
			// edit_combox_categoria
			// 
			edit_combox_categoria.Enabled = false;
			edit_combox_categoria.FormattingEnabled = true;
			edit_combox_categoria.Location = new Point(209, 3);
			edit_combox_categoria.Name = "edit_combox_categoria";
			edit_combox_categoria.Size = new Size(297, 23);
			edit_combox_categoria.TabIndex = 2;
			edit_combox_categoria.TabIndexChanged += edit_somethingChanged;
			// 
			// flowLayoutPanel25
			// 
			flowLayoutPanel25.Controls.Add(flowLayoutPanel33);
			flowLayoutPanel25.Controls.Add(edit_nmrc_precio);
			flowLayoutPanel25.Location = new Point(3, 161);
			flowLayoutPanel25.Name = "flowLayoutPanel25";
			flowLayoutPanel25.Size = new Size(522, 27);
			flowLayoutPanel25.TabIndex = 5;
			// 
			// flowLayoutPanel33
			// 
			flowLayoutPanel33.Controls.Add(label13);
			flowLayoutPanel33.Location = new Point(3, 3);
			flowLayoutPanel33.Name = "flowLayoutPanel33";
			flowLayoutPanel33.Size = new Size(200, 24);
			flowLayoutPanel33.TabIndex = 0;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(3, 0);
			label13.Name = "label13";
			label13.Size = new Size(40, 15);
			label13.TabIndex = 0;
			label13.Text = "Precio";
			// 
			// edit_nmrc_precio
			// 
			edit_nmrc_precio.Enabled = false;
			edit_nmrc_precio.Location = new Point(209, 3);
			edit_nmrc_precio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			edit_nmrc_precio.Name = "edit_nmrc_precio";
			edit_nmrc_precio.Size = new Size(297, 23);
			edit_nmrc_precio.TabIndex = 3;
			edit_nmrc_precio.ValueChanged += edit_somethingChanged;
			// 
			// flowLayoutPanel24
			// 
			flowLayoutPanel24.Controls.Add(flowLayoutPanel30);
			flowLayoutPanel24.Controls.Add(edit_nmrc_stock);
			flowLayoutPanel24.Location = new Point(3, 194);
			flowLayoutPanel24.Name = "flowLayoutPanel24";
			flowLayoutPanel24.Size = new Size(522, 27);
			flowLayoutPanel24.TabIndex = 4;
			// 
			// flowLayoutPanel30
			// 
			flowLayoutPanel30.Controls.Add(label14);
			flowLayoutPanel30.Location = new Point(3, 3);
			flowLayoutPanel30.Name = "flowLayoutPanel30";
			flowLayoutPanel30.Size = new Size(200, 24);
			flowLayoutPanel30.TabIndex = 0;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(3, 0);
			label14.Name = "label14";
			label14.Size = new Size(36, 15);
			label14.TabIndex = 0;
			label14.Text = "Stock";
			// 
			// edit_nmrc_stock
			// 
			edit_nmrc_stock.Enabled = false;
			edit_nmrc_stock.Location = new Point(209, 3);
			edit_nmrc_stock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			edit_nmrc_stock.Name = "edit_nmrc_stock";
			edit_nmrc_stock.Size = new Size(297, 23);
			edit_nmrc_stock.TabIndex = 4;
			edit_nmrc_stock.ValueChanged += edit_somethingChanged;
			// 
			// flowLayoutPanel27
			// 
			flowLayoutPanel27.Controls.Add(flowLayoutPanel31);
			flowLayoutPanel27.Controls.Add(edit_nmrc_stockMinimo);
			flowLayoutPanel27.Location = new Point(3, 227);
			flowLayoutPanel27.Name = "flowLayoutPanel27";
			flowLayoutPanel27.Size = new Size(522, 27);
			flowLayoutPanel27.TabIndex = 7;
			// 
			// flowLayoutPanel31
			// 
			flowLayoutPanel31.Controls.Add(label15);
			flowLayoutPanel31.Location = new Point(3, 3);
			flowLayoutPanel31.Name = "flowLayoutPanel31";
			flowLayoutPanel31.Size = new Size(200, 24);
			flowLayoutPanel31.TabIndex = 0;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(3, 0);
			label15.Name = "label15";
			label15.Size = new Size(81, 15);
			label15.TabIndex = 0;
			label15.Text = "Stock Mínimo";
			// 
			// edit_nmrc_stockMinimo
			// 
			edit_nmrc_stockMinimo.Enabled = false;
			edit_nmrc_stockMinimo.Location = new Point(209, 3);
			edit_nmrc_stockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			edit_nmrc_stockMinimo.Name = "edit_nmrc_stockMinimo";
			edit_nmrc_stockMinimo.Size = new Size(297, 23);
			edit_nmrc_stockMinimo.TabIndex = 5;
			edit_nmrc_stockMinimo.ValueChanged += edit_somethingChanged;
			// 
			// flowLayoutPanel26
			// 
			flowLayoutPanel26.Controls.Add(flowLayoutPanel32);
			flowLayoutPanel26.Location = new Point(3, 260);
			flowLayoutPanel26.Name = "flowLayoutPanel26";
			flowLayoutPanel26.Size = new Size(522, 27);
			flowLayoutPanel26.TabIndex = 6;
			// 
			// flowLayoutPanel32
			// 
			flowLayoutPanel32.Controls.Add(label16);
			flowLayoutPanel32.Controls.Add(edit_btn_edit);
			flowLayoutPanel32.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel32.Location = new Point(3, 3);
			flowLayoutPanel32.Name = "flowLayoutPanel32";
			flowLayoutPanel32.Size = new Size(411, 24);
			flowLayoutPanel32.TabIndex = 0;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(408, 0);
			label16.Name = "label16";
			label16.Size = new Size(0, 15);
			label16.TabIndex = 0;
			// 
			// edit_btn_edit
			// 
			edit_btn_edit.Location = new Point(327, 3);
			edit_btn_edit.Name = "edit_btn_edit";
			edit_btn_edit.Size = new Size(75, 23);
			edit_btn_edit.TabIndex = 6;
			edit_btn_edit.Text = "Editar producto";
			edit_btn_edit.UseVisualStyleBackColor = true;
			edit_btn_edit.Click += edit_btn_edit_Click;
			// 
			// tabPage1
			// 
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(534, 392);
			tabPage1.TabIndex = 3;
			tabPage1.Text = "tabPage1";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// lb_regInfoBox
			// 
			lb_regInfoBox.AutoSize = true;
			lb_regInfoBox.BackColor = SystemColors.Info;
			lb_regInfoBox.ImageAlign = ContentAlignment.MiddleRight;
			lb_regInfoBox.Location = new Point(5, 426);
			lb_regInfoBox.Name = "lb_regInfoBox";
			lb_regInfoBox.Size = new Size(48, 15);
			lb_regInfoBox.TabIndex = 2;
			lb_regInfoBox.Text = "infobox";
			lb_regInfoBox.TextAlign = ContentAlignment.MiddleRight;
			lb_regInfoBox.Validated += lb_regInfoBox_Validated;
			// 
			// entradaListaProductoBindingSource
			// 
			entradaListaProductoBindingSource.DataSource = typeof(EntradaListaProducto);
			// 
			// entradaListaProductoBindingSource1
			// 
			entradaListaProductoBindingSource1.DataSource = typeof(EntradaListaProducto);
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(545, 450);
			Controls.Add(lb_regInfoBox);
			Controls.Add(tabControl1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			tabControl1.ResumeLayout(false);
			registrar_tabPage.ResumeLayout(false);
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel4.ResumeLayout(false);
			flowLayoutPanel4.PerformLayout();
			flowLayoutPanel5.ResumeLayout(false);
			flowLayoutPanel5.PerformLayout();
			flowLayoutPanel8.ResumeLayout(false);
			flowLayoutPanel8.PerformLayout();
			flowLayoutPanel7.ResumeLayout(false);
			flowLayoutPanel7.PerformLayout();
			flowLayoutPanel9.ResumeLayout(false);
			flowLayoutPanel9.PerformLayout();
			flowLayoutPanel6.ResumeLayout(false);
			flowLayoutPanel10.ResumeLayout(false);
			flowLayoutPanel10.PerformLayout();
			flowLayoutPanel11.ResumeLayout(false);
			flowLayoutPanel12.ResumeLayout(false);
			flowLayoutPanel12.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_precio).EndInit();
			flowLayoutPanel13.ResumeLayout(false);
			flowLayoutPanel14.ResumeLayout(false);
			flowLayoutPanel14.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_stock).EndInit();
			flowLayoutPanel15.ResumeLayout(false);
			flowLayoutPanel16.ResumeLayout(false);
			flowLayoutPanel16.PerformLayout();
			flowLayoutPanel17.ResumeLayout(false);
			flowLayoutPanel18.ResumeLayout(false);
			flowLayoutPanel18.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrc_stockMinimo).EndInit();
			flowLayoutPanel19.ResumeLayout(false);
			Editar_tabPage.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			flowLayoutPanel20.ResumeLayout(false);
			flowLayoutPanel21.ResumeLayout(false);
			flowLayoutPanel21.PerformLayout();
			flowLayoutPanel22.ResumeLayout(false);
			flowLayoutPanel22.PerformLayout();
			flowLayoutPanel28.ResumeLayout(false);
			flowLayoutPanel28.PerformLayout();
			flowLayoutPanel23.ResumeLayout(false);
			flowLayoutPanel29.ResumeLayout(false);
			flowLayoutPanel29.PerformLayout();
			flowLayoutPanel25.ResumeLayout(false);
			flowLayoutPanel33.ResumeLayout(false);
			flowLayoutPanel33.PerformLayout();
			((System.ComponentModel.ISupportInitialize)edit_nmrc_precio).EndInit();
			flowLayoutPanel24.ResumeLayout(false);
			flowLayoutPanel30.ResumeLayout(false);
			flowLayoutPanel30.PerformLayout();
			((System.ComponentModel.ISupportInitialize)edit_nmrc_stock).EndInit();
			flowLayoutPanel27.ResumeLayout(false);
			flowLayoutPanel31.ResumeLayout(false);
			flowLayoutPanel31.PerformLayout();
			((System.ComponentModel.ISupportInitialize)edit_nmrc_stockMinimo).EndInit();
			flowLayoutPanel26.ResumeLayout(false);
			flowLayoutPanel32.ResumeLayout(false);
			flowLayoutPanel32.PerformLayout();
			((System.ComponentModel.ISupportInitialize)entradaListaProductoBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)entradaListaProductoBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)listBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private OpenFileDialog openFileDialog1;
		private TabControl tabControl1;
		private TabPage Editar_tabPage;
		private ToolTip toolTip1;
		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel2;
		private Label label1;
		private TabPage registrar_tabPage;
		private FlowLayoutPanel flowLayoutPanel3;
		private FlowLayoutPanel flowLayoutPanel4;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel5;
		private TextBox txt_nombre;
		private FlowLayoutPanel flowLayoutPanel7;
		private Label label4;
		private TextBox txt_codigo;
		private FlowLayoutPanel flowLayoutPanel6;
		private Label label5;
		private ComboBox combox_categoria;
		private FlowLayoutPanel flowLayoutPanel8;
		private Label label3;
		private FlowLayoutPanel flowLayoutPanel9;
		private FlowLayoutPanel flowLayoutPanel10;
		private FlowLayoutPanel flowLayoutPanel11;
		private FlowLayoutPanel flowLayoutPanel12;
		private Label label6;
		private NumericUpDown nmrc_precio;
		private Button button1;
		private FlowLayoutPanel flowLayoutPanel13;
		private FlowLayoutPanel flowLayoutPanel14;
		private Label label7;
		private FlowLayoutPanel flowLayoutPanel15;
		private FlowLayoutPanel flowLayoutPanel16;
		private Label label8;
		private FlowLayoutPanel flowLayoutPanel17;
		private NumericUpDown nmrc_stock;
		private FlowLayoutPanel flowLayoutPanel18;
		private Label label9;
		private NumericUpDown nmrc_stockMinimo;
		private FlowLayoutPanel flowLayoutPanel19;
		private FlowLayoutPanel flowLayoutPanel20;
		private ComboBox combox_edit_listaProductos;
		private BindingSource entradaListaProductoBindingSource;
		private BindingSource entradaListaProductoBindingSource1;
		private BindingSource listBindingSource;
		private Label lb_regInfoBox;
		private FlowLayoutPanel flowLayoutPanel21;
		private Label label10;
		private FlowLayoutPanel flowLayoutPanel22;
		private FlowLayoutPanel flowLayoutPanel23;
		private FlowLayoutPanel flowLayoutPanel25;
		private FlowLayoutPanel flowLayoutPanel24;
		private FlowLayoutPanel flowLayoutPanel27;
		private FlowLayoutPanel flowLayoutPanel26;
		private FlowLayoutPanel flowLayoutPanel28;
		private Label label11;
		private FlowLayoutPanel flowLayoutPanel29;
		private Label label12;
		private FlowLayoutPanel flowLayoutPanel33;
		private Label label13;
		private FlowLayoutPanel flowLayoutPanel30;
		private Label label14;
		private FlowLayoutPanel flowLayoutPanel31;
		private Label label15;
		private FlowLayoutPanel flowLayoutPanel32;
		private Label label16;
		private TextBox edit_txt_nombre;
		private ComboBox edit_combox_categoria;
		private TabPage tabPage1;
		private NumericUpDown edit_nmrc_precio;
		private NumericUpDown edit_nmrc_stock;
		private NumericUpDown edit_nmrc_stockMinimo;
		private Button regis_btn_registrar;
		private Button edit_btn_edit;
	}
}
