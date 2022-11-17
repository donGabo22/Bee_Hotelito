using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using EstandaresdeCalidad_Hotel.negocio;

namespace EstandaresdeCalidad_Hotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre,Contraseña FROM Registros WHERE Nombre='" + txbUsuario.Text + "' AND Contraseña='" + txbContraseña.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("Usuario o contraseña valido");

                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña invalido");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public string user;
        public string pass;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            user = "admin";
            pass = "1234";
            if (txbUsuario.Text == user && txbContraseña.Text == pass)
            {
                Form_Dashboard f = new Form_Dashboard();
                f.Show();
                this.Hide();
                f.Show();
            }
            else
            {
                if (txbUsuario.Text != user)
                {
                    MessageBox.Show("Usuario Invalido", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbUsuario.Text = "";
                    txbUsuario.Focus();
                }
                if (txbContraseña.Text != pass)
                {
                    MessageBox.Show("Contraseña Invalido", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbContraseña.Text = "";
                    txbContraseña.Focus();
                }
            }


            
           


        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
