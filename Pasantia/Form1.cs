using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasantia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton solicitar pasantia
            new SolicitarPasantia().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AgregarTutores().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new VerificarTutores().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VerificarPasantia().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new AgregarCarreras().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new ConsultarCarrera().Show();
        }

            

        private void button5_Click(object sender, EventArgs e)
        {
            new AgregarEmpresa().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ConsultarEmpresa().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
