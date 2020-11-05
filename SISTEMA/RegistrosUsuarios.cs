using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SISTEMA
{
    public partial class RegistrosUsuarios : Form
    {
        public RegistrosUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guardar_Boton_Click(object sender, EventArgs e)
        {
            StreamWriter guardardatos = new StreamWriter(@"BDRegistros.txt", true);

            try
            {   
                guardardatos.WriteLine(Nombre_TexBox.Text + "-" + Apellido_TexBox.Text + "-" + Edad_TextBox.Text + "-" + Usuario_TexBox.Text);
                MessageBox.Show("Registor guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            guardardatos.Close();

            StreamWriter guardarusuario = new StreamWriter(@"BDUsuarios.txt", true);

            try
            {
                guardarusuario.WriteLine("");
                guardarusuario.WriteLine(Usuario_TexBox.Text + "-" + PassWord_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            guardarusuario.Close();
        }

        private void Cerrar_Boton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
