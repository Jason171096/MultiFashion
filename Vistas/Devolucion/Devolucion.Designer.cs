
namespace MultimodeSales.Vistas
{
    partial class Devolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDFolio = new System.Windows.Forms.TextBox();
            this.mtDivider = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UCcomboBox = new MultimodeSales.Componentes.UCcomboBoxCliente();
            this.rbtnBuscarFolio = new RoundButton.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.checkCambioModelo = new MaterialSkin.Controls.MaterialCheckBox();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gBoxCambiar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalDevolucion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnSelPedido = new RoundButton.RoundButton();
            this.gBoxCambio = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalDevolucion2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnSelModelo = new RoundButton.RoundButton();
            this.dgvDevolucion2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rbtnAceptar = new RoundButton.RoundButton();
            this.rbtnCancelar = new RoundButton.RoundButton();
            this.UCBarraSuperior = new MultimodeSales.Componentes.UCBarraSuperior();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolioVenta = new System.Windows.Forms.TextBox();
            this.checkBuscarFolio = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            this.gBoxCambiar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gBoxCambio.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(544, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Folio:";
            // 
            // txtIDFolio
            // 
            this.txtIDFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDFolio.Location = new System.Drawing.Point(607, 25);
            this.txtIDFolio.Name = "txtIDFolio";
            this.txtIDFolio.Size = new System.Drawing.Size(190, 29);
            this.txtIDFolio.TabIndex = 20;
            // 
            // mtDivider
            // 
            this.mtDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtDivider.Depth = 0;
            this.mtDivider.Location = new System.Drawing.Point(17, 407);
            this.mtDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtDivider.Name = "mtDivider";
            this.mtDivider.Size = new System.Drawing.Size(850, 10);
            this.mtDivider.TabIndex = 25;
            this.mtDivider.Text = "materialDivider1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBuscarFolio);
            this.groupBox2.Controls.Add(this.txtFolioVenta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.UCcomboBox);
            this.groupBox2.Controls.Add(this.rbtnBuscarFolio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIDFolio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkCambioModelo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 125);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // UCcomboBox
            // 
            this.UCcomboBox.Location = new System.Drawing.Point(88, 25);
            this.UCcomboBox.Margin = new System.Windows.Forms.Padding(6);
            this.UCcomboBox.Name = "UCcomboBox";
            this.UCcomboBox.Size = new System.Drawing.Size(433, 34);
            this.UCcomboBox.TabIndex = 42;
            // 
            // rbtnBuscarFolio
            // 
            this.rbtnBuscarFolio.BorderColor = System.Drawing.Color.Silver;
            this.rbtnBuscarFolio.ButtonColor = System.Drawing.Color.Red;
            this.rbtnBuscarFolio.Enabled = false;
            this.rbtnBuscarFolio.Location = new System.Drawing.Point(266, 74);
            this.rbtnBuscarFolio.Name = "rbtnBuscarFolio";
            this.rbtnBuscarFolio.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnBuscarFolio.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnBuscarFolio.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnBuscarFolio.Size = new System.Drawing.Size(148, 37);
            this.rbtnBuscarFolio.TabIndex = 65;
            this.rbtnBuscarFolio.Text = "Buscar Folio";
            this.rbtnBuscarFolio.TextColor = System.Drawing.Color.White;
            this.rbtnBuscarFolio.UseVisualStyleBackColor = true;
            this.rbtnBuscarFolio.Click += new System.EventHandler(this.rbtnBuscarFolio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cliente:";
            // 
            // checkCambioModelo
            // 
            this.checkCambioModelo.AutoSize = true;
            this.checkCambioModelo.Depth = 0;
            this.checkCambioModelo.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkCambioModelo.Location = new System.Drawing.Point(669, 86);
            this.checkCambioModelo.Margin = new System.Windows.Forms.Padding(0);
            this.checkCambioModelo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkCambioModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkCambioModelo.Name = "checkCambioModelo";
            this.checkCambioModelo.Ripple = true;
            this.checkCambioModelo.Size = new System.Drawing.Size(179, 30);
            this.checkCambioModelo.TabIndex = 62;
            this.checkCambioModelo.Text = "Cambio por otro modelo";
            this.checkCambioModelo.UseVisualStyleBackColor = true;
            this.checkCambioModelo.CheckedChanged += new System.EventHandler(this.checkCambioModelo_CheckedChanged);
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.AllowUserToAddRows = false;
            this.dgvDevolucion.AllowUserToDeleteRows = false;
            this.dgvDevolucion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDevolucion.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvDevolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvDevolucion.ColumnHeadersHeight = 50;
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.IDModelo,
            this.IDMarca,
            this.IDColor,
            this.IDTalla,
            this.Column1,
            this.Eliminar});
            this.dgvDevolucion.EnableHeadersVisualStyles = false;
            this.dgvDevolucion.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvDevolucion.Location = new System.Drawing.Point(8, 62);
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvDevolucion.RowHeadersVisible = false;
            this.dgvDevolucion.RowHeadersWidth = 30;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDevolucion.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvDevolucion.RowTemplate.Height = 30;
            this.dgvDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion.Size = new System.Drawing.Size(850, 150);
            this.dgvDevolucion.TabIndex = 63;
            this.dgvDevolucion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucion_CellClick);
            // 
            // IDPedido
            // 
            this.IDPedido.HeaderText = "Pedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            this.IDPedido.Visible = false;
            // 
            // IDModelo
            // 
            this.IDModelo.HeaderText = "Modelo";
            this.IDModelo.Name = "IDModelo";
            this.IDModelo.ReadOnly = true;
            this.IDModelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IDMarca
            // 
            this.IDMarca.HeaderText = "Marca";
            this.IDMarca.Name = "IDMarca";
            this.IDMarca.ReadOnly = true;
            // 
            // IDColor
            // 
            this.IDColor.HeaderText = "Color";
            this.IDColor.Name = "IDColor";
            this.IDColor.ReadOnly = true;
            this.IDColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IDTalla
            // 
            this.IDTalla.HeaderText = "Talla";
            this.IDTalla.Name = "IDTalla";
            this.IDTalla.ReadOnly = true;
            this.IDTalla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::MultimodeSales.Properties.Resources.basura24px;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gBoxCambiar
            // 
            this.gBoxCambiar.Controls.Add(this.tableLayoutPanel1);
            this.gBoxCambiar.Controls.Add(this.rbtnSelPedido);
            this.gBoxCambiar.Controls.Add(this.dgvDevolucion);
            this.gBoxCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gBoxCambiar.Location = new System.Drawing.Point(11, 180);
            this.gBoxCambiar.Name = "gBoxCambiar";
            this.gBoxCambiar.Size = new System.Drawing.Size(861, 221);
            this.gBoxCambiar.TabIndex = 65;
            this.gBoxCambiar.TabStop = false;
            this.gBoxCambiar.Text = "Modelos a cambiar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lbTotalDevolucion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(647, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 37);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // lbTotalDevolucion
            // 
            this.lbTotalDevolucion.AutoSize = true;
            this.lbTotalDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalDevolucion.Location = new System.Drawing.Point(75, 0);
            this.lbTotalDevolucion.Name = "lbTotalDevolucion";
            this.lbTotalDevolucion.Size = new System.Drawing.Size(130, 37);
            this.lbTotalDevolucion.TabIndex = 1;
            this.lbTotalDevolucion.Text = "$0.00";
            this.lbTotalDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnSelPedido
            // 
            this.rbtnSelPedido.BorderColor = System.Drawing.Color.Silver;
            this.rbtnSelPedido.ButtonColor = System.Drawing.Color.Red;
            this.rbtnSelPedido.Location = new System.Drawing.Point(307, 19);
            this.rbtnSelPedido.Name = "rbtnSelPedido";
            this.rbtnSelPedido.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnSelPedido.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnSelPedido.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnSelPedido.Size = new System.Drawing.Size(187, 37);
            this.rbtnSelPedido.TabIndex = 64;
            this.rbtnSelPedido.Text = "Seleccionar pedido";
            this.rbtnSelPedido.TextColor = System.Drawing.Color.White;
            this.rbtnSelPedido.UseVisualStyleBackColor = true;
            this.rbtnSelPedido.Click += new System.EventHandler(this.rbtnSelPedido_Click);
            // 
            // gBoxCambio
            // 
            this.gBoxCambio.Controls.Add(this.tableLayoutPanel2);
            this.gBoxCambio.Controls.Add(this.rbtnSelModelo);
            this.gBoxCambio.Controls.Add(this.dgvDevolucion2);
            this.gBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gBoxCambio.Location = new System.Drawing.Point(11, 423);
            this.gBoxCambio.Name = "gBoxCambio";
            this.gBoxCambio.Size = new System.Drawing.Size(861, 221);
            this.gBoxCambio.TabIndex = 66;
            this.gBoxCambio.TabStop = false;
            this.gBoxCambio.Text = "Modelos por cambio";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.lbTotalDevolucion2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(647, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(205, 37);
            this.tableLayoutPanel2.TabIndex = 66;
            // 
            // lbTotalDevolucion2
            // 
            this.lbTotalDevolucion2.AutoSize = true;
            this.lbTotalDevolucion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalDevolucion2.Location = new System.Drawing.Point(74, 0);
            this.lbTotalDevolucion2.Name = "lbTotalDevolucion2";
            this.lbTotalDevolucion2.Size = new System.Drawing.Size(128, 37);
            this.lbTotalDevolucion2.TabIndex = 1;
            this.lbTotalDevolucion2.Text = "$0.00";
            this.lbTotalDevolucion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnSelModelo
            // 
            this.rbtnSelModelo.BorderColor = System.Drawing.Color.Silver;
            this.rbtnSelModelo.ButtonColor = System.Drawing.Color.Red;
            this.rbtnSelModelo.Location = new System.Drawing.Point(307, 19);
            this.rbtnSelModelo.Name = "rbtnSelModelo";
            this.rbtnSelModelo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnSelModelo.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnSelModelo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnSelModelo.Size = new System.Drawing.Size(187, 37);
            this.rbtnSelModelo.TabIndex = 65;
            this.rbtnSelModelo.Text = "Seleccionar modelo";
            this.rbtnSelModelo.TextColor = System.Drawing.Color.White;
            this.rbtnSelModelo.UseVisualStyleBackColor = true;
            this.rbtnSelModelo.Click += new System.EventHandler(this.rbtnSelModelo_Click);
            // 
            // dgvDevolucion2
            // 
            this.dgvDevolucion2.AllowUserToAddRows = false;
            this.dgvDevolucion2.AllowUserToDeleteRows = false;
            this.dgvDevolucion2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDevolucion2.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvDevolucion2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvDevolucion2.ColumnHeadersHeight = 50;
            this.dgvDevolucion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevolucion2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.Column2,
            this.dataGridViewImageColumn1});
            this.dgvDevolucion2.EnableHeadersVisualStyles = false;
            this.dgvDevolucion2.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvDevolucion2.Location = new System.Drawing.Point(5, 62);
            this.dgvDevolucion2.Name = "dgvDevolucion2";
            this.dgvDevolucion2.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion2.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvDevolucion2.RowHeadersVisible = false;
            this.dgvDevolucion2.RowHeadersWidth = 30;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDevolucion2.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvDevolucion2.RowTemplate.Height = 30;
            this.dgvDevolucion2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion2.Size = new System.Drawing.Size(850, 150);
            this.dgvDevolucion2.TabIndex = 64;
            this.dgvDevolucion2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucion2_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Color";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.HeaderText = "Talla";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.ReadOnly = true;
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::MultimodeSales.Properties.Resources.basura24px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rbtnAceptar
            // 
            this.rbtnAceptar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAceptar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAceptar.Location = new System.Drawing.Point(732, 650);
            this.rbtnAceptar.Name = "rbtnAceptar";
            this.rbtnAceptar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAceptar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAceptar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAceptar.Size = new System.Drawing.Size(140, 40);
            this.rbtnAceptar.TabIndex = 67;
            this.rbtnAceptar.Text = "Aceptar";
            this.rbtnAceptar.TextColor = System.Drawing.Color.White;
            this.rbtnAceptar.UseVisualStyleBackColor = true;
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelar.Location = new System.Drawing.Point(11, 650);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.Size = new System.Drawing.Size(140, 40);
            this.rbtnCancelar.TabIndex = 68;
            this.rbtnCancelar.Text = "Cancelar(Esc)";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            // 
            // UCBarraSuperior
            // 
            this.UCBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UCBarraSuperior.BackgroundImage")));
            this.UCBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.UCBarraSuperior.Name = "UCBarraSuperior";
            this.UCBarraSuperior.Size = new System.Drawing.Size(880, 48);
            this.UCBarraSuperior.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Folio Venta:";
            // 
            // txtFolioVenta
            // 
            this.txtFolioVenta.Enabled = false;
            this.txtFolioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtFolioVenta.Location = new System.Drawing.Point(123, 89);
            this.txtFolioVenta.Name = "txtFolioVenta";
            this.txtFolioVenta.Size = new System.Drawing.Size(137, 29);
            this.txtFolioVenta.TabIndex = 67;
            // 
            // checkBuscarFolio
            // 
            this.checkBuscarFolio.AutoSize = true;
            this.checkBuscarFolio.Depth = 0;
            this.checkBuscarFolio.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBuscarFolio.Location = new System.Drawing.Point(14, 62);
            this.checkBuscarFolio.Margin = new System.Windows.Forms.Padding(0);
            this.checkBuscarFolio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBuscarFolio.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBuscarFolio.Name = "checkBuscarFolio";
            this.checkBuscarFolio.Ripple = true;
            this.checkBuscarFolio.Size = new System.Drawing.Size(106, 30);
            this.checkBuscarFolio.TabIndex = 68;
            this.checkBuscarFolio.Text = "Buscar Folio";
            this.checkBuscarFolio.UseVisualStyleBackColor = true;
            this.checkBuscarFolio.CheckedChanged += new System.EventHandler(this.checkBuscarFolio_CheckedChanged);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(880, 695);
            this.Controls.Add(this.UCBarraSuperior);
            this.Controls.Add(this.rbtnCancelar);
            this.Controls.Add(this.rbtnAceptar);
            this.Controls.Add(this.gBoxCambio);
            this.Controls.Add(this.gBoxCambiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mtDivider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.Activated += new System.EventHandler(this.Devolucion_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            this.gBoxCambiar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gBoxCambio.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDFolio;
        private MaterialSkin.Controls.MaterialDivider mtDivider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCheckBox checkCambioModelo;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private System.Windows.Forms.GroupBox gBoxCambiar;
        private System.Windows.Forms.GroupBox gBoxCambio;
        private System.Windows.Forms.DataGridView dgvDevolucion2;
        private RoundButton.RoundButton rbtnSelPedido;
        private RoundButton.RoundButton rbtnSelModelo;
        private RoundButton.RoundButton rbtnAceptar;
        private RoundButton.RoundButton rbtnCancelar;
        private RoundButton.RoundButton rbtnBuscarFolio;
        private Componentes.UCcomboBoxCliente UCcomboBox;
        private Componentes.UCBarraSuperior UCBarraSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTotalDevolucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbTotalDevolucion2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialCheckBox checkBuscarFolio;
        private System.Windows.Forms.TextBox txtFolioVenta;
        private System.Windows.Forms.Label label3;
    }
}