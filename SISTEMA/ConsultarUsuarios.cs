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
    public partial class ConsultarUsuarios : Form
    {
        public ConsultarUsuarios()
        {
            InitializeComponent();
        }

        private void Consultar_Boton_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            string cadena, usuario;
            string[] campo = new string[4];
            char[] separador = { '-' };
            bool encontrado = false;

            try
            {
                Lectura = File.OpenText("BDUsuarios.txt");
                usuario = Usuario_txtconsulta.Text;
                cadena = Lectura.ReadLine();

                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[0].Trim().Equals(usuario))
                    {
                        MessageBox.Show("Usuario Encontrado","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usuario_txtconsulta.Clear();
                        encontrado = true;
                    }
                    else
                    {
                        cadena = Lectura.ReadLine();
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("Usuario no Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Lectura.Close();
            }
            catch (FileNotFoundException fi)
            {
                MessageBox.Show("Error" + fi.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal llamada = new VentanaPrincipal();
            llamada.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConsultarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
