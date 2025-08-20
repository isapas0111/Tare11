namespace clicks
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
            this.btClick = new System.Windows.Forms.Button();
            this.ctNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btClick
            // 
            this.btClick.BackColor = System.Drawing.SystemColors.Info;
            this.btClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClick.Location = new System.Drawing.Point(113, 19);
            this.btClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(172, 44);
            this.btClick.TabIndex = 0;
            this.btClick.Text = "Click";
            this.btClick.UseVisualStyleBackColor = false;
            this.btClick.Click += new System.EventHandler(this.btClick_Click);
            // 
            // ctNumero
            // 
            this.ctNumero.AutoSize = true;
            this.ctNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNumero.Location = new System.Drawing.Point(184, 84);
            this.ctNumero.Name = "ctNumero";
            this.ctNumero.Size = new System.Drawing.Size(41, 29);
            this.ctNumero.TabIndex = 1;
            this.ctNumero.Text = "N*";
            this.ctNumero.Click += new System.EventHandler(this.ctNumero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 192);
            this.Controls.Add(this.ctNumero);
            this.Controls.Add(this.btClick);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClick;
        private System.Windows.Forms.Label ctNumero;
    }
}

