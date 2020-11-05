namespace UsuarioyContraseña
{
    partial class Login
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
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_usu = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.checkBox_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Spooky Cat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_iniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(12, 174);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(150, 35);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_register.Enabled = false;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(222, 174);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(150, 35);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Registrarse";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtBox_usu
            // 
            this.txtBox_usu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_usu.Location = new System.Drawing.Point(112, 66);
            this.txtBox_usu.Name = "txtBox_usu";
            this.txtBox_usu.Size = new System.Drawing.Size(213, 20);
            this.txtBox_usu.TabIndex = 5;
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_pass.Location = new System.Drawing.Point(112, 116);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(213, 20);
            this.txtBox_pass.TabIndex = 6;
            this.txtBox_pass.UseSystemPasswordChar = true;
            // 
            // checkBox_pass
            // 
            this.checkBox_pass.AutoSize = true;
            this.checkBox_pass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_pass.Location = new System.Drawing.Point(112, 143);
            this.checkBox_pass.Name = "checkBox_pass";
            this.checkBox_pass.Size = new System.Drawing.Size(139, 17);
            this.checkBox_pass.TabIndex = 7;
            this.checkBox_pass.Text = "Mostrar Contraseña";
            this.checkBox_pass.UseVisualStyleBackColor = true;
            this.checkBox_pass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.checkBox_pass);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.txtBox_usu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_usu;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.CheckBox checkBox_pass;
    }
}

