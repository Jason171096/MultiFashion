
namespace MultiFashion.Vistas.Folios
{
    partial class TipoFolio
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
            this.rbtnFolioVentas = new RoundButton.RoundButton();
            this.rbtnFolioDevoluciones = new RoundButton.RoundButton();
            this.rbtnCancelar = new RoundButton.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFolioVentas
            // 
            this.rbtnFolioVentas.BorderColor = System.Drawing.Color.Silver;
            this.rbtnFolioVentas.ButtonColor = System.Drawing.Color.Red;
            this.rbtnFolioVentas.Location = new System.Drawing.Point(90, 30);
            this.rbtnFolioVentas.Name = "rbtnFolioVentas";
            this.rbtnFolioVentas.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnFolioVentas.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnFolioVentas.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnFolioVentas.Size = new System.Drawing.Size(200, 64);
            this.rbtnFolioVentas.TabIndex = 66;
            this.rbtnFolioVentas.Text = "Folio Ventas";
            this.rbtnFolioVentas.TextColor = System.Drawing.Color.White;
            this.rbtnFolioVentas.UseVisualStyleBackColor = true;
            this.rbtnFolioVentas.Click += new System.EventHandler(this.rbtnFolioVentas_Click);
            // 
            // rbtnFolioDevoluciones
            // 
            this.rbtnFolioDevoluciones.BorderColor = System.Drawing.Color.Silver;
            this.rbtnFolioDevoluciones.ButtonColor = System.Drawing.Color.Red;
            this.rbtnFolioDevoluciones.Location = new System.Drawing.Point(90, 126);
            this.rbtnFolioDevoluciones.Name = "rbtnFolioDevoluciones";
            this.rbtnFolioDevoluciones.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnFolioDevoluciones.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnFolioDevoluciones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnFolioDevoluciones.Size = new System.Drawing.Size(200, 64);
            this.rbtnFolioDevoluciones.TabIndex = 67;
            this.rbtnFolioDevoluciones.Text = "Folio Devoluciones";
            this.rbtnFolioDevoluciones.TextColor = System.Drawing.Color.White;
            this.rbtnFolioDevoluciones.UseVisualStyleBackColor = true;
            this.rbtnFolioDevoluciones.Click += new System.EventHandler(this.rbtnFolioDevoluciones_Click);
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rbtnCancelar.Location = new System.Drawing.Point(12, 223);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.Size = new System.Drawing.Size(146, 41);
            this.rbtnCancelar.TabIndex = 68;
            this.rbtnCancelar.Text = "Cancelar(Esc)";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MultiFashion.Properties.Resources.invoices64px;
            this.pictureBox1.Location = new System.Drawing.Point(20, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MultiFashion.Properties.Resources.invoices64px;
            this.pictureBox2.Location = new System.Drawing.Point(20, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // TipoFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::MultiFashion.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.rbtnCancelar;
            this.ClientSize = new System.Drawing.Size(307, 290);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnCancelar);
            this.Controls.Add(this.rbtnFolioDevoluciones);
            this.Controls.Add(this.rbtnFolioVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoFolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoFolio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton.RoundButton rbtnFolioVentas;
        private RoundButton.RoundButton rbtnFolioDevoluciones;
        private RoundButton.RoundButton rbtnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}