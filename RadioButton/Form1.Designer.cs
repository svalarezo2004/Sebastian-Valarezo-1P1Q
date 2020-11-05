namespace RadioButton
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_v1 = new System.Windows.Forms.TextBox();
            this.txt_v2 = new System.Windows.Forms.TextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.grB_operaciones = new System.Windows.Forms.GroupBox();
            this.rB_Resta = new System.Windows.Forms.RadioButton();
            this.rB_Suma = new System.Windows.Forms.RadioButton();
            this.rB_Division = new System.Windows.Forms.RadioButton();
            this.rB_Multiplicacion = new System.Windows.Forms.RadioButton();
            this.grB_operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 110);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(247, 44);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_v1
            // 
            this.txt_v1.Location = new System.Drawing.Point(12, 23);
            this.txt_v1.Name = "txt_v1";
            this.txt_v1.Size = new System.Drawing.Size(247, 20);
            this.txt_v1.TabIndex = 1;
            // 
            // txt_v2
            // 
            this.txt_v2.Location = new System.Drawing.Point(12, 49);
            this.txt_v2.Name = "txt_v2";
            this.txt_v2.Size = new System.Drawing.Size(247, 20);
            this.txt_v2.TabIndex = 2;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(129, 84);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(13, 13);
            this.lb_resultado.TabIndex = 3;
            this.lb_resultado.Text = "0";
            // 
            // grB_operaciones
            // 
            this.grB_operaciones.Controls.Add(this.rB_Multiplicacion);
            this.grB_operaciones.Controls.Add(this.rB_Division);
            this.grB_operaciones.Controls.Add(this.rB_Resta);
            this.grB_operaciones.Controls.Add(this.rB_Suma);
            this.grB_operaciones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grB_operaciones.Location = new System.Drawing.Point(12, 169);
            this.grB_operaciones.Name = "grB_operaciones";
            this.grB_operaciones.Size = new System.Drawing.Size(247, 179);
            this.grB_operaciones.TabIndex = 4;
            this.grB_operaciones.TabStop = false;
            this.grB_operaciones.Text = "Operaciones";
            // 
            // rB_Resta
            // 
            this.rB_Resta.AutoSize = true;
            this.rB_Resta.Location = new System.Drawing.Point(55, 115);
            this.rB_Resta.Name = "rB_Resta";
            this.rB_Resta.Size = new System.Drawing.Size(53, 17);
            this.rB_Resta.TabIndex = 1;
            this.rB_Resta.TabStop = true;
            this.rB_Resta.Text = "Resta";
            this.rB_Resta.UseVisualStyleBackColor = true;
            this.rB_Resta.CheckedChanged += new System.EventHandler(this.rB_Resta_CheckedChanged);
            // 
            // rB_Suma
            // 
            this.rB_Suma.AutoSize = true;
            this.rB_Suma.Checked = true;
            this.rB_Suma.Location = new System.Drawing.Point(55, 91);
            this.rB_Suma.Name = "rB_Suma";
            this.rB_Suma.Size = new System.Drawing.Size(52, 17);
            this.rB_Suma.TabIndex = 0;
            this.rB_Suma.TabStop = true;
            this.rB_Suma.Text = "Suma";
            this.rB_Suma.UseVisualStyleBackColor = true;
            // 
            // rB_Division
            // 
            this.rB_Division.AutoSize = true;
            this.rB_Division.Location = new System.Drawing.Point(55, 68);
            this.rB_Division.Name = "rB_Division";
            this.rB_Division.Size = new System.Drawing.Size(62, 17);
            this.rB_Division.TabIndex = 2;
            this.rB_Division.TabStop = true;
            this.rB_Division.Text = "División";
            this.rB_Division.UseVisualStyleBackColor = true;
            // 
            // rB_Multiplicacion
            // 
            this.rB_Multiplicacion.AutoSize = true;
            this.rB_Multiplicacion.Location = new System.Drawing.Point(55, 45);
            this.rB_Multiplicacion.Name = "rB_Multiplicacion";
            this.rB_Multiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rB_Multiplicacion.TabIndex = 3;
            this.rB_Multiplicacion.TabStop = true;
            this.rB_Multiplicacion.Text = "Multiplicación";
            this.rB_Multiplicacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 360);
            this.Controls.Add(this.grB_operaciones);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.txt_v2);
            this.Controls.Add(this.txt_v1);
            this.Controls.Add(this.btn_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "RadioButton Actividad";
            this.grB_operaciones.ResumeLayout(false);
            this.grB_operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_v1;
        private System.Windows.Forms.TextBox txt_v2;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.GroupBox grB_operaciones;
        private System.Windows.Forms.RadioButton rB_Resta;
        private System.Windows.Forms.RadioButton rB_Suma;
        private System.Windows.Forms.RadioButton rB_Multiplicacion;
        private System.Windows.Forms.RadioButton rB_Division;
    }
}

