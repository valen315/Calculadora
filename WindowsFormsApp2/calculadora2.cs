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
    public partial class calculadora2 : Form
    {
        Double numero = 0;
        Double aux = 0;
        int operadorclick = 0;
        String _operador = "";
        bool operacion_presionada = false;
        bool botonigual = false;
        
        public calculadora2()
        {
            InitializeComponent();
        }
       
        private double Calculo2(string operador, double Numero1, double Numero2)
        {
            double _resultado = 0;
            switch (operador)
            {
                case "+": _resultado = Numero1 + Numero2; break;
                case "-": _resultado = Numero1 - Numero2; break;
                case "x": _resultado = Numero1 * Numero2; break;
                case "/": if (Numero2 != 0) _resultado = Numero1 / Numero2; break;

                default: break;
            }
            return _resultado;
        }

        ///Este evento se utiliza desde cada uno de los botones numericos
        /// basicamente muestra en pantalla el valor presionado
        private void Button_Click(object sender, EventArgs e)
        { 
            Button btn = (Button)sender;
            if ((txtPantalla.Text == "0") || (operacion_presionada))
                txtPantalla.Clear();
            Historial.Text += btn.Text;
            operacion_presionada = false;
             
            if (btn.Text == ".")
            {
                if (!txtPantalla.Text.Contains("."))
                    txtPantalla.Text += btn.Text;
                operacion_presionada = false;
            }
            else
            {
                txtPantalla.Text += btn.Text;               
                operacion_presionada = false;
            }
        }

        
        private void bntBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            numero = 0;
            aux = 0;
            Historial.Text = "";
            _operador = "";
            operacion_presionada = false;
            operadorclick = 0;
            botonigual = false;
            MenuPrincipal ofrmPrincipals = (MenuPrincipal)this.MdiParent;
            ofrmPrincipals.Estado = "Resultado :" + " " + txtPantalla.Text;

        }

       //llama a todos los botones de calculo como Operador_click
    
        private void Operador_Click(object sender, EventArgs e)
        {
            operacion_presionada = true;
            Button btn = (Button)sender;
            Historial.Text += btn.Text;
            try
            {                
                if ((numero != 0) && (operacion_presionada))
                {
                    btnIgual.PerformClick();
                   _operador = btn.Text;
                    operacion_presionada = true;      
                }
                if (operadorclick == 0)
                {
                    operadorclick++;
                    numero = Double.Parse(txtPantalla.Text);                   
                    operacion_presionada = true;
                    _operador = btn.Text;
                     
                }
                if (!botonigual)
                {
                    aux = Double.Parse(txtPantalla.Text);
                    txtPantalla.Text = Convert.ToString(Calculo2(_operador, numero, aux));
                    aux = Double.Parse(txtPantalla.Text);
                    _operador = btn.Text;
                    botonigual = false;
                    operacion_presionada = true;                    
                }
                else
                {
                    botonigual = false;
                    _operador = btn.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error(?- " + ex.Message);
            }
            finally
            {
               // txtPantalla.Text = "";                
            }
        }
       
        private void btnIgual_Click(object sender, EventArgs e)
        {
            aux = float.Parse(txtPantalla.Text);
            txtPantalla.Text = Convert.ToString(Calculo2(_operador, numero, aux));
            numero = float.Parse(txtPantalla.Text);
            operacion_presionada = true;
            botonigual = true;
            
           
            MenuPrincipal ofrmPrincipals = (MenuPrincipal)this.MdiParent;
            ofrmPrincipals.Estado = "Resultado :" + " " + txtPantalla.Text;
        }

        private void btnEliminarNumero_Click(object sender, EventArgs e)
        {
            if(txtPantalla.Text.Length>0)
            {
                txtPantalla.Text = txtPantalla.Text.Remove(txtPantalla.Text.Length - 1, 1);
                Historial.Text= Historial.Text.Remove(Historial.Text.Length - 1, 1);
            }
            if (txtPantalla.Text == " ")
            {
                txtPantalla.Text = "0";
            }
        }

        private void calculadora2_Load(object sender, EventArgs e)
        {

        }
    }
}

