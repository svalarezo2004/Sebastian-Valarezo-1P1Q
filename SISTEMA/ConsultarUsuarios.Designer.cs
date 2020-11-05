namespace SISTEMA
{
    partial class ConsultarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario_txtconsulta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Consultar_Boton = new System.Windows.Forms.Button();
            this.Estado_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 176);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usuario_txtconsulta
            // 
            this.Usuario_txtconsulta.Location = new System.Drawing.Point(386, 78);
            this.Usuario_txtconsulta.Name = "Usuario_txtconsulta";
            this.Usuario_txtconsulta.Size = new System.Drawing.Size(125, 20);
            this.Usuario_txtconsulta.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Consultar_Boton
            // 
            this.Consultar_Boton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Consultar_Boton.BackgroundImage")));
            this.Consultar_Boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Consultar_Boton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Consultar_Boton.FlatAppearance.BorderSize = 0;
            this.Consultar_Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar_Boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar_Boton.Location = new System.Drawing.Point(517, 28);
            this.Consultar_Boton.Name = "Consultar_Boton";
            this.Consultar_Boton.Size = new System.Drawing.Size(129, 121);
            this.Consultar_Boton.TabIndex = 1;
            this.Consultar_Boton.Text = "Consultar";
            this.Consultar_Boton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Consultar_Boton.UseVisualStyleBackColor = true;
            this.Consultar_Boton.Click += new System.EventHandler(this.Consultar_Boton_Click);
            // 
            // Estado_label
            // 
            this.Estado_label.AutoSize = true;
            this.Estado_label.Location = new System.Drawing.Point(214, 194);
            this.Estado_label.Name = "Estado_label";
            this.Estado_label.Size = new System.Drawing.Size(0, 13);
            this.Estado_label.TabIndex = 7;
            // 
            // ConsultarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 176);
            this.Controls.Add(this.Estado_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Usuario_txtconsulta);
            this.Controls.Add(this.Consultar_Boton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarUsuarios";
            this.Load += new System.EventHandler(this.ConsultarUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Consultar_Boton;
        private System.Windows.Forms.TextBox Usuario_txtconsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Estado_label;
    }
}