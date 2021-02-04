
namespace MultimodeSales.Vistas
{
    partial class Folio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Folio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtIDFolio = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.rbtnIDFolio = new System.Windows.Forms.RadioButton();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.dgvFolio = new System.Windows.Forms.DataGridView();
            this.UCBarraSuperior = new MultimodeSales.Componentes.UCBarraSuperior();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtIDFolio);
            this.groupBox1.Controls.Add(this.txtIDCliente);
            this.groupBox1.Controls.Add(this.rbtnIDFolio);
            this.groupBox1.Controls.Add(this.rbtnCliente);
            this.groupBox1.Controls.Add(this.rbtnFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(11, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 138);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(160, 99);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(166, 29);
            this.dtpFecha.TabIndex = 43;
            // 
            // txtIDFolio
            // 
            this.txtIDFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDFolio.Location = new System.Drawing.Point(160, 66);
            this.txtIDFolio.Name = "txtIDFolio";
            this.txtIDFolio.Size = new System.Drawing.Size(355, 29);
            this.txtIDFolio.TabIndex = 4;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDCliente.Location = new System.Drawing.Point(160, 31);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(355, 29);
            this.txtIDCliente.TabIndex = 3;
            // 
            // rbtnIDFolio
            // 
            this.rbtnIDFolio.AutoSize = true;
            this.rbtnIDFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnIDFolio.Location = new System.Drawing.Point(46, 65);
            this.rbtnIDFolio.Name = "rbtnIDFolio";
            this.rbtnIDFolio.Size = new System.Drawing.Size(97, 28);
            this.rbtnIDFolio.TabIndex = 1;
            this.rbtnIDFolio.TabStop = true;
            this.rbtnIDFolio.Text = "ID Folio:";
            this.rbtnIDFolio.UseVisualStyleBackColor = true;
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnCliente.Location = new System.Drawing.Point(46, 31);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(113, 28);
            this.rbtnCliente.TabIndex = 0;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "ID Cliente:";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnFecha.Location = new System.Drawing.Point(46, 99);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(87, 28);
            this.rbtnFecha.TabIndex = 2;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Fecha:";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            // 
            // dgvFolio
            // 
            this.dgvFolio.AllowUserToAddRows = false;
            this.dgvFolio.AllowUserToDeleteRows = false;
            this.dgvFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFolio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFolio.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvFolio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFolio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFolio.ColumnHeadersHeight = 50;
            this.dgvFolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFolio.EnableHeadersVisualStyles = false;
            this.dgvFolio.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvFolio.Location = new System.Drawing.Point(12, 196);
            this.dgvFolio.Name = "dgvFolio";
            this.dgvFolio.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFolio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFolio.RowHeadersVisible = false;
            this.dgvFolio.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvFolio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFolio.RowTemplate.Height = 30;
            this.dgvFolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFolio.Size = new System.Drawing.Size(592, 370);
            this.dgvFolio.TabIndex = 33;
            this.dgvFolio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFolio_CellDoubleClick);
            // 
            // UCBarraSuperior
            // 
            this.UCBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UCBarraSuperior.BackgroundImage")));
            this.UCBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.UCBarraSuperior.Name = "UCBarraSuperior";
            this.UCBarraSuperior.Size = new System.Drawing.Size(616, 48);
            this.UCBarraSuperior.TabIndex = 34;
            // 
            // Folio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(616, 578);
            this.Controls.Add(this.UCBarraSuperior);
            this.Controls.Add(this.dgvFolio);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Folio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFecha;
        private System.Windows.Forms.RadioButton rbtnIDFolio;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.TextBox txtIDFolio;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvFolio;
        private Componentes.UCBarraSuperior UCBarraSuperior;
    }
}