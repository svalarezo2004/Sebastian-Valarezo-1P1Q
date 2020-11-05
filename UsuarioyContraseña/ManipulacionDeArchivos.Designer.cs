namespace UsuarioyContraseña
{
    partial class ManipulacionDeArchivos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.txtBox_apellido = new System.Windows.Forms.TextBox();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manipulación de Archivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(254, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(380, 306);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(12, 362);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(230, 50);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(71, 239);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(115, 30);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Location = new System.Drawing.Point(71, 275);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(115, 30);
            this.btn_cargar.TabIndex = 4;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // txtBox_apellido
            // 
            this.txtBox_apellido.Location = new System.Drawing.Point(12, 213);
            this.txtBox_apellido.Name = "txtBox_apellido";
            this.txtBox_apellido.Size = new System.Drawing.Size(230, 20);
            this.txtBox_apellido.TabIndex = 5;
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(12, 171);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(230, 20);
            this.txtBox_nombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellidos";
            // 
            // ManipulacionDeArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(645, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_nombre);
            this.Controls.Add(this.txtBox_apellido);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManipulacionDeArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManipulacionDeArchivos";
            this.Load += new System.EventHandler(this.ManipulacionDeArchivos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TextBox txtBox_apellido;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}