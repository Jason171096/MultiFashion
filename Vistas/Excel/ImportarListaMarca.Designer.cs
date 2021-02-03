namespace MultimodeSales.Vistas
{
    partial class ImportarListaMarca
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
            this.cobxMarca = new System.Windows.Forms.ComboBox();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.lbListaMarcas = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCargar = new RoundButton.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnImportar = new RoundButton.RoundButton();
            this.rbtnCancelar = new RoundButton.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cobxMarca
            // 
            this.cobxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cobxMarca.FormattingEnabled = true;
            this.cobxMarca.Location = new System.Drawing.Point(100, 33);
            this.cobxMarca.Name = "cobxMarca";
            this.cobxMarca.Size = new System.Drawing.Size(206, 32);
            this.cobxMarca.TabIndex = 2;
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.AllowUserToDeleteRows = false;
            this.dgvExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExcel.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExcel.ColumnHeadersHeight = 50;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExcel.EnableHeadersVisualStyles = false;
            this.dgvExcel.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvExcel.Location = new System.Drawing.Point(12, 151);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExcel.RowHeadersVisible = false;
            this.dgvExcel.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvExcel.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExcel.RowTemplate.Height = 30;
            this.dgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel.Size = new System.Drawing.Size(825, 414);
            this.dgvExcel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marca:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(64, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "Importa la \r\nlista al Sistema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.Transparent;
            this.panelBarra.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarra.Controls.Add(this.lbListaMarcas);
            this.panelBarra.Controls.Add(this.picClose);
            this.panelBarra.Controls.Add(this.picMinimize);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(848, 49);
            this.panelBarra.TabIndex = 26;
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            // 
            // lbListaMarcas
            // 
            this.lbListaMarcas.AutoSize = true;
            this.lbListaMarcas.BackColor = System.Drawing.Color.Transparent;
            this.lbListaMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaMarcas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbListaMarcas.Location = new System.Drawing.Point(12, 9);
            this.lbListaMarcas.Name = "lbListaMarcas";
            this.lbListaMarcas.Size = new System.Drawing.Size(181, 29);
            this.lbListaMarcas.TabIndex = 38;
            this.lbListaMarcas.Text = "Lista de Marcas";
            this.lbListaMarcas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbClientes_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(791, 1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 22;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(741, 1);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 21;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobxMarca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 90);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCargar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(472, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 90);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // rbtnCargar
            // 
            this.rbtnCargar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCargar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCargar.Location = new System.Drawing.Point(167, 36);
            this.rbtnCargar.Name = "rbtnCargar";
            this.rbtnCargar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCargar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCargar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCargar.Size = new System.Drawing.Size(174, 34);
            this.rbtnCargar.TabIndex = 31;
            this.rbtnCargar.Text = "Cargar Lista";
            this.rbtnCargar.TextColor = System.Drawing.Color.White;
            this.rbtnCargar.UseVisualStyleBackColor = true;
            this.rbtnCargar.Click += new System.EventHandler(this.rbtnCargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(41, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 48);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cargar la \r\nLista CSV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnImportar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox3.Location = new System.Drawing.Point(431, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 91);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Importar";
            // 
            // rbtnImportar
            // 
            this.rbtnImportar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnImportar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnImportar.Location = new System.Drawing.Point(226, 29);
            this.rbtnImportar.Name = "rbtnImportar";
            this.rbtnImportar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnImportar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnImportar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnImportar.Size = new System.Drawing.Size(157, 41);
            this.rbtnImportar.TabIndex = 32;
            this.rbtnImportar.Text = "Importar";
            this.rbtnImportar.TextColor = System.Drawing.Color.White;
            this.rbtnImportar.UseVisualStyleBackColor = true;
            this.rbtnImportar.Click += new System.EventHandler(this.rbtnImportar_Click);
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelar.Location = new System.Drawing.Point(12, 621);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.Size = new System.Drawing.Size(205, 41);
            this.rbtnCancelar.TabIndex = 33;
            this.rbtnCancelar.Text = "Cancelar(Esc)";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // ImportarListaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(848, 674);
            this.Controls.Add(this.rbtnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.dgvExcel);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ImportarListaMarca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Lista Marca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cobxMarca;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label lbListaMarcas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private RoundButton.RoundButton rbtnCargar;
        private RoundButton.RoundButton rbtnImportar;
        private RoundButton.RoundButton rbtnCancelar;
    }
}