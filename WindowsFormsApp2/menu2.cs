using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnvioDeMail enviar_mail = new EnvioDeMail();
            //De tipo formulario  Form
            enviar_mail.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            calculadora2 calculadora2 = new calculadora2();
            calculadora2.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.ShowDialog();

        }
    }
}
