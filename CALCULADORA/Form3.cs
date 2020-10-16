using myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
    {
    public partial class Form3 : Form
    {
        clsCalculos calculos = new clsCalculos();
        double valor1, valor2;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty) //diferente a cadena de texto vacio 
                valor1 = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text != string.Empty)
                valor2 = Convert.ToDouble(textBox2.Text);

            textBox3.Text = calculos.resta(valor1, valor2).ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty) //diferente a cadena de texto vacio 
                valor1 = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text != string.Empty)
                valor2 = Convert.ToDouble(textBox2.Text);

            textBox3.Text = calculos.multiplicar(valor1, valor2).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty) //diferente a cadena de texto vacio 
                valor1 = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text != string.Empty)
                valor2 = Convert.ToDouble(textBox2.Text);

            textBox3.Text = calculos.Dividir(valor1, valor2).ToString();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty) //diferente a cadena de texto vacio 
                valor1 = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text != string.Empty)
                valor2 = Convert.ToDouble(textBox2.Text);

            textBox3.Text = calculos.suma(valor1, valor2).ToString();
        }
    }
}
