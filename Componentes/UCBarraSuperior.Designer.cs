
namespace MultiFashion.Componentes
{
    partial class UCBarraSuperior
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Controls.Add(this.picMinimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(627, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 48);
            this.panel2.TabIndex = 42;
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::MultiFashion.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(45, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 26;
            this.picClose.TabStop = false;
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.picMinimize.Image = global::MultiFashion.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(0, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 25;
            this.picMinimize.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(71, 48);
            this.panelTitle.TabIndex = 43;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(3, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(50, 29);
            this.lbTitle.TabIndex = 40;
            this.lbTitle.Text = "text";
            // 
            // UCBarraSuperior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFashion.Properties.Resources.background5;
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel2);
            this.Name = "UCBarraSuperior";
            this.Size = new System.Drawing.Size(720, 48);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox picClose;
        public System.Windows.Forms.PictureBox picMinimize;
        public System.Windows.Forms.Label lbTitle;
        public System.Windows.Forms.Panel panelTitle;
    }
}
