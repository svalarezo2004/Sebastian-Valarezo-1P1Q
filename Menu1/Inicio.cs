using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manipulaciónDeArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivos llamada1 = new Archivos();

            llamada1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres salir!", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
