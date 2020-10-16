using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp2
{
    public partial class Agregar : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-HU5GM1D\SQLEXPRESS;Initial Catalog=;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False ");

        public Agregar()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CLIENTES VALUES('" + txtNombre + "','" + txtApellido + "','" + txtMail + "', '" + txtArea + "')";
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Nuevo usuario agregado");
        }
        /*
        public void Mostrar()
        {
            conexion.Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CLIENTES";
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            Usuarios usu = new Usuarios();
            
            conexion.Close();
        }
        */
    }
}
