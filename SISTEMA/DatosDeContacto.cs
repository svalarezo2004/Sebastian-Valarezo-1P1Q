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
    public partial class DatosDeContacto : Form
    {
        public DatosDeContacto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal llamada = new VentanaPrincipal();
            llamada.Show();
            this.Hide();
        }

        private void DatosContacto_Boton_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            string cadena, usuario;
            string[] campo = new string[4];
            char[] separador = { '-' };
            bool encontrado = false;

            try
            {
                Lectura = File.OpenText("BDRegistros.txt");
                usuario = Usuario_txtDatos.Text;
                cadena = Lectura.ReadLine();

                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[3].Trim().Equals(usuario))
                    {
                        StreamReader leer = new StreamReader("BDRegistros.txt");
                        if (!leer.EndOfStream)
                        {
                            MessageBox.Show("Usuario Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DatosMostrar_txt.AppendText("Nombre"+campo[0] +"Apellido"+ campo[1] +"Edad"+ campo[2] +"Usuario"+ campo[3] + "\n ");
                            encontrado = true;
                        }
                       
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
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void DatosDeContacto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DatosMostrar_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
