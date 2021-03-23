
namespace MultimodeSales.Vistas.Ventas
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.roundButton1 = new RoundButton.RoundButton();
            this.UCBarraSuperior = new MultimodeSales.Componentes.UCBarraSuperior();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BorderColor = System.Drawing.Color.YellowGreen;
            this.roundButton1.ButtonColor = System.Drawing.Color.ForestGreen;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Image = global::MultimodeSales.Properties.Resources.excel24;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundButton1.Location = new System.Drawing.Point(522, 443);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Green;
            this.roundButton1.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton1.Size = new System.Drawing.Size(448, 92);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton1.UseMnemonic = false;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // UCBarraSuperior
            // 
            this.UCBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UCBarraSuperior.BackgroundImage")));
            this.UCBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.UCBarraSuperior.Name = "UCBarraSuperior";
            this.UCBarraSuperior.Size = new System.Drawing.Size(1016, 48);
            this.UCBarraSuperior.TabIndex = 2;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1016, 571);
            this.Controls.Add(this.UCBarraSuperior);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton.RoundButton roundButton1;
        private Componentes.UCBarraSuperior UCBarraSuperior;
    }
}