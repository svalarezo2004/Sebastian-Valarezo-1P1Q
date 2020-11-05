using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, v2, r;
            v1 = 0;
            v2 = 0;
            r = 0;

            v1 = Convert.ToDouble(txt_v1.Text);
            v2 = Convert.ToDouble(txt_v2.Text);

            if (rB_Suma.Checked == true)
            {
                r = v1 + v2;

                DialogResult b = MessageBox.Show("Tu resultado es: " + r, "Suma", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (b == DialogResult.OK)
                {
                    MessageBox.Show("Usted esta de acuerdo con el resultado");
                }

                if (b == DialogResult.Cancel)
                {
                    MessageBox.Show("Usted no esta de acuerdo con el resultado");
                }

                lb_resultado.Text = Convert.ToString(r);
            }

            if (rB_Resta.Checked == true)
            {
                r = v1 - v2;

                DialogResult b = MessageBox.Show("Tu resultado es: " + r, "Resta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (b == DialogResult.OK)
                {
                    MessageBox.Show("Usted esta de acuerdo con el resultado");
                }

                if (b == DialogResult.Cancel)
                {
                    MessageBox.Show("Usted no esta de acuerdo con el resultado");
                }

                lb_resultado.Text = Convert.ToString(r);
            }

            if (rB_Multiplicacion.Checked == true)
            {
                r = v1 * v2;

                DialogResult b = MessageBox.Show("Tu resultado es: " + r, "Multiplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (b == DialogResult.OK)
                {
                    MessageBox.Show("Usted esta de acuerdo con el resultado");
                }

                if (b == DialogResult.Cancel)
                {
                    MessageBox.Show("Usted no esta de acuerdo con el resultado");
                }

                lb_resultado.Text = Convert.ToString(r);
            }
        }

        private void rB_Resta_CheckedChanged(object sender, EventArgs e)    
        {

        }
    }
}
