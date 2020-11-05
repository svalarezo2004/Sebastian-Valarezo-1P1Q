using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuarioyContraseña
{
    public partial class ManipulacionDeArchivos : Form
    {
        public ManipulacionDeArchivos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            

            //Entrada de Datos al archivo Registro.txt
            StreamWriter escribir = new StreamWriter(@"C:\Users\rmar-\Desktop\Registro.txt", true);
            try
            {
                escribir.WriteLine("Nombres: " + txtBox_nombre.Text);
                escribir.WriteLine("Apellidos: " + txtBox_apellido.Text);
                escribir.WriteLine("\n ");
                MessageBox.Show("Se ha registro con exito", "Confirmación de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            escribir.Close();

            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\rmar-\Desktop\Registro.txt");

            while (!leer.EndOfStream)
            {

                richTextBox1.AppendText(leer.ReadLine() + "\n ");
      
            }
        }

        private void ManipulacionDeArchivos_Load(object sender, EventArgs e)
        {

        }
    }
}

