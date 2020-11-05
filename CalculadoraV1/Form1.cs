using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la calculadora v.1 By: Sebastián Valarezo", "Welcome", MessageBoxButtons.OK);
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            
        }

        private void grB_keyboard_Enter(object sender, EventArgs e)
        {

        }
    }
}
