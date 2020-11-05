namespace Sebastian_Valarezo_1P1Q
{
    partial class login
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
            this.bnt_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnt_login
            // 
            this.bnt_login.Location = new System.Drawing.Point(72, 117);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(99, 51);
            this.bnt_login.TabIndex = 0;
            this.bnt_login.Text = "LOGIN";
            this.bnt_login.UseVisualStyleBackColor = true;
            this.bnt_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txt_usu
            // 
            this.txt_usu.Location = new System.Drawing.Point(91, 34);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(142, 20);
            this.txt_usu.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(91, 73);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(142, 20);
            this.txt_pass.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 180);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_login);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.TextBox txt_pass;
    }
}

