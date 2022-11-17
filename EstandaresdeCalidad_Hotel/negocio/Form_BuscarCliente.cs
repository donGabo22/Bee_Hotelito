using EstandaresdeCalidad_Hotel.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstandaresdeCalidad_Hotel.negocio
{
    public partial class Form_BuscarCliente : Form
    {
        public Form_BuscarCliente()
        {
            InitializeComponent();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var Abeja1 = context.Reservacion4.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvabeja.DataSource = Abeja1;
            }


        }

        private void dgvabeja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_BuscarCliente_Load(object sender, EventArgs e)
        {

            using (var context = new ApplicationDbContext())
            {
                var abeja = context.Reservacion4.ToList();
                dgvabeja.DataSource = abeja;
                context.SaveChanges(); //aqui
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llamando a cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Dashboard form_Dashboard = new Form_Dashboard();
            this.Hide();
            form_Dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En caso entregas de repartidores," +
                "\n ofertas y promociones de la cafeteria del hotel " +
                "Busca a clientes por nombre: y presiona el icono marcar para marcar al telefono de la habitación del hotel", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
