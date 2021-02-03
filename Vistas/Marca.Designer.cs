namespace MultimodeSales.Vistas
{
    partial class Marca
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCancelar = new RoundButton.RoundButton();
            this.rbtnEditarMarca = new RoundButton.RoundButton();
            this.rbtnAgregarMarca = new RoundButton.RoundButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbClientes = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMarcas.ColumnHeadersHeight = 50;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarcas.EnableHeadersVisualStyles = false;
            this.dgvMarcas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvMarcas.Location = new System.Drawing.Point(11, 294);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dgvMarcas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMarcas.RowTemplate.Height = 30;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(792, 269);
            this.dgvMarcas.TabIndex = 7;
            this.dgvMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNombreMarca.Location = new System.Drawing.Point(118, 85);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(268, 29);
            this.txtNombreMarca.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Marca:";
            // 
            // txtIDMarca
            // 
            this.txtIDMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDMarca.Location = new System.Drawing.Point(118, 41);
            this.txtIDMarca.Name = "txtIDMarca";
            this.txtIDMarca.Size = new System.Drawing.Size(268, 29);
            this.txtIDMarca.TabIndex = 8;
            this.txtIDMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroMarca_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(438, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 72);
            this.label3.TabIndex = 23;
            this.label3.Text = "Haga doble click \r\nen la Marca \r\nque quiera editar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCancelar);
            this.groupBox1.Controls.Add(this.rbtnEditarMarca);
            this.groupBox1.Controls.Add(this.rbtnAgregarMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIDMarca);
            this.groupBox1.Controls.Add(this.txtNombreMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(11, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 233);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Marca";
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelar.Location = new System.Drawing.Point(194, 181);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.Size = new System.Drawing.Size(166, 45);
            this.rbtnCancelar.TabIndex = 26;
            this.rbtnCancelar.Text = "Cancelar";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            this.rbtnCancelar.Visible = false;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // rbtnEditarMarca
            // 
            this.rbtnEditarMarca.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEditarMarca.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEditarMarca.Location = new System.Drawing.Point(194, 130);
            this.rbtnEditarMarca.Name = "rbtnEditarMarca";
            this.rbtnEditarMarca.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEditarMarca.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEditarMarca.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEditarMarca.Size = new System.Drawing.Size(166, 45);
            this.rbtnEditarMarca.TabIndex = 25;
            this.rbtnEditarMarca.Text = "Editar Marca";
            this.rbtnEditarMarca.TextColor = System.Drawing.Color.White;
            this.rbtnEditarMarca.UseVisualStyleBackColor = true;
            this.rbtnEditarMarca.Click += new System.EventHandler(this.rbtnEditarMarca_Click);
            // 
            // rbtnAgregarMarca
            // 
            this.rbtnAgregarMarca.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarMarca.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarMarca.Location = new System.Drawing.Point(20, 130);
            this.rbtnAgregarMarca.Name = "rbtnAgregarMarca";
            this.rbtnAgregarMarca.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarMarca.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarMarca.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarMarca.Size = new System.Drawing.Size(162, 45);
            this.rbtnAgregarMarca.TabIndex = 24;
            this.rbtnAgregarMarca.Text = "Agregar Marca";
            this.rbtnAgregarMarca.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarMarca.UseVisualStyleBackColor = true;
            this.rbtnAgregarMarca.Click += new System.EventHandler(this.rbtnAgregarMarca_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBuscar.Location = new System.Drawing.Point(507, 252);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(296, 29);
            this.txtBuscar.TabIndex = 36;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(422, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Buscar:";
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Transparent;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbClientes);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(815, 49);
            this.panelBarras.TabIndex = 18;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.BackColor = System.Drawing.Color.Transparent;
            this.lbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbClientes.Location = new System.Drawing.Point(6, 9);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(91, 29);
            this.lbClientes.TabIndex = 37;
            this.lbClientes.Text = "Marcas";
            this.lbClientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbClientes_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(759, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(709, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelBarras);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Marca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMarca;
        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbClientes;
        private RoundButton.RoundButton rbtnCancelar;
        private RoundButton.RoundButton rbtnEditarMarca;
        private RoundButton.RoundButton rbtnAgregarMarca;
    }
}