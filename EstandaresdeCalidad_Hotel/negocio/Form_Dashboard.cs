using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstandaresdeCalidad_Hotel.negocio
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNuevaReservacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NuevaReservacion form_NuevaReservacion = new Form_NuevaReservacion();
            form_NuevaReservacion.Show();
        }

        private void btnEditarReservacion_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_EditarEliminarReservación form_EditarEliminarReservación = new Form_EditarEliminarReservación();
            form_EditarEliminarReservación.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Querry Software ® Proyecto Hecho por: \n " +
             "Gabriel Herández Diaz \n" +
             "Luis David Cazares Morales \n" +
             "Fabiola Rodriguez Salvador \n" +
             "Maestra: Leticia Lizárraga Velarde \n" +
             "Materia: Estándares de calidad de software", "Información", MessageBoxButtons.OK);
        }

        private void BtnDisponibilidad_Click(object sender, EventArgs e)
        {
          //  Form_Disponibilidad form_Disponibilidad = new Form_Disponibilidad();
            //form_Disponibilidad.Show();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BuscarCliente form_BuscarCliente = new Form_BuscarCliente();
            form_BuscarCliente.Show();
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Factura2 form_Factura = new Form_Factura2();
            form_Factura.Show();
        }
    }
}
