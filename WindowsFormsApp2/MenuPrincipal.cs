using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private int childFormNumber = 0;
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Formulario de enviar mail 
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnvioDeMail envioDeMail = new EnvioDeMail();
            envioDeMail.MdiParent = this;
            envioDeMail.Show();
            //envioDeMail.ShowDialog();
        }


        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            
        }
        public string Estado
        {
            get
            {
                return toolStripStatusLabel.Text;
            }
            set
            {
                toolStripStatusLabel.Text = value;
            }
        }
        private void calculadora2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculadora2 Calculadora2 = new calculadora2();
            Calculadora2.MdiParent = this;
            Calculadora2.Show();
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                menu2 menu2 = new menu2();
                menu2.MdiParent = this;
                menu2.Show();
        }

        private void calculadora2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.MdiParent = this;
            calculadora.Show();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video video = new video();
            video.MdiParent = this;
            video.Show();
        }
    }
}
