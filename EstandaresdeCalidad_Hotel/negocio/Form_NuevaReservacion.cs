using EstandaresdeCalidad_Hotel.models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstandaresdeCalidad_Hotel.negocio
{
    public partial class Form_NuevaReservacion : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-JUGSUS0;database=EstandaresCalidadHotel;Integrated Security = true");
        public StreamWriter escritor;
        public Form_NuevaReservacion()
        {
            InitializeComponent();
        }

        private void Form_NuevaReservacion_Load(object sender, EventArgs e)
        {
            dtpFechaEntrada.Enabled = false;
            progressBar1.Value = 0;
            //            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            //          using (SqlConnection conexion = new SqlConnection(cnn))
            //      {

            //        }


        }

        public void limpiar()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbTelefono.Text = "";
            dtpFechaEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today;
        }
        public Boolean confirmacionDatos()
        {
            if (txbNombre.Text == "" || txbApellido.Text == "" || txbTelefono.Text == "" || comboBox1.Text == "Selecciona una opción" || comboBox2.Text == "#" || lbMonto.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            error();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "#";
            lbMonto.Text = "";
            comboBox2.Items.Clear();
            dtpSalida.Value = DateTime.Today;
            if (comboBox1.Text == "sencilla")
            {
                SqlCommand comando = new SqlCommand("select NumeroHabitacion, TipoHabitacion, precio from Habitacion where TipoHabitacion = 'sencilla'", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    // comboBox2.Items.Clear();
                    comboBox2.Items.Add(registro["NumeroHabitacion"].ToString());
                    lblPrecio.Text = "" + registro["precio"].ToString();
                }
                conexion.Close();
            }
            if (comboBox1.Text == "doble")
            {
                comboBox2.Text = "#";
                lbMonto.Text = "";
                comboBox2.Items.Clear();
                dtpSalida.Value = DateTime.Today;
                SqlCommand comando = new SqlCommand("select NumeroHabitacion, TipoHabitacion, precio from Habitacion where TipoHabitacion = 'doble'", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    // comboBox2.Items.Clear();
                    comboBox2.Items.Add(registro["NumeroHabitacion"].ToString());
                    lblPrecio.Text = "" + registro["precio"].ToString();
                }
                conexion.Close();
            }
            if (comboBox1.Text == "triple")
            {
                comboBox2.Text = "#";
                lbMonto.Text = "";
                comboBox2.Items.Clear();
                dtpSalida.Value = DateTime.Today;
                SqlCommand comando = new SqlCommand("select NumeroHabitacion, TipoHabitacion, precio from Habitacion where TipoHabitacion = 'triple'", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    comboBox2.Items.Add(registro["NumeroHabitacion"].ToString());
                    lblPrecio.Text = "" + registro["precio"].ToString();
                }
                conexion.Close();
            }
            if (comboBox1.Text == "suite")
            {
                comboBox2.Text = "#";
                lbMonto.Text = "";
                comboBox2.Items.Clear();
                dtpSalida.Value = DateTime.Today;
                SqlCommand comando = new SqlCommand("select NumeroHabitacion, TipoHabitacion, precio from Habitacion where TipoHabitacion = 'suite'", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    // comboBox2.Items.Clear();
                    comboBox2.Items.Add(registro["NumeroHabitacion"].ToString());
                    lblPrecio.Text = registro["precio"].ToString();
                }
                conexion.Close();
            }

        }

        private void progreso_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                progreso.Enabled = false;
                progreso.Stop();
                MessageBox.Show("Cliente registrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form_Dashboard frml = new Form_Dashboard();
                frml.Show();



            }
        }

        private void dtpSalida_CloseUp(object sender, EventArgs e)
        {
            try
            {
                lbMonto.Text = "";
                if (dtpSalida.Value < dtpFechaEntrada.Value)
                {
                    MessageBox.Show("No puede ser menor la fecha de salida que la de entrada");
                    dtpSalida.Value = DateTime.Today;
                    lbMonto.Text = "";
                }
                else
                {
                    TimeSpan ts = dtpSalida.Value - dtpFechaEntrada.Value;
                    int dias = (int)ts.TotalDays + 1;
                    int monto = dias * (int.Parse(lblPrecio.Text));
                    lbMonto.Text = monto.ToString();
                }
            }
            catch (Exception) {
                MessageBox.Show("POR FAVOR LLENE LOS DATOS EN ORDEN, HAY CAMPOS VACIOS");
            }
        }
        public void calcular()
        {
            if (confirmacionDatos() == true)
            {
                progreso.Enabled = true;
                progressBar1.Value = 0;
                using (var context = new ApplicationDbContext())
                {
                    //paso 1 crear el objeto 
                    var registro4 = new Reservaciones4();
                    registro4.Nombre = txbNombre.Text;
                    registro4.Apellido = txbApellido.Text;
                    registro4.Telefono = txbTelefono.Text;
                    registro4.TipoHabitacion = comboBox1.Text;
                    registro4.NumeroHabitacion = comboBox2.Text;
                    registro4.Precio = double.Parse(lblPrecio.Text);
                    registro4.Status = lblocupado.Text;
                    registro4.FechaEntrada = dtpFechaEntrada.Value.Date;
                    registro4.FechaSalida = dtpSalida.Value.Date;
                    registro4.MontoFinal = double.Parse(lbMonto.Text);


                    context.Reservacion4.Add(registro4);
                    context.SaveChanges();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("hay campos sin llenar");
            }
        }

        public void error()
        {
            using (var context = new ApplicationDbContext())
            {
                bool existe = context.Reservacion4.Any(x => x.NumeroHabitacion.Equals(comboBox2.Text));
                //preguntaremos si existe
                if (existe == true)
                {
                    //si no existe se agrega
                    MessageBox.Show("Habitación: " + comboBox2.Text + " Ocupado, porfavor compruebelo");
                    comboBox2.Text = "#";
                }
                else
                {
                    calcular();
                }

            }
        }








        public void recibo()
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    bool existe = context.Reservacion4.Any(x => x.NumeroHabitacion.Equals(comboBox2.Text));
                    //preguntaremos si existe
                    if (existe == true)
                    {
                        //si no existe se agrega
                        MessageBox.Show("Habitación: " + comboBox2.Text + " Ocupado, porfavor compruebelo");
                        comboBox2.Text = "#";
                    }
                    else     {
                        saveFileDialog1.ShowDialog();
                        //creamos el archivo de texto en la ruta del save dialog
                        escritor = new StreamWriter(saveFileDialog1.FileName);
                        for (int i = 0; i < 1; i++)
                        {
                            escritor.WriteLine("********BEE HOTEL****************************");

                            escritor.WriteLine("Fecha:" + dtpFechaEntrada.Value.ToString() +
                                            "\n Nombre:" + txbNombre.Text + " " + txbApellido.Text +
                                            "\n TIPO DE HABITACIÓN:" + comboBox1.Text +
                                            "\n NUMERO DE HABITACIÓN: " + comboBox2.Text +
                                            "\n\n Total a Pagar: " + lbMonto.Text +
                                            "\n Fecha de salida: " + dtpSalida.Value.ToString() +
                                            "\n Bee hotel S.A de C.V 2022 © " +
                                            "\n Consulta nuestros terminos y condiciones en: https://Beehotel.com/politicas-de-servicio/" +
                                            "\n ************************************************");
                        }
                        escritor.Close();
                    }
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {

            if (confirmacionDatos() == true)
            {
                btnCalcular.Enabled = true;
                recibo();
                
            }
            else
            {
                MessageBox.Show("faltan campos de llenar");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //     error();

            Form_Dashboard form_Dashboard = new Form_Dashboard();
            this.Hide();
            form_Dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registra nuevos huespedes llenando la información del huesped, genera ticket y luego procede a registrar" +
                "\n en caso de modificar estancia o datos del huesped dirigase a pestaña <Editar, Cancelar Reservación> ", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

