namespace MultimodeSales.Vistas
{
    partial class Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDTalla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAgregarColorTalla = new RoundButton.RoundButton();
            this.rbtnAgregarModelo = new RoundButton.RoundButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UCcboxCliente = new MultimodeSales.Componentes.UCcomboBoxCliente();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbPedido = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.rbtnCancelar = new RoundButton.RoundButton();
            this.rbtnFinalizarPedido = new RoundButton.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedido.ColumnHeadersHeight = 50;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.IDModelo,
            this.IDMarca,
            this.IDColor,
            this.IDTalla,
            this.Eliminar});
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvPedido.Location = new System.Drawing.Point(12, 164);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedido.RowTemplate.Height = 30;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPedido.Size = new System.Drawing.Size(1028, 431);
            this.dgvPedido.TabIndex = 32;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            this.dgvPedido.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellValueChanged);
            this.dgvPedido.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPedido_RowsAdded);
            // 
            // IDPedido
            // 
            this.IDPedido.HeaderText = "Pedido";
            this.IDPedido.Name = "IDPedido";
            // 
            // IDModelo
            // 
            this.IDModelo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IDModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDModelo.HeaderText = "Modelo";
            this.IDModelo.Name = "IDModelo";
            this.IDModelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDModelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IDMarca
            // 
            this.IDMarca.HeaderText = "Marca";
            this.IDMarca.Name = "IDMarca";
            // 
            // IDColor
            // 
            this.IDColor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IDColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDColor.HeaderText = "Color";
            this.IDColor.Name = "IDColor";
            this.IDColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IDTalla
            // 
            this.IDTalla.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IDTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDTalla.HeaderText = "Talla";
            this.IDTalla.Name = "IDTalla";
            this.IDTalla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDTalla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::MultimodeSales.Properties.Resources.basura24px;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(22, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAgregarColorTalla);
            this.groupBox1.Controls.Add(this.rbtnAgregarModelo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(663, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 103);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // rbtnAgregarColorTalla
            // 
            this.rbtnAgregarColorTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarColorTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarColorTalla.Location = new System.Drawing.Point(191, 37);
            this.rbtnAgregarColorTalla.Name = "rbtnAgregarColorTalla";
            this.rbtnAgregarColorTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarColorTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarColorTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarColorTalla.Size = new System.Drawing.Size(179, 60);
            this.rbtnAgregarColorTalla.TabIndex = 36;
            this.rbtnAgregarColorTalla.Text = "Agregar Color \r\no Talla";
            this.rbtnAgregarColorTalla.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarColorTalla.UseVisualStyleBackColor = true;
            this.rbtnAgregarColorTalla.Click += new System.EventHandler(this.rbtnAgTaCo_Click);
            // 
            // rbtnAgregarModelo
            // 
            this.rbtnAgregarModelo.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarModelo.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarModelo.Location = new System.Drawing.Point(25, 37);
            this.rbtnAgregarModelo.Name = "rbtnAgregarModelo";
            this.rbtnAgregarModelo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarModelo.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarModelo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarModelo.Size = new System.Drawing.Size(160, 60);
            this.rbtnAgregarModelo.TabIndex = 35;
            this.rbtnAgregarModelo.Text = "Agregar Modelo";
            this.rbtnAgregarModelo.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarModelo.UseVisualStyleBackColor = true;
            this.rbtnAgregarModelo.Click += new System.EventHandler(this.rbtnAgregarModelo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UCcboxCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(11, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 103);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // UCcboxCliente
            // 
            this.UCcboxCliente.Location = new System.Drawing.Point(98, 46);
            this.UCcboxCliente.Margin = new System.Windows.Forms.Padding(6);
            this.UCcboxCliente.Name = "UCcboxCliente";
            this.UCcboxCliente.Size = new System.Drawing.Size(539, 34);
            this.UCcboxCliente.TabIndex = 56;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::MultimodeSales.Properties.Resources.basura24px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Purple;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbPedido);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(1052, 46);
            this.panelBarras.TabIndex = 31;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbPedido
            // 
            this.lbPedido.AutoSize = true;
            this.lbPedido.BackColor = System.Drawing.Color.Transparent;
            this.lbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPedido.Location = new System.Drawing.Point(6, 9);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(91, 29);
            this.lbPedido.TabIndex = 36;
            this.lbPedido.Text = "Pedido";
            this.lbPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbPedido_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(991, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(941, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelar.Location = new System.Drawing.Point(11, 601);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.Size = new System.Drawing.Size(162, 45);
            this.rbtnCancelar.TabIndex = 56;
            this.rbtnCancelar.Text = "Cancelar(Esc)";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // rbtnFinalizarPedido
            // 
            this.rbtnFinalizarPedido.BorderColor = System.Drawing.Color.Silver;
            this.rbtnFinalizarPedido.ButtonColor = System.Drawing.Color.Red;
            this.rbtnFinalizarPedido.Location = new System.Drawing.Point(845, 601);
            this.rbtnFinalizarPedido.Name = "rbtnFinalizarPedido";
            this.rbtnFinalizarPedido.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnFinalizarPedido.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnFinalizarPedido.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnFinalizarPedido.Size = new System.Drawing.Size(195, 45);
            this.rbtnFinalizarPedido.TabIndex = 57;
            this.rbtnFinalizarPedido.Text = "Finalizar Pedido";
            this.rbtnFinalizarPedido.TextColor = System.Drawing.Color.White;
            this.rbtnFinalizarPedido.UseVisualStyleBackColor = true;
            this.rbtnFinalizarPedido.Click += new System.EventHandler(this.rbtnFinalizarPedido_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1052, 658);
            this.Controls.Add(this.rbtnFinalizarPedido);
            this.Controls.Add(this.rbtnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.panelBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbPedido;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMarca;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDColor;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDTalla;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private RoundButton.RoundButton rbtnAgregarModelo;
        private RoundButton.RoundButton rbtnAgregarColorTalla;
        private RoundButton.RoundButton rbtnCancelar;
        private RoundButton.RoundButton rbtnFinalizarPedido;
        private Componentes.UCcomboBoxCliente uCcomboBoxCliente;
        private Componentes.UCcomboBoxCliente UCcboxCliente;
    }
}