namespace CalculadoraEnterosInterfaz
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
            this.buttonsuma = new System.Windows.Forms.Button();
            this.buttonresta = new System.Windows.Forms.Button();
            this.buttonmulti = new System.Windows.Forms.Button();
            this.buttondivi = new System.Windows.Forms.Button();
            this.buttonpotencia = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonigual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonsuma
            // 
            this.buttonsuma.Location = new System.Drawing.Point(92, 48);
            this.buttonsuma.Name = "buttonsuma";
            this.buttonsuma.Size = new System.Drawing.Size(75, 23);
            this.buttonsuma.TabIndex = 0;
            this.buttonsuma.Text = "+";
            this.buttonsuma.UseVisualStyleBackColor = true;
            this.buttonsuma.Click += new System.EventHandler(this.buttonsuma_Click);
            // 
            // buttonresta
            // 
            this.buttonresta.Location = new System.Drawing.Point(92, 77);
            this.buttonresta.Name = "buttonresta";
            this.buttonresta.Size = new System.Drawing.Size(75, 23);
            this.buttonresta.TabIndex = 1;
            this.buttonresta.Text = "-";
            this.buttonresta.UseVisualStyleBackColor = true;
            this.buttonresta.Click += new System.EventHandler(this.buttonresta_Click);
            // 
            // buttonmulti
            // 
            this.buttonmulti.Location = new System.Drawing.Point(92, 106);
            this.buttonmulti.Name = "buttonmulti";
            this.buttonmulti.Size = new System.Drawing.Size(75, 23);
            this.buttonmulti.TabIndex = 2;
            this.buttonmulti.Text = "*";
            this.buttonmulti.UseVisualStyleBackColor = true;
            this.buttonmulti.Click += new System.EventHandler(this.buttonmulti_Click);
            // 
            // buttondivi
            // 
            this.buttondivi.Location = new System.Drawing.Point(173, 48);
            this.buttondivi.Name = "buttondivi";
            this.buttondivi.Size = new System.Drawing.Size(75, 23);
            this.buttondivi.TabIndex = 3;
            this.buttondivi.Text = "/";
            this.buttondivi.UseVisualStyleBackColor = true;
            this.buttondivi.Click += new System.EventHandler(this.buttondivi_Click);
            // 
            // buttonpotencia
            // 
            this.buttonpotencia.Location = new System.Drawing.Point(173, 77);
            this.buttonpotencia.Name = "buttonpotencia";
            this.buttonpotencia.Size = new System.Drawing.Size(75, 23);
            this.buttonpotencia.TabIndex = 4;
            this.buttonpotencia.Text = "^";
            this.buttonpotencia.UseVisualStyleBackColor = true;
            this.buttonpotencia.Click += new System.EventHandler(this.buttonpotencia_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(92, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 20);
            this.textBox.TabIndex = 5;
            // 
            // buttonigual
            // 
            this.buttonigual.Location = new System.Drawing.Point(173, 106);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(75, 23);
            this.buttonigual.TabIndex = 6;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = true;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 161);
            this.Controls.Add(this.buttonigual);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonpotencia);
            this.Controls.Add(this.buttondivi);
            this.Controls.Add(this.buttonmulti);
            this.Controls.Add(this.buttonresta);
            this.Controls.Add(this.buttonsuma);
            this.Name = "Form1";
            this.Text = "Calculadora Enteros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsuma;
        private System.Windows.Forms.Button buttonresta;
        private System.Windows.Forms.Button buttonmulti;
        private System.Windows.Forms.Button buttondivi;
        private System.Windows.Forms.Button buttonpotencia;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonigual;
    }
}

