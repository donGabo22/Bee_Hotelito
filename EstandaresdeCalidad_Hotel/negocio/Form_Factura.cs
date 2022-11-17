using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstandaresdeCalidad_Hotel.negocio
{
    public partial class Form_Factura : Form
    {
        SqlConnection conexion2 = new SqlConnection("server=DESKTOP-JUGSUS0;database=EstandaresCalidadHotel;Integrated Security = true");

        public Form_Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNombre.Text = "";
            txbNumH.Text = "";
            txbPrecioH.Text="";
            txbMonto.Text = "";
            txbTipo.Text = "";


            comboBox2.Text = "#";
            comboBox2.Items.Clear();
            SqlCommand comando = new SqlCommand("select Nombre,Apellido,TipoHabitacion,NumeroHabitacion,NumeroHabitacion,Precio,FechaEntrada,FechaSalida,MontoFinal from Reservacion4", conexion2);
            conexion2.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox2.Items.Add(" " + registro["Nombre"].ToString() + " " + registro["Apellido"]);

                // comboBox2.Items.Clear();
                txbNombre.Text = " " + registro["Nombre"].ToString() + " " + registro["Apellido"];
                txbNumH.Text = " " + registro["NumeroHabitacion"].ToString();
                txbPrecioH.Text = " " + registro["Precio"].ToString();
                txbTipo.Text = " " + registro["TipoHabitacion"].ToString();
                txbMonto.Text = "$$ " + registro["MontoFinal"].ToString() + " MXN";
                dtpSalida.Text = " " + registro["FechaSalida"].ToString();//?

            }
            conexion2.Close();
        }

        private void Form_Factura_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select Nombre,Apellido,TipoHabitacion,NumeroHabitacion,NumeroHabitacion,Precio,FechaEntrada,FechaSalida,MontoFinal from Reservacion4", conexion2);
            conexion2.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox2.Items.Add(" " + registro["Nombre"].ToString() + " " + registro["Apellido"]);
                txbNombre.Text = "";
                txbNumH.Text = "";
                txbPrecioH.Text = "";
                txbMonto.Text = "";
                txbTipo.Text = "";
            }
            conexion2.Close();
        }
    }
    }
