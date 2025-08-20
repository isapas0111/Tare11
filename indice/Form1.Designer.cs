namespace indice
{
    partial class lblTitulomts
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
            this.lblTitulokg = new System.Windows.Forms.Label();
            this.lblMtss = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulokg
            // 
            this.lblTitulokg.AutoSize = true;
            this.lblTitulokg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulokg.Location = new System.Drawing.Point(373, 42);
            this.lblTitulokg.Name = "lblTitulokg";
            this.lblTitulokg.Size = new System.Drawing.Size(200, 25);
            this.lblTitulokg.TabIndex = 0;
            this.lblTitulokg.Text = "Ingrese peso en Kg";
            this.lblTitulokg.Click += new System.EventHandler(this.lblTitulokg_Click);
            // 
            // lblMtss
            // 
            this.lblMtss.AutoSize = true;
            this.lblMtss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtss.Location = new System.Drawing.Point(33, 42);
            this.lblMtss.Name = "lblMtss";
            this.lblMtss.Size = new System.Drawing.Size(243, 25);
            this.lblMtss.TabIndex = 1;
            this.lblMtss.Text = "Ingrese su altura en mts";
            this.lblMtss.Click += new System.EventHandler(this.lblMtss_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(378, 95);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(149, 26);
            this.txtPeso.TabIndex = 2;
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(95, 95);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(141, 26);
            this.txtMetros.TabIndex = 3;
            this.txtMetros.TextChanged += new System.EventHandler(this.txtMetros_TextChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(236, 136);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(142, 39);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(269, 218);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(91, 20);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "Resultado";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(269, 260);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(87, 20);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Categoria";
            // 
            // lblTitulomts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblMtss);
            this.Controls.Add(this.lblTitulokg);
            this.Name = "lblTitulomts";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulokg;
        private System.Windows.Forms.Label lblMtss;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblEstado;
    }
}

