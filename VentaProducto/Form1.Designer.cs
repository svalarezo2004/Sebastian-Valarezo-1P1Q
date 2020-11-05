namespace VentaProducto
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
            this.cB_Mouse = new System.Windows.Forms.CheckBox();
            this.cB_Teclado = new System.Windows.Forms.CheckBox();
            this.cB_Monitor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TotalSinIva = new System.Windows.Forms.Label();
            this.brt_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta de Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cB_Mouse
            // 
            this.cB_Mouse.AutoSize = true;
            this.cB_Mouse.Location = new System.Drawing.Point(13, 92);
            this.cB_Mouse.Name = "cB_Mouse";
            this.cB_Mouse.Size = new System.Drawing.Size(79, 17);
            this.cB_Mouse.TabIndex = 1;
            this.cB_Mouse.Text = "Mouse $12";
            this.cB_Mouse.UseVisualStyleBackColor = true;
            // 
            // cB_Teclado
            // 
            this.cB_Teclado.AutoSize = true;
            this.cB_Teclado.Location = new System.Drawing.Point(13, 116);
            this.cB_Teclado.Name = "cB_Teclado";
            this.cB_Teclado.Size = new System.Drawing.Size(86, 17);
            this.cB_Teclado.TabIndex = 2;
            this.cB_Teclado.Text = "Teclado $18";
            this.cB_Teclado.UseVisualStyleBackColor = true;
            // 
            // cB_Monitor
            // 
            this.cB_Monitor.AutoSize = true;
            this.cB_Monitor.Location = new System.Drawing.Point(13, 140);
            this.cB_Monitor.Name = "cB_Monitor";
            this.cB_Monitor.Size = new System.Drawing.Size(88, 17);
            this.cB_Monitor.TabIndex = 3;
            this.cB_Monitor.Text = "Monitor $150";
            this.cB_Monitor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione el o los productos que desea comprar";
            // 
            // lb_TotalSinIva
            // 
            this.lb_TotalSinIva.AutoSize = true;
            this.lb_TotalSinIva.Location = new System.Drawing.Point(13, 174);
            this.lb_TotalSinIva.Name = "lb_TotalSinIva";
            this.lb_TotalSinIva.Size = new System.Drawing.Size(0, 13);
            this.lb_TotalSinIva.TabIndex = 5;
            // 
            // brt_Calcular
            // 
            this.brt_Calcular.Location = new System.Drawing.Point(191, 116);
            this.brt_Calcular.Name = "brt_Calcular";
            this.brt_Calcular.Size = new System.Drawing.Size(75, 23);
            this.brt_Calcular.TabIndex = 6;
            this.brt_Calcular.Text = "Calcular";
            this.brt_Calcular.UseVisualStyleBackColor = true;
            this.brt_Calcular.Click += new System.EventHandler(this.brt_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 246);
            this.Controls.Add(this.brt_Calcular);
            this.Controls.Add(this.lb_TotalSinIva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cB_Monitor);
            this.Controls.Add(this.cB_Teclado);
            this.Controls.Add(this.cB_Mouse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cB_Mouse;
        private System.Windows.Forms.CheckBox cB_Teclado;
        private System.Windows.Forms.CheckBox cB_Monitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TotalSinIva;
        private System.Windows.Forms.Button brt_Calcular;
    }
}

