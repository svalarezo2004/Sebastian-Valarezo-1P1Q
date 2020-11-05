using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Redes_Sociales : Form
    {
        public Redes_Sociales()
        {
            InitializeComponent();
        }

        private void Redes_Sociales_Load(object sender, EventArgs e)
        {

        }

        private void btn_InfoS_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Info_Sebastian.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Info_Sebastian.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Info_Jimmy.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Info_Jimmy.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Info_Castro.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Info_Castro.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal volver = new VentanaPrincipal();
            volver.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
