namespace MayorDe_Edad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnidentificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblrangoedad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación rango de edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tu edad :\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Arial", 16F);
            this.txtedad.Location = new System.Drawing.Point(211, 62);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 32);
            this.txtedad.TabIndex = 2;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // btnidentificar
            // 
            this.btnidentificar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnidentificar.Location = new System.Drawing.Point(211, 109);
            this.btnidentificar.Name = "btnidentificar";
            this.btnidentificar.Size = new System.Drawing.Size(100, 33);
            this.btnidentificar.TabIndex = 3;
            this.btnidentificar.Text = "Identificar";
            this.btnidentificar.UseVisualStyleBackColor = true;
            this.btnidentificar.Click += new System.EventHandler(this.btnidentificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnlimpiar.Location = new System.Drawing.Point(211, 159);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 33);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(33, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rango de edad :\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(372, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblrangoedad
            // 
            this.lblrangoedad.AutoSize = true;
            this.lblrangoedad.Font = new System.Drawing.Font("Arial", 14F);
            this.lblrangoedad.Location = new System.Drawing.Point(211, 330);
            this.lblrangoedad.Name = "lblrangoedad";
            this.lblrangoedad.Size = new System.Drawing.Size(277, 22);
            this.lblrangoedad.TabIndex = 7;
            this.lblrangoedad.Text = "Identificación de rango de edad";
            this.lblrangoedad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.lblrangoedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnidentificar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayor de edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnidentificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblrangoedad;
    }
}

