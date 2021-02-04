namespace MultimodeSales.Vistas
{
    partial class TallasyColores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TallasyColores));
            this.dgvTallas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEliminarTalla = new RoundButton.RoundButton();
            this.rbtnCancelarTalla = new RoundButton.RoundButton();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.rbtnEditarTalla = new RoundButton.RoundButton();
            this.rbtnAgregarTalla = new RoundButton.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnEliminarColor = new RoundButton.RoundButton();
            this.rbtnCancelarColor = new RoundButton.RoundButton();
            this.rbtnEditarColor = new RoundButton.RoundButton();
            this.rbtnAgregarColor = new RoundButton.RoundButton();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvColores = new System.Windows.Forms.DataGridView();
            this.UCBarraSuperior = new MultimodeSales.Componentes.UCBarraSuperior();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTallas
            // 
            this.dgvTallas.AllowUserToAddRows = false;
            this.dgvTallas.AllowUserToDeleteRows = false;
            this.dgvTallas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTallas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTallas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvTallas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTallas.ColumnHeadersHeight = 50;
            this.dgvTallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTallas.EnableHeadersVisualStyles = false;
            this.dgvTallas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvTallas.Location = new System.Drawing.Point(358, 22);
            this.dgvTallas.Name = "dgvTallas";
            this.dgvTallas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTallas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTallas.RowHeadersVisible = false;
            this.dgvTallas.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvTallas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTallas.RowTemplate.Height = 30;
            this.dgvTallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTallas.Size = new System.Drawing.Size(362, 211);
            this.dgvTallas.TabIndex = 34;
            this.dgvTallas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTallas_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEliminarTalla);
            this.groupBox1.Controls.Add(this.rbtnCancelarTalla);
            this.groupBox1.Controls.Add(this.txtTalla);
            this.groupBox1.Controls.Add(this.rbtnEditarTalla);
            this.groupBox1.Controls.Add(this.rbtnAgregarTalla);
            this.groupBox1.Controls.Add(this.dgvTallas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(11, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 239);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tallas";
            // 
            // rbtnEliminarTalla
            // 
            this.rbtnEliminarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEliminarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEliminarTalla.Location = new System.Drawing.Point(20, 156);
            this.rbtnEliminarTalla.Name = "rbtnEliminarTalla";
            this.rbtnEliminarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEliminarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEliminarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEliminarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnEliminarTalla.TabIndex = 51;
            this.rbtnEliminarTalla.Text = "Eliminar";
            this.rbtnEliminarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnEliminarTalla.UseVisualStyleBackColor = true;
            this.rbtnEliminarTalla.Click += new System.EventHandler(this.rbtnEliminarTalla_Click);
            // 
            // rbtnCancelarTalla
            // 
            this.rbtnCancelarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelarTalla.Location = new System.Drawing.Point(186, 156);
            this.rbtnCancelarTalla.Name = "rbtnCancelarTalla";
            this.rbtnCancelarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnCancelarTalla.TabIndex = 50;
            this.rbtnCancelarTalla.Text = "Cancelar";
            this.rbtnCancelarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnCancelarTalla.UseVisualStyleBackColor = true;
            this.rbtnCancelarTalla.Visible = false;
            this.rbtnCancelarTalla.Click += new System.EventHandler(this.rbtnCancelarTalla_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTalla.Location = new System.Drawing.Point(114, 56);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(216, 29);
            this.txtTalla.TabIndex = 42;
            // 
            // rbtnEditarTalla
            // 
            this.rbtnEditarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEditarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEditarTalla.Enabled = false;
            this.rbtnEditarTalla.Location = new System.Drawing.Point(186, 113);
            this.rbtnEditarTalla.Name = "rbtnEditarTalla";
            this.rbtnEditarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEditarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEditarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEditarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnEditarTalla.TabIndex = 49;
            this.rbtnEditarTalla.Text = "Editar";
            this.rbtnEditarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnEditarTalla.UseVisualStyleBackColor = true;
            this.rbtnEditarTalla.Click += new System.EventHandler(this.rbtnEditarTalla_Click);
            // 
            // rbtnAgregarTalla
            // 
            this.rbtnAgregarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarTalla.Location = new System.Drawing.Point(22, 113);
            this.rbtnAgregarTalla.Name = "rbtnAgregarTalla";
            this.rbtnAgregarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnAgregarTalla.TabIndex = 48;
            this.rbtnAgregarTalla.Text = "Agregar";
            this.rbtnAgregarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarTalla.UseVisualStyleBackColor = true;
            this.rbtnAgregarTalla.Click += new System.EventHandler(this.rbtnAgregarTalla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Número:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnEliminarColor);
            this.groupBox2.Controls.Add(this.rbtnCancelarColor);
            this.groupBox2.Controls.Add(this.rbtnEditarColor);
            this.groupBox2.Controls.Add(this.rbtnAgregarColor);
            this.groupBox2.Controls.Add(this.txtColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvColores);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(11, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 305);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // rbtnEliminarColor
            // 
            this.rbtnEliminarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEliminarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEliminarColor.Location = new System.Drawing.Point(28, 173);
            this.rbtnEliminarColor.Name = "rbtnEliminarColor";
            this.rbtnEliminarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEliminarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEliminarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEliminarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnEliminarColor.TabIndex = 47;
            this.rbtnEliminarColor.Text = "Eliminar";
            this.rbtnEliminarColor.TextColor = System.Drawing.Color.White;
            this.rbtnEliminarColor.UseVisualStyleBackColor = true;
            this.rbtnEliminarColor.Click += new System.EventHandler(this.rbtnEliminarColor_Click);
            // 
            // rbtnCancelarColor
            // 
            this.rbtnCancelarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelarColor.Location = new System.Drawing.Point(195, 173);
            this.rbtnCancelarColor.Name = "rbtnCancelarColor";
            this.rbtnCancelarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnCancelarColor.TabIndex = 46;
            this.rbtnCancelarColor.Text = "Cancelar";
            this.rbtnCancelarColor.TextColor = System.Drawing.Color.White;
            this.rbtnCancelarColor.UseVisualStyleBackColor = true;
            this.rbtnCancelarColor.Visible = false;
            this.rbtnCancelarColor.Click += new System.EventHandler(this.rbtnCancelarColor_Click);
            // 
            // rbtnEditarColor
            // 
            this.rbtnEditarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEditarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEditarColor.Enabled = false;
            this.rbtnEditarColor.Location = new System.Drawing.Point(195, 130);
            this.rbtnEditarColor.Name = "rbtnEditarColor";
            this.rbtnEditarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEditarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEditarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEditarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnEditarColor.TabIndex = 45;
            this.rbtnEditarColor.Text = "Editar";
            this.rbtnEditarColor.TextColor = System.Drawing.Color.White;
            this.rbtnEditarColor.UseVisualStyleBackColor = true;
            this.rbtnEditarColor.Click += new System.EventHandler(this.rbtnEditarColor_Click);
            // 
            // rbtnAgregarColor
            // 
            this.rbtnAgregarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarColor.Location = new System.Drawing.Point(29, 130);
            this.rbtnAgregarColor.Name = "rbtnAgregarColor";
            this.rbtnAgregarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnAgregarColor.TabIndex = 44;
            this.rbtnAgregarColor.Text = "Agregar";
            this.rbtnAgregarColor.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarColor.UseVisualStyleBackColor = true;
            this.rbtnAgregarColor.Click += new System.EventHandler(this.rbtnAgregarColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtColor.Location = new System.Drawing.Point(115, 54);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(216, 29);
            this.txtColor.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre:";
            // 
            // dgvColores
            // 
            this.dgvColores.AllowUserToAddRows = false;
            this.dgvColores.AllowUserToDeleteRows = false;
            this.dgvColores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColores.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvColores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColores.ColumnHeadersHeight = 50;
            this.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvColores.EnableHeadersVisualStyles = false;
            this.dgvColores.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvColores.Location = new System.Drawing.Point(359, 22);
            this.dgvColores.Name = "dgvColores";
            this.dgvColores.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColores.RowHeadersVisible = false;
            this.dgvColores.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvColores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColores.RowTemplate.Height = 30;
            this.dgvColores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColores.Size = new System.Drawing.Size(361, 277);
            this.dgvColores.TabIndex = 34;
            this.dgvColores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColores_CellDoubleClick);
            // 
            // UCBarraSuperior
            // 
            this.UCBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UCBarraSuperior.BackgroundImage")));
            this.UCBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.UCBarraSuperior.Name = "UCBarraSuperior";
            this.UCBarraSuperior.Size = new System.Drawing.Size(749, 48);
            this.UCBarraSuperior.TabIndex = 37;
            // 
            // TallasyColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(749, 619);
            this.Controls.Add(this.UCBarraSuperior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TallasyColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TallasyColores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTallas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvColores;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private RoundButton.RoundButton rbtnAgregarColor;
        private RoundButton.RoundButton rbtnEliminarColor;
        private RoundButton.RoundButton rbtnCancelarColor;
        private RoundButton.RoundButton rbtnEditarColor;
        private RoundButton.RoundButton rbtnEliminarTalla;
        private RoundButton.RoundButton rbtnCancelarTalla;
        private RoundButton.RoundButton rbtnEditarTalla;
        private RoundButton.RoundButton rbtnAgregarTalla;
        private Componentes.UCBarraSuperior UCBarraSuperior;
    }
}