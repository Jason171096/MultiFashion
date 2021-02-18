
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
            this.ucBarraSuperior1 = new MultimodeSales.Componentes.UCBarraSuperior();
            this.SuspendLayout();
            // 
            // ucBarraSuperior1
            // 
            this.ucBarraSuperior1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBarraSuperior1.BackgroundImage")));
            this.ucBarraSuperior1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBarraSuperior1.Location = new System.Drawing.Point(0, 0);
            this.ucBarraSuperior1.Name = "ucBarraSuperior1";
            this.ucBarraSuperior1.Size = new System.Drawing.Size(822, 48);
            this.ucBarraSuperior1.TabIndex = 0;
            // 
            // FolioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(822, 583);
            this.Controls.Add(this.ucBarraSuperior1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FolioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolioVenta";
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.UCBarraSuperior ucBarraSuperior1;
    }
}