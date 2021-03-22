namespace MultiFashion.Vistas.Ventas
{
    partial class Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.dgvVentasPedido = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UCComboBox = new MultiFashion.Componentes.UCcomboBoxCliente();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolioVenta = new System.Windows.Forms.TextBox();
            this.rbtnSelTodo = new RoundButton.RoundButton();
            this.rbtnVender = new RoundButton.RoundButton();
            this.rbtnAgregarPedido = new RoundButton.RoundButton();
            this.rbtnAgregarModelo = new RoundButton.RoundButton();
            this.rbtnAplicarDevolucion = new RoundButton.RoundButton();
            this.UCBarraSuperior = new MultiFashion.Componentes.UCBarraSuperior();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLeyenda1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasPedido)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentasPedido
            // 
            this.dgvVentasPedido.AllowUserToAddRows = false;
            this.dgvVentasPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentasPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVentasPedido.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvVentasPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentasPedido.ColumnHeadersHeight = 50;
            this.dgvVentasPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentasPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvVentasPedido.EnableHeadersVisualStyles = false;
            this.dgvVentasPedido.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvVentasPedido.Location = new System.Drawing.Point(11, 146);
            this.dgvVentasPedido.Name = "dgvVentasPedido";
            this.dgvVentasPedido.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentasPedido.RowHeadersVisible = false;
            this.dgvVentasPedido.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvVentasPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentasPedido.RowTemplate.Height = 30;
            this.dgvVentasPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasPedido.Size = new System.Drawing.Size(860, 337);
            this.dgvVentasPedido.TabIndex = 31;
            this.dgvVentasPedido.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvVentasPedido_UserDeletedRow);
            this.dgvVentasPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPedidosFinal_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDPedido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modelo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Color";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Talla";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio Cliente";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UCComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(11, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 88);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // UCComboBox
            // 
            this.UCComboBox.Location = new System.Drawing.Point(81, 44);
            this.UCComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.UCComboBox.Name = "UCComboBox";
            this.UCComboBox.Size = new System.Drawing.Size(375, 35);
            this.UCComboBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Articulos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 102);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTotal.Location = new System.Drawing.Point(118, 69);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(55, 24);
            this.lbTotal.TabIndex = 60;
            this.lbTotal.Text = "$0.00";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCantidad.Location = new System.Drawing.Point(118, 30);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(20, 24);
            this.lbCantidad.TabIndex = 59;
            this.lbCantidad.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(498, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Folio:";
            // 
            // txtFolioVenta
            // 
            this.txtFolioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtFolioVenta.Location = new System.Drawing.Point(561, 70);
            this.txtFolioVenta.Name = "txtFolioVenta";
            this.txtFolioVenta.Size = new System.Drawing.Size(248, 29);
            this.txtFolioVenta.TabIndex = 63;
            this.txtFolioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // rbtnSelTodo
            // 
            this.rbtnSelTodo.BorderColor = System.Drawing.Color.Silver;
            this.rbtnSelTodo.ButtonColor = System.Drawing.Color.Red;
            this.rbtnSelTodo.Location = new System.Drawing.Point(344, 11);
            this.rbtnSelTodo.Name = "rbtnSelTodo";
            this.rbtnSelTodo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnSelTodo.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnSelTodo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnSelTodo.Size = new System.Drawing.Size(137, 38);
            this.rbtnSelTodo.TabIndex = 65;
            this.rbtnSelTodo.Text = "Sel. Todo";
            this.rbtnSelTodo.TextColor = System.Drawing.Color.White;
            this.rbtnSelTodo.UseVisualStyleBackColor = true;
            this.rbtnSelTodo.Click += new System.EventHandler(this.rbtnSelTodo_Click);
            // 
            // rbtnVender
            // 
            this.rbtnVender.BorderColor = System.Drawing.Color.Silver;
            this.rbtnVender.ButtonColor = System.Drawing.Color.Red;
            this.rbtnVender.Location = new System.Drawing.Point(344, 55);
            this.rbtnVender.Name = "rbtnVender";
            this.rbtnVender.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnVender.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnVender.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnVender.Size = new System.Drawing.Size(137, 39);
            this.rbtnVender.TabIndex = 66;
            this.rbtnVender.Text = "Vender(Enter)";
            this.rbtnVender.TextColor = System.Drawing.Color.White;
            this.rbtnVender.UseVisualStyleBackColor = true;
            this.rbtnVender.Click += new System.EventHandler(this.rbtnVender_Click);
            // 
            // rbtnAgregarPedido
            // 
            this.rbtnAgregarPedido.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarPedido.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarPedido.Location = new System.Drawing.Point(187, 55);
            this.rbtnAgregarPedido.Name = "rbtnAgregarPedido";
            this.rbtnAgregarPedido.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarPedido.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarPedido.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarPedido.Size = new System.Drawing.Size(151, 39);
            this.rbtnAgregarPedido.TabIndex = 67;
            this.rbtnAgregarPedido.Text = "Agregar pedido";
            this.rbtnAgregarPedido.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarPedido.UseVisualStyleBackColor = true;
            this.rbtnAgregarPedido.Click += new System.EventHandler(this.rbtnAgregarPedido_Click);
            // 
            // rbtnAgregarModelo
            // 
            this.rbtnAgregarModelo.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarModelo.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarModelo.Location = new System.Drawing.Point(30, 55);
            this.rbtnAgregarModelo.Name = "rbtnAgregarModelo";
            this.rbtnAgregarModelo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarModelo.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarModelo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarModelo.Size = new System.Drawing.Size(151, 39);
            this.rbtnAgregarModelo.TabIndex = 68;
            this.rbtnAgregarModelo.Text = "Agregar modelo";
            this.rbtnAgregarModelo.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarModelo.UseVisualStyleBackColor = true;
            this.rbtnAgregarModelo.Click += new System.EventHandler(this.rbtnAgregarModelo_Click);
            // 
            // rbtnAplicarDevolucion
            // 
            this.rbtnAplicarDevolucion.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAplicarDevolucion.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAplicarDevolucion.Location = new System.Drawing.Point(159, 10);
            this.rbtnAplicarDevolucion.Name = "rbtnAplicarDevolucion";
            this.rbtnAplicarDevolucion.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAplicarDevolucion.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAplicarDevolucion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAplicarDevolucion.Size = new System.Drawing.Size(179, 39);
            this.rbtnAplicarDevolucion.TabIndex = 73;
            this.rbtnAplicarDevolucion.Text = "Apl. Devolucion";
            this.rbtnAplicarDevolucion.TextColor = System.Drawing.Color.White;
            this.rbtnAplicarDevolucion.UseVisualStyleBackColor = true;
            this.rbtnAplicarDevolucion.Visible = false;
            this.rbtnAplicarDevolucion.Click += new System.EventHandler(this.rbtnAplicarDevolucion_Click);
            // 
            // UCBarraSuperior
            // 
            this.UCBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UCBarraSuperior.BackgroundImage")));
            this.UCBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.UCBarraSuperior.Name = "UCBarraSuperior";
            this.UCBarraSuperior.Size = new System.Drawing.Size(879, 48);
            this.UCBarraSuperior.TabIndex = 72;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(482, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(392, 26);
            this.tableLayoutPanel2.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Location = new System.Drawing.Point(283, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 20);
            this.panel3.TabIndex = 73;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 39;
            this.materialLabel2.Text = "Devolución";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbLeyenda1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 20);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lbLeyenda1
            // 
            this.lbLeyenda1.AutoSize = true;
            this.lbLeyenda1.Depth = 0;
            this.lbLeyenda1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLeyenda1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbLeyenda1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLeyenda1.Location = new System.Drawing.Point(20, 0);
            this.lbLeyenda1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbLeyenda1.Name = "lbLeyenda1";
            this.lbLeyenda1.Size = new System.Drawing.Size(124, 19);
            this.lbLeyenda1.TabIndex = 39;
            this.lbLeyenda1.Text = "No Seleccionado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(153, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 20);
            this.panel2.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Seleccionado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnAplicarDevolucion);
            this.groupBox3.Controls.Add(this.rbtnSelTodo);
            this.groupBox3.Controls.Add(this.rbtnVender);
            this.groupBox3.Controls.Add(this.rbtnAgregarPedido);
            this.groupBox3.Controls.Add(this.rbtnAgregarModelo);
            this.groupBox3.Location = new System.Drawing.Point(387, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 100);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            // 
            // Venta
            // 
            this.AcceptButton = this.rbtnVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(879, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.UCBarraSuperior);
            this.Controls.Add(this.txtFolioVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvVentasPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Activated += new System.EventHandler(this.Venta_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasPedido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVentasPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolioVenta;
        private RoundButton.RoundButton rbtnSelTodo;
        private RoundButton.RoundButton rbtnVender;
        private RoundButton.RoundButton rbtnAgregarPedido;
        private RoundButton.RoundButton rbtnAgregarModelo;
        private Componentes.UCBarraSuperior UCBarraSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private RoundButton.RoundButton rbtnAplicarDevolucion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbLeyenda1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Componentes.UCcomboBoxCliente UCComboBox;
    }
}