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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Password_TexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String usu, pass; 
            StreamReader Lectura;
            string cadena, usuario, password;
            string[] campo = new string[4];
            char[] separador = { '-' };
            bool encontrado = false;

            try
            {
                usu = "admin";
                pass = "root";
                Lectura = File.OpenText("BDUsuarios.txt");
                usuario = Usuario_TextBox.Text;
                password = Password_TexBox.Text;
                cadena = Lectura.ReadLine();

                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[0].Trim().Equals(usuario) && campo[1].Trim().Equals(password) )
                    {
                        VentanaPrincipal principal_windows = new VentanaPrincipal();
                        MessageBox.Show("Usuario y Contraseña Correcta", "Inicio Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        encontrado = true;
                        principal_windows.Show();
                        this.Hide();
                    }
                    else
                    {
                        cadena = Lectura.ReadLine();
                    }
                }
                if (encontrado == false)
                {
                    Log llamada_log = new Log();
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    llamada_log.log();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Log
    {
        public void log()
        {
            DateTime errortime = DateTime.Now;
            StreamWriter registroerror = new StreamWriter(@"log.txt", true);
            try
            {
                registroerror.WriteLine("Error: Usuario o contraseña incorrecta");
                registroerror.WriteLine("Fecha de error: " + errortime);
                registroerror.WriteLine("\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            registroerror.Close();
        }
    }

    public class Registro_Usuarios
    {
        public void Registro()
        {
            MessageBox.Show("En construcción");

            StreamWriter registrousuarios = new StreamWriter(@"BDRegistros.txt", true);

        }
    }
}
