
namespace MultiFashion.Componentes
{
    partial class UCListViewItem
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTalla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecioCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackgroundImage = global::MultiFashion.Properties.Resources.background5;
            this.listView.BackgroundImageTiled = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPedido,
            this.columnModelo,
            this.columnMarca,
            this.columnColor,
            this.columnTalla,
            this.columnPrecioCliente});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listView.ForeColor = System.Drawing.SystemColors.Window;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(745, 205);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnPedido
            // 
            this.columnPedido.Text = "Pedido";
            this.columnPedido.Width = 0;
            // 
            // columnModelo
            // 
            this.columnModelo.Text = "Modelo";
            this.columnModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnModelo.Width = 150;
            // 
            // columnMarca
            // 
            this.columnMarca.Text = "Marca";
            this.columnMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMarca.Width = 150;
            // 
            // columnColor
            // 
            this.columnColor.Text = "Color";
            this.columnColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnColor.Width = 120;
            // 
            // columnTalla
            // 
            this.columnTalla.Text = "Talla";
            this.columnTalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTalla.Width = 120;
            // 
            // columnPrecioCliente
            // 
            this.columnPrecioCliente.Text = "Precio Cliente";
            this.columnPrecioCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrecioCliente.Width = 200;
            // 
            // UCListViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "UCListViewItem";
            this.Size = new System.Drawing.Size(745, 205);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnPedido;
        private System.Windows.Forms.ColumnHeader columnModelo;
        private System.Windows.Forms.ColumnHeader columnMarca;
        private System.Windows.Forms.ColumnHeader columnColor;
        private System.Windows.Forms.ColumnHeader columnTalla;
        private System.Windows.Forms.ColumnHeader columnPrecioCliente;
        public System.Windows.Forms.ListView listView;
    }
}
