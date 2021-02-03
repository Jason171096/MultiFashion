
namespace MultimodeSales.Componentes
{
    partial class UCcomboBoxCliente
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
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxCliente
            // 
            this.cboxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(0, 0);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(520, 32);
            this.cboxCliente.TabIndex = 54;
            // 
            // UCcomboBoxCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxCliente);
            this.Name = "UCcomboBoxCliente";
            this.Size = new System.Drawing.Size(520, 34);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cboxCliente;
    }
}
