using EstandaresdeCalidad_Hotel.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstandaresdeCalidad_Hotel.negocio
{
    public partial class Form_Factura2 : Form
    {
        public int id = 0;
        public StreamWriter escritor;
        public Form_Factura2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Dashboard form_Dashboard = new Form_Dashboard();
            form_Dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busca al huesped por nombre y elabora factura", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void dgvabeja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNombre.Enabled = false;
            txbApellido.Enabled = false;
            txbTelefono.Enabled = false;
            txbTipoHab.Enabled = false;
            txbNumHab.Enabled = false;
            txbPrecio.Enabled = false;
            dtpSalida.Enabled = false;
            id = Convert.ToInt32(dgvabeja.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dgvabeja.CurrentRow.Cells[1].Value.ToString();
            txbApellido.Text = dgvabeja.CurrentRow.Cells[2].Value.ToString();
            txbTelefono.Text = dgvabeja.CurrentRow.Cells[3].Value.ToString();
            txbTipoHab.Text = dgvabeja.CurrentRow.Cells[4].Value.ToString();
            txbNumHab.Text = dgvabeja.CurrentRow.Cells[5].Value.ToString();
            txbPrecio.Text = dgvabeja.CurrentRow.Cells[6].Value.ToString();
            txbDispo.Text = dgvabeja.CurrentRow.Cells[7].Value.ToString();
            dtpEntrada.Value = Convert.ToDateTime(dgvabeja.CurrentRow.Cells[8].Value.ToString());
            dtpSalida.Value = Convert.ToDateTime(dgvabeja.CurrentRow.Cells[9].Value.ToString());
            txbMonto.Text = dgvabeja.CurrentRow.Cells[10].Value.ToString();

        }
        public void clear()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbTelefono.Text = "";
            txbTipoHab.Text = "";
            txbNumHab.Text = "";
            txbPrecio.Text = "";
            txbDispo.Text = "";
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today;
            txbMonto.Text = "";


        }

        private void Form_Factura2_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var abeja = context.Reservacion4.ToList();
                dgvabeja.DataSource = abeja;
                context.SaveChanges(); //aqui
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var Abeja1 = context.Reservacion4.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvabeja.DataSource = Abeja1;
            }

        }
        public Boolean confirmacionDatos()
        {
            if (txbNombre.Text == "" || txbApellido.Text == "" || txbTelefono.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button3_Click(object sender, EventArgs e) //boton calcular
        {

            if (confirmacionDatos() == true)
            {
                recibo2();

            }
            else
            {
                MessageBox.Show("faltan campos de llenar");
            }
        }
        public void recibo2()
        {
            try
            {
                saveFileDialog1.ShowDialog();
                //creamos el archivo de texto en la ruta del save dialog
                escritor = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < 1; i++)
                {
                    escritor.WriteLine("********BEE HOTEL****************************");

                    escritor.WriteLine("Fecha:" + dtpEntrada.Value.ToString() +
                                    "\n Nombre:" + txbNombre.Text + " " + txbApellido.Text +
                                    "\n TIPO DE HABITACIÓN:" + txbTipoHab.Text +
                                    "\n NUMERO DE HABITACIÓN: " + txbNumHab.Text +
                                    "\n\n Total a Pagar: " + txbMonto.Text +
                                    "\n Fecha de salida: " + dtpSalida.Value.ToString() +
                                    "\n Bee hotel S.A de C.V 2022 © " +
                                    "\n Consulta nuestros terminos y condiciones en: https://Beehotel.com/politicas-de-servicio/" +
                                    "\n ************************************************");
                }
                escritor.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }
    }
}

        
    
