namespace HolaMundo
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
            this.btIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.ctClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(534, 62);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(147, 56);
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "iniciar secion";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // ctUsuario
            // 
            this.ctUsuario.Location = new System.Drawing.Point(193, 48);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(211, 26);
            this.ctUsuario.TabIndex = 3;
            // 
            // ctClave
            // 
            this.ctClave.Location = new System.Drawing.Point(193, 98);
            this.ctClave.Name = "ctClave";
            this.ctClave.PasswordChar = '*';
            this.ctClave.Size = new System.Drawing.Size(137, 26);
            this.ctClave.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 213);
            this.Controls.Add(this.ctClave);
            this.Controls.Add(this.ctUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.TextBox ctClave;
    }
}

