namespace SISTEMA
{
    partial class RegistrosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cerrar_Boton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edad_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pais_Text = new System.Windows.Forms.ComboBox();
            this.PassWord_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Usuario_TexBox = new System.Windows.Forms.TextBox();
            this.Apellido_TexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre_TexBox = new System.Windows.Forms.TextBox();
            this.Guardar_Boton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 421);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cerrar_Boton);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.Guardar_Boton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 421);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Cerrar_Boton
            // 
            this.Cerrar_Boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cerrar_Boton.FlatAppearance.BorderSize = 0;
            this.Cerrar_Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar_Boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar_Boton.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar_Boton.Image")));
            this.Cerrar_Boton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cerrar_Boton.Location = new System.Drawing.Point(278, 327);
            this.Cerrar_Boton.Name = "Cerrar_Boton";
            this.Cerrar_Boton.Size = new System.Drawing.Size(170, 50);
            this.Cerrar_Boton.TabIndex = 6;
            this.Cerrar_Boton.Text = "Cerrar";
            this.Cerrar_Boton.UseVisualStyleBackColor = true;
            this.Cerrar_Boton.Click += new System.EventHandler(this.Cerrar_Boton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Edad_TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Pais_Text);
            this.groupBox1.Controls.Add(this.PassWord_TextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Usuario_TexBox);
            this.groupBox1.Controls.Add(this.Apellido_TexBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nombre_TexBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // Edad_TextBox
            // 
            this.Edad_TextBox.Location = new System.Drawing.Point(201, 80);
            this.Edad_TextBox.Name = "Edad_TextBox";
            this.Edad_TextBox.Size = new System.Drawing.Size(131, 20);
            this.Edad_TextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pais";
            // 
            // Pais_Text
            // 
            this.Pais_Text.FormattingEnabled = true;
            this.Pais_Text.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guyana",
            "Guinea",
            "Guinea ecuatorial",
            "Guinea-Bisáu",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia del Norte",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumanía",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.Pais_Text.Location = new System.Drawing.Point(201, 41);
            this.Pais_Text.Name = "Pais_Text";
            this.Pais_Text.Size = new System.Drawing.Size(131, 21);
            this.Pais_Text.TabIndex = 11;
            this.Pais_Text.Text = "Seleccione";
            // 
            // PassWord_TextBox
            // 
            this.PassWord_TextBox.Location = new System.Drawing.Point(9, 158);
            this.PassWord_TextBox.Name = "PassWord_TextBox";
            this.PassWord_TextBox.Size = new System.Drawing.Size(162, 20);
            this.PassWord_TextBox.TabIndex = 10;
            this.PassWord_TextBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario";
            // 
            // Usuario_TexBox
            // 
            this.Usuario_TexBox.Location = new System.Drawing.Point(9, 119);
            this.Usuario_TexBox.Name = "Usuario_TexBox";
            this.Usuario_TexBox.Size = new System.Drawing.Size(162, 20);
            this.Usuario_TexBox.TabIndex = 7;
            // 
            // Apellido_TexBox
            // 
            this.Apellido_TexBox.Location = new System.Drawing.Point(9, 80);
            this.Apellido_TexBox.Name = "Apellido_TexBox";
            this.Apellido_TexBox.Size = new System.Drawing.Size(162, 20);
            this.Apellido_TexBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // Nombre_TexBox
            // 
            this.Nombre_TexBox.Location = new System.Drawing.Point(9, 41);
            this.Nombre_TexBox.Name = "Nombre_TexBox";
            this.Nombre_TexBox.Size = new System.Drawing.Size(162, 20);
            this.Nombre_TexBox.TabIndex = 4;
            // 
            // Guardar_Boton
            // 
            this.Guardar_Boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Guardar_Boton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardar_Boton.FlatAppearance.BorderSize = 0;
            this.Guardar_Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar_Boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_Boton.Image = ((System.Drawing.Image)(resources.GetObject("Guardar_Boton.Image")));
            this.Guardar_Boton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar_Boton.Location = new System.Drawing.Point(87, 327);
            this.Guardar_Boton.Name = "Guardar_Boton";
            this.Guardar_Boton.Size = new System.Drawing.Size(170, 50);
            this.Guardar_Boton.TabIndex = 3;
            this.Guardar_Boton.Text = "Guardar";
            this.Guardar_Boton.UseVisualStyleBackColor = true;
            this.Guardar_Boton.Click += new System.EventHandler(this.Guardar_Boton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Escriba los dos nombre y los dos apellidos";
            // 
            // RegistrosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrosUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Nombre_TexBox;
        private System.Windows.Forms.Button Guardar_Boton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWord_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Usuario_TexBox;
        private System.Windows.Forms.TextBox Apellido_TexBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cerrar_Boton;
        private System.Windows.Forms.TextBox Edad_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Pais_Text;
        private System.Windows.Forms.Label label8;
    }
}