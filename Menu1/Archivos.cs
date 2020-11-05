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

namespace Menu1
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\rmar-\Desktop\Registro",true);
            try 
            {
                escribir.WriteLine("Nombre: " + txtBox_nombre);
                escribir.WriteLine("Apellido: " + txtBox_apellido);
                escribir.WriteLine("\n");
                MessageBox.Show("Error en Guardar registro");
            }
            catch
            {

            }
            escribir.Close();
            
        }
    }
}
