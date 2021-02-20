
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UCListViewItem = new MultimodeSales.Componentes.UCListViewItem();
            this.uCcomboBoxCliente2 = new MultimodeSales.Componentes.UCcomboBoxCliente();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucBarraSuperior2 = new MultimodeSales.Componentes.UCBarraSuperior();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaInicial);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox3.Location = new System.Drawing.Point(446, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 79);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Folio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uCcomboBoxCliente2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox4.Location = new System.Drawing.Point(12, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 79);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Folio:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(69, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(175, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpFechaInicial.Enabled = false;
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(245, 38);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(137, 29);
            this.dtpFechaInicial.TabIndex = 43;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Controls.Add(this.UCListViewItem);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox5.Location = new System.Drawing.Point(6, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(828, 338);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Venta";
            // 
            // UCListViewItem
            // 
            this.UCListViewItem.ForeColor = System.Drawing.SystemColors.Control;
            this.UCListViewItem.Location = new System.Drawing.Point(6, 31);
            this.UCListViewItem.Name = "UCListViewItem";
            this.UCListViewItem.Size = new System.Drawing.Size(744, 237);
            this.UCListViewItem.TabIndex = 0;
            // 
            // uCcomboBoxCliente2
            // 
            this.uCcomboBoxCliente2.Location = new System.Drawing.Point(15, 31);
            this.uCcomboBoxCliente2.Name = "uCcomboBoxCliente2";
            this.uCcomboBoxCliente2.Size = new System.Drawing.Size(407, 34);
            this.uCcomboBoxCliente2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(756, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(64, 270);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ucBarraSuperior2
            // 
            this.ucBarraSuperior2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBarraSuperior2.BackgroundImage")));
            this.ucBarraSuperior2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBarraSuperior2.Location = new System.Drawing.Point(0, 0);
            this.ucBarraSuperior2.Name = "ucBarraSuperior2";
            this.ucBarraSuperior2.Size = new System.Drawing.Size(846, 48);
            this.ucBarraSuperior2.TabIndex = 0;
            // 
            // FolioVenta
            // 
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(846, 564);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ucBarraSuperior2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FolioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
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
        private Componentes.UCBarraSuperior ucBarraSuperior2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Componentes.UCcomboBoxCliente uCcomboBoxCliente2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.GroupBox groupBox5;
        private Componentes.UCListViewItem UCListViewItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}