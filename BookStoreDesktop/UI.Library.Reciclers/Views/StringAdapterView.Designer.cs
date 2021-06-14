
namespace UI.Library.Reciclers.Views
{
    partial class StringAdapterView
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
            this.lbData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbData.Location = new System.Drawing.Point(0, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(35, 13);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "label1";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StringAdapterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbData);
            this.Name = "StringAdapterView";
            this.Size = new System.Drawing.Size(152, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbData;
    }
}
