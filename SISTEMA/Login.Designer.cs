namespace SISTEMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Usuario_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TexBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Registrarse_Btn = new System.Windows.Forms.Button();
            this.Entrar_Btn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 261);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Usuario_TextBox
            // 
            this.Usuario_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usuario_TextBox.Location = new System.Drawing.Point(88, 99);
            this.Usuario_TextBox.Name = "Usuario_TextBox";
            this.Usuario_TextBox.Size = new System.Drawing.Size(233, 20);
            this.Usuario_TextBox.TabIndex = 1;
            // 
            // Password_TexBox
            // 
            this.Password_TexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_TexBox.Location = new System.Drawing.Point(88, 150);
            this.Password_TexBox.Name = "Password_TexBox";
            this.Password_TexBox.Size = new System.Drawing.Size(233, 20);
            this.Password_TexBox.TabIndex = 2;
            this.Password_TexBox.UseSystemPasswordChar = true;
            this.Password_TexBox.TextChanged += new System.EventHandler(this.Password_TexBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Registrarse_Btn);
            this.panel2.Controls.Add(this.Entrar_Btn);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Password_TexBox);
            this.panel2.Controls.Add(this.Usuario_TextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 261);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(323, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrarse_Btn
            // 
            this.Registrarse_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Registrarse_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrarse_Btn.FlatAppearance.BorderSize = 0;
            this.Registrarse_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(210)))), ((int)(((byte)(233)))));
            this.Registrarse_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(131)))), ((int)(((byte)(186)))));
            this.Registrarse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrarse_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse_Btn.Location = new System.Drawing.Point(202, 199);
            this.Registrarse_Btn.Name = "Registrarse_Btn";
            this.Registrarse_Btn.Size = new System.Drawing.Size(100, 50);
            this.Registrarse_Btn.TabIndex = 7;
            this.Registrarse_Btn.TabStop = false;
            this.Registrarse_Btn.Text = "Registrarse";
            this.Registrarse_Btn.UseVisualStyleBackColor = false;
            // 
            // Entrar_Btn
            // 
            this.Entrar_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Entrar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar_Btn.FlatAppearance.BorderSize = 0;
            this.Entrar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(210)))), ((int)(((byte)(233)))));
            this.Entrar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(131)))), ((int)(((byte)(186)))));
            this.Entrar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar_Btn.Location = new System.Drawing.Point(52, 199);
            this.Entrar_Btn.Name = "Entrar_Btn";
            this.Entrar_Btn.Size = new System.Drawing.Size(100, 50);
            this.Entrar_Btn.TabIndex = 6;
            this.Entrar_Btn.TabStop = false;
            this.Entrar_Btn.Text = "Entrar";
            this.Entrar_Btn.UseVisualStyleBackColor = false;
            this.Entrar_Btn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(34, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Iniciar Sesión";
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load_1);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.TextBox txtbUsu;
        private System.Windows.Forms.CheckBox checkBoxMostrar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Usuario_TextBox;
        private System.Windows.Forms.TextBox Password_TexBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Registrarse_Btn;
        private System.Windows.Forms.Button Entrar_Btn;
        private System.Windows.Forms.Button button1;
    }
}

