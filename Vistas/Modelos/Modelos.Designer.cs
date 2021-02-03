namespace MultimodeSales.Vistas
{
    partial class Modeloss
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNumPedido = new System.Windows.Forms.RadioButton();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarModelo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnEditarModelo = new RoundButton.RoundButton();
            this.rbtnAgregarModelo = new RoundButton.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbModelos = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModelos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvModelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModelos.ColumnHeadersHeight = 50;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModelos.EnableHeadersVisualStyles = false;
            this.dgvModelos.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvModelos.Location = new System.Drawing.Point(12, 192);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModelos.RowHeadersVisible = false;
            this.dgvModelos.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvModelos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvModelos.RowTemplate.Height = 30;
            this.dgvModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelos.Size = new System.Drawing.Size(1002, 397);
            this.dgvModelos.TabIndex = 7;
            this.dgvModelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelos_CellDoubleClick);
            this.dgvModelos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvModelos_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNumPedido);
            this.groupBox1.Controls.Add(this.rbtnFecha);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtBuscarModelo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(9, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // rbtnNumPedido
            // 
            this.rbtnNumPedido.AutoSize = true;
            this.rbtnNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnNumPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnNumPedido.Location = new System.Drawing.Point(22, 39);
            this.rbtnNumPedido.Name = "rbtnNumPedido";
            this.rbtnNumPedido.Size = new System.Drawing.Size(97, 28);
            this.rbtnNumPedido.TabIndex = 10;
            this.rbtnNumPedido.TabStop = true;
            this.rbtnNumPedido.Text = "Modelo:";
            this.rbtnNumPedido.UseVisualStyleBackColor = true;
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnFecha.Location = new System.Drawing.Point(37, 86);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(87, 28);
            this.rbtnFecha.TabIndex = 12;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Fecha:";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(130, 87);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(142, 29);
            this.dtpFecha.TabIndex = 38;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // txtBuscarModelo
            // 
            this.txtBuscarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBuscarModelo.Location = new System.Drawing.Point(130, 39);
            this.txtBuscarModelo.Name = "txtBuscarModelo";
            this.txtBuscarModelo.Size = new System.Drawing.Size(268, 29);
            this.txtBuscarModelo.TabIndex = 37;
            this.txtBuscarModelo.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnEditarModelo);
            this.groupBox2.Controls.Add(this.rbtnAgregarModelo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(437, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 131);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar o Editar";
            // 
            // rbtnEditarModelo
            // 
            this.rbtnEditarModelo.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEditarModelo.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEditarModelo.Location = new System.Drawing.Point(331, 71);
            this.rbtnEditarModelo.Name = "rbtnEditarModelo";
            this.rbtnEditarModelo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEditarModelo.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEditarModelo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEditarModelo.Size = new System.Drawing.Size(175, 45);
            this.rbtnEditarModelo.TabIndex = 27;
            this.rbtnEditarModelo.Text = "Editar Modelo";
            this.rbtnEditarModelo.TextColor = System.Drawing.Color.White;
            this.rbtnEditarModelo.UseVisualStyleBackColor = true;
            this.rbtnEditarModelo.Click += new System.EventHandler(this.rbtnEditarModelo_Click);
            // 
            // rbtnAgregarModelo
            // 
            this.rbtnAgregarModelo.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarModelo.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarModelo.Location = new System.Drawing.Point(331, 23);
            this.rbtnAgregarModelo.Name = "rbtnAgregarModelo";
            this.rbtnAgregarModelo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarModelo.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarModelo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarModelo.Size = new System.Drawing.Size(175, 45);
            this.rbtnAgregarModelo.TabIndex = 26;
            this.rbtnAgregarModelo.Text = "Agregar Modelo";
            this.rbtnAgregarModelo.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarModelo.UseVisualStyleBackColor = true;
            this.rbtnAgregarModelo.Click += new System.EventHandler(this.rbtnAgregarModelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 72);
            this.label3.TabIndex = 25;
            this.label3.Text = "Seleccione el Modelo, \r\nluego de en el boton de\r\nEditar Modelo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Transparent;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbModelos);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(1026, 49);
            this.panelBarras.TabIndex = 26;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbModelos
            // 
            this.lbModelos.AutoSize = true;
            this.lbModelos.BackColor = System.Drawing.Color.Transparent;
            this.lbModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbModelos.Location = new System.Drawing.Point(6, 9);
            this.lbModelos.Name = "lbModelos";
            this.lbModelos.Size = new System.Drawing.Size(107, 29);
            this.lbModelos.TabIndex = 37;
            this.lbModelos.Text = "Modelos";
            this.lbModelos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbModelos_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(974, 0);
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
            this.picMinimize.Location = new System.Drawing.Point(924, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // Modeloss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1026, 601);
            this.Controls.Add(this.panelBarras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvModelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modeloss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarModelo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbModelos;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnNumPedido;
        private System.Windows.Forms.RadioButton rbtnFecha;
        private RoundButton.RoundButton rbtnEditarModelo;
        private RoundButton.RoundButton rbtnAgregarModelo;
    }
}