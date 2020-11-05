namespace SISTEMA
{
    partial class DatosDeContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDeContacto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DatosMostrar_txt = new System.Windows.Forms.RichTextBox();
            this.DatosContacto_Boton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usuario_txtDatos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 297);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datos";
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
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosMostrar_txt
            // 
            this.DatosMostrar_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DatosMostrar_txt.Location = new System.Drawing.Point(412, 12);
            this.DatosMostrar_txt.Name = "DatosMostrar_txt";
            this.DatosMostrar_txt.Size = new System.Drawing.Size(288, 272);
            this.DatosMostrar_txt.TabIndex = 1;
            this.DatosMostrar_txt.Text = "";
            this.DatosMostrar_txt.TextChanged += new System.EventHandler(this.DatosMostrar_txt_TextChanged);
            // 
            // DatosContacto_Boton
            // 
            this.DatosContacto_Boton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatosContacto_Boton.BackgroundImage")));
            this.DatosContacto_Boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DatosContacto_Boton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatosContacto_Boton.FlatAppearance.BorderSize = 0;
            this.DatosContacto_Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatosContacto_Boton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosContacto_Boton.Location = new System.Drawing.Point(229, 135);
            this.DatosContacto_Boton.Name = "DatosContacto_Boton";
            this.DatosContacto_Boton.Size = new System.Drawing.Size(164, 150);
            this.DatosContacto_Boton.TabIndex = 11;
            this.DatosContacto_Boton.TabStop = false;
            this.DatosContacto_Boton.Text = "Consultar";
            this.DatosContacto_Boton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DatosContacto_Boton.UseVisualStyleBackColor = true;
            this.DatosContacto_Boton.Click += new System.EventHandler(this.DatosContacto_Boton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Usuario_txtDatos
            // 
            this.Usuario_txtDatos.Location = new System.Drawing.Point(229, 109);
            this.Usuario_txtDatos.Name = "Usuario_txtDatos";
            this.Usuario_txtDatos.Size = new System.Drawing.Size(177, 20);
            this.Usuario_txtDatos.TabIndex = 13;
            // 
            // DatosDeContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 297);
            this.Controls.Add(this.Usuario_txtDatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DatosContacto_Boton);
            this.Controls.Add(this.DatosMostrar_txt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosDeContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosDeContacto";
            this.Load += new System.EventHandler(this.DatosDeContacto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DatosMostrar_txt;
        private System.Windows.Forms.Button DatosContacto_Boton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Usuario_txtDatos;
    }
}