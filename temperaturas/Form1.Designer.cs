namespace temperaturas
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
            this.ctTitulo = new System.Windows.Forms.Label();
            this.btCAF = new System.Windows.Forms.Button();
            this.btFAC = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.Salida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctTitulo
            // 
            this.ctTitulo.AutoSize = true;
            this.ctTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTitulo.Location = new System.Drawing.Point(133, 22);
            this.ctTitulo.Name = "ctTitulo";
            this.ctTitulo.Size = new System.Drawing.Size(304, 22);
            this.ctTitulo.TabIndex = 0;
            this.ctTitulo.Text = "Que temperatura desea convertir";
            this.ctTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCAF
            // 
            this.btCAF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCAF.Location = new System.Drawing.Point(35, 59);
            this.btCAF.Name = "btCAF";
            this.btCAF.Size = new System.Drawing.Size(203, 34);
            this.btCAF.TabIndex = 1;
            this.btCAF.Text = "Celsius a fahrenheit";
            this.btCAF.UseVisualStyleBackColor = false;
            this.btCAF.Click += new System.EventHandler(this.btCAF_Click);
            // 
            // btFAC
            // 
            this.btFAC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btFAC.Location = new System.Drawing.Point(330, 59);
            this.btFAC.Name = "btFAC";
            this.btFAC.Size = new System.Drawing.Size(203, 34);
            this.btFAC.TabIndex = 2;
            this.btFAC.Text = "Fahrenheit a celsius";
            this.btFAC.UseVisualStyleBackColor = false;
            this.btFAC.Click += new System.EventHandler(this.btFAC_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(218, 117);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(142, 26);
            this.txtEntrada.TabIndex = 4;
            // 
            // Salida
            // 
            this.Salida.AutoSize = true;
            this.Salida.Location = new System.Drawing.Point(245, 186);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(86, 20);
            this.Salida.TabIndex = 5;
            this.Salida.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 221);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.btFAC);
            this.Controls.Add(this.btCAF);
            this.Controls.Add(this.ctTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctTitulo;
        private System.Windows.Forms.Button btCAF;
        private System.Windows.Forms.Button btFAC;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label Salida;
    }
}

