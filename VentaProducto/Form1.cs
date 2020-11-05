using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brt_Calcular_Click(object sender, EventArgs e)
        {
            int total = 0; //Acumulador

            if (cB_Monitor.Checked == true)
            {
                total = total + 150;
            }

            if (cB_Mouse.Checked == true)
            {
                total = total + 12;
            }

            if (cB_Teclado.Checked == true)
            {
                total = total + 20;
            }

            lb_TotalSinIva.Text = "$" + Convert.ToString(total);
            MessageBox.Show("$" + Convert.ToString(total), "Calculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
