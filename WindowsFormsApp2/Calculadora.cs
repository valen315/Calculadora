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

namespace  WindowsFormsApp2
{
    public partial class Calculadora : Form
    {
        //double valor1, valor2;
        public Calculadora()
        {
            InitializeComponent();
        }


        private void btnRestar_Click(object sender, EventArgs e)
        {
            clsCalculos calculos = new clsCalculos();

            try
            {

                if (ValidacionCampoOK1("Restar"))
                {
                    //valor1 = Convert.ToDouble(textBox1.Text);
                    //valor2 = Convert.ToDouble(textBox2.Text);
                    //textBox3.Text = calculos.resta(valor1, valor2).ToString();

                    textBox3.Text = calculos.resta(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

                }        
            }
            catch (Exception er)
            {
                MessageBox.Show("Erroor: " + er.Message);
            }
        }
        /*
        private Boolean ValidacionCampoOK(string mensaje)
        {
            bool resultado = true;
            if (textBox1.Text == string.Empty)
            {
                resultado = false;
                MessageBox.Show("para "+ mensaje + " debe completar el campo 1");
            }

            if (textBox2.Text == string.Empty)
            {
                resultado = false;
                MessageBox.Show("para " + mensaje + " debe completar el campo 2");
            }
            return resultado;
        } 

        */
        private Boolean ValidacionCampoOK1(string mensaje)
        {

            return !(textBox1.Text == string.Empty || textBox2.Text == string.Empty);
        }


        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            clsCalculos calculos = new clsCalculos();
            try
            {

                if (ValidacionCampoOK1("Multiplicar"))
                {                 
                    textBox3.Text = calculos.multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Erroor: " + er.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            clsCalculos calculos = new clsCalculos();
            try
            {
                if (ValidacionCampoOK1("Division"))
                {
                    textBox3.Text = calculos.Dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Erroor: " + er.Message);

            }
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            clsCalculos calculos = new clsCalculos();
            try
            {
                if (ValidacionCampoOK1("Sumar"))
                {
                    textBox3.Text = calculos.suma(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Erroor: " + er.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}