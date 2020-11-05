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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }


        private void VentanaPrincipal_Load_1(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConsultaUsuario_Boton_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios cstusu = new ConsultarUsuarios();
            cstusu.Show();
            this.Hide();
        }

        private void DatosContacto_Boton_Click(object sender, EventArgs e)
        {
            DatosDeContacto ddc = new DatosDeContacto();
            ddc.Show();
            this.Hide();
        }

        private void RegistrarUsuarios_Click(object sender, EventArgs e)
        {           
            DescripcionDelPrograma dcdp = new DescripcionDelPrograma();
            dcdp.Show();
        }

        private void Informacion_Boton_Click(object sender, EventArgs e)
        {
            RegistrosUsuarios rtu = new RegistrosUsuarios();
            rtu.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Menu_Panel.Width = 200;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Menu_Panel.Width = 50;
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios cstusu = new ConsultarUsuarios();
            cstusu.Show();
        }

        private void datosDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosDeContacto ddc = new DatosDeContacto();
            ddc.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RegistrosUsuarios rtu = new RegistrosUsuarios();
            rtu.Show();
        }

        private void descripciónDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescripcionDelPrograma dcdp = new DescripcionDelPrograma();
            dcdp.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Redes_Sociales rs = new Redes_Sociales();
            rs.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login llamada = new login();
            llamada.Show();
            this.Hide();
        }
    }
}
