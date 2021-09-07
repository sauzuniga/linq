
namespace practica
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArreglo = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnArreglo
            // 
            this.btnArreglo.Location = new System.Drawing.Point(61, 109);
            this.btnArreglo.Name = "btnArreglo";
            this.btnArreglo.Size = new System.Drawing.Size(106, 60);
            this.btnArreglo.TabIndex = 0;
            this.btnArreglo.Text = "Llenar arreglo";
            this.btnArreglo.UseVisualStyleBackColor = true;
            this.btnArreglo.Click += new System.EventHandler(this.btnArreglo_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(295, 40);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(276, 186);
            this.lstData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArreglo;
        private System.Windows.Forms.ListBox lstData;
    }
}

