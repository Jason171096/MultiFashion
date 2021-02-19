
namespace MultimodeSales.Vistas.Folios
{
    partial class FolioVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolioVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uCcomboBoxCliente1 = new MultimodeSales.Componentes.UCcomboBoxCliente();
            this.ucBarraSuperior1 = new MultimodeSales.Componentes.UCBarraSuperior();
            this.ucListViewItem1 = new MultimodeSales.Componentes.UCListViewItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(504, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(287, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Num. Folio:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(358, 39);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(142, 29);
            this.dtpFechaFinal.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 32);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uCcomboBoxCliente1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // uCcomboBoxCliente1
            // 
            this.uCcomboBoxCliente1.Enabled = false;
            this.uCcomboBoxCliente1.Location = new System.Drawing.Point(29, 34);
            this.uCcomboBoxCliente1.Margin = new System.Windows.Forms.Padding(6);
            this.uCcomboBoxCliente1.Name = "uCcomboBoxCliente1";
            this.uCcomboBoxCliente1.Size = new System.Drawing.Size(401, 34);
            this.uCcomboBoxCliente1.TabIndex = 0;
            // 
            // ucBarraSuperior1
            // 
            this.ucBarraSuperior1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBarraSuperior1.BackgroundImage")));
            this.ucBarraSuperior1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBarraSuperior1.Location = new System.Drawing.Point(0, 0);
            this.ucBarraSuperior1.Name = "ucBarraSuperior1";
            this.ucBarraSuperior1.Size = new System.Drawing.Size(1030, 48);
            this.ucBarraSuperior1.TabIndex = 0;
            // 
            // ucListViewItem1
            // 
            this.ucListViewItem1.Location = new System.Drawing.Point(0, 187);
            this.ucListViewItem1.Name = "ucListViewItem1";
            this.ucListViewItem1.Size = new System.Drawing.Size(774, 275);
            this.ucListViewItem1.TabIndex = 3;
            // 
            // FolioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1030, 712);
            this.Controls.Add(this.ucListViewItem1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucBarraSuperior1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FolioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolioVenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.UCBarraSuperior ucBarraSuperior1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Componentes.UCcomboBoxCliente uCcomboBoxCliente1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private Componentes.UCListViewItem ucListViewItem1;
    }
}