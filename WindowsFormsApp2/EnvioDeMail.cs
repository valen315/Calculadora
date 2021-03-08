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
    public partial class EnvioDeMail : Form
    {
        public EnvioDeMail()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Alerta.Visible = false;

            System.Net.Mail.MailMessage ObtenerDatos = new System.Net.Mail.MailMessage();
            ObtenerDatos.To.Add(btnPara.Text); //PARA
            ObtenerDatos.Subject = btnAsunto.Text;//ASUNTO
            ObtenerDatos.SubjectEncoding = System.Text.Encoding.UTF8;
            ObtenerDatos.Body = btnMensaje.Text; //MENSAJE
            ObtenerDatos.BodyEncoding = System.Text.Encoding.UTF8;

            ObtenerDatos.From = new System.Net.Mail.MailAddress(MAIL DENTRO DE COMILLAS);
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("MAIL", "CONTRASEÑA");
            //Puerto de gmail
            cliente.Port = 587;
            //seguridad 
            cliente.EnableSsl = true;
            //servidor de salida q usa gmail
            cliente.Host = "smtp.gmail.com"; // mail.dominio.com


            DialogResult r = MessageBox.Show("Desea enviar mensaje??", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                Alerta.Visible = true;
                MessageBox.Show("Mensaje enviado");
            }

            else if (r == DialogResult.Cancel) // MessageBox.Show("Mensaje enviado","HOLA");
            {
                MessageBox.Show("Envio de mensaje cancelado");
            }
            try
            {
                cliente.Send(ObtenerDatos);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar ");
            }

            ValidarCampos();
        }       
             private bool ValidarCampos()
             { 
                  bool ok = true;
                  if (btnPara.Text == "")
                  {
                        ok = false;
                        errorProvider1.SetError(btnPara, "Ingresar nombre");

                  }
                    return ok;
             }

        private void EnvioDeMail_Load(object sender, EventArgs e)
        {

        }

        private void ImpotarImagen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Archivos PNG (*.png)|*.png|Todos los archivos (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
        }
    }
}
