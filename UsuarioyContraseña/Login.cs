using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuarioyContraseña
{
    public partial class Login : Form
    {

        string usuarios;

        List<string> listaUsuario;
        List<string> listapassword;

        public Login()
        {
            InitializeComponent();

            usuarios = @"C:\Users\rmar-\Desktop\usuarios.txt";

            listaUsuario = new List<string>();
            listapassword = new List<string>();
        }

        public void ListaUsuarios()
        {
            listaUsuario.Clear();
            listapassword.Clear();

            if (File.Exists(usuarios))
            {
                using(StreamReader file = new StreamReader(usuarios))
                {
                    int contadorLineas = 0;
                    string usuario = "";

                    while ((usuario = file.ReadLine()) != null)
                    {
                        listaUsuario.Add(usuario.Split(':')[0]);
                        listapassword.Add(usuario.Split(':')[1]);

                        contadorLineas++;
                    }

                    file.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = "admin";
            String password = "root";

            if (txtBox_usu.Text == usuario && txtBox_pass.Text == password)
            {
                MessageBox.Show("Has iniciado Sesion", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ManipulacionDeArchivos ProgramArchivos = new ManipulacionDeArchivos();
                ProgramArchivos.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login llamadalog = new Login();
                llamadalog.Log();
            }
        }

        public void Log()
        {
            DateTime currentDate = DateTime.Now;

            StreamWriter errorlog = new StreamWriter(@"C:\Users\rmar-\Desktop\log.txt", true);
            try
            {
                errorlog.WriteLine("Error: Error al iniciar Sesión");
                errorlog.WriteLine("Hora: " + currentDate);
                errorlog.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("No se encuentrael archivo log");
            }
            errorlog.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pass.Checked == true)
            {
                txtBox_pass.UseSystemPasswordChar = false;
            }
            if (checkBox_pass.Checked == false)
            {
                txtBox_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
