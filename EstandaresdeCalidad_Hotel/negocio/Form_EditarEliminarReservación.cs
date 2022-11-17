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

    public partial class Form_EditarEliminarReservación : Form
    {
        public int id = 0;

        public Form_EditarEliminarReservación()
        {
            InitializeComponent();
        }

        private void Form_EditarEliminarReservación_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var abeja = context.Reservacion4.ToList();
                dgvabeja.DataSource = abeja;
                context.SaveChanges(); //aqui
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    if (id != 0)
                    {
                        var abeja = context.Reservacion4.First(x => x.Id == id);
                        if (abeja != null)
                        {
                            context.Remove(abeja);
                            context.SaveChanges();

                        }
                    }
                }
                using (var context = new ApplicationDbContext())
                {
                    var abeja = context.Reservacion4.ToList();
                    dgvabeja.DataSource = abeja;
                    context.SaveChanges(); //aqui
                    clear();
                }
            }
            catch (Exception) {
                MessageBox.Show("RESERVACIONES VACIAS");
                Form_Dashboard excForm = new Form_Dashboard();
                this.Hide();
                excForm.Show();
            }
        }//fin de metodo

        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (confirmacionDatos() == true)
            { 
                using (var context = new ApplicationDbContext())
                {
                    if (id != 0)
                    {
                        var abeja = context.Reservacion4.First(x => x.Id == id);
                        if (abeja != null)
                        {
                            abeja.Nombre = txbNombre.Text;
                            abeja.Apellido = txbApellido.Text;
                            abeja.Telefono = txbTelefono.Text;
                            abeja.TipoHabitacion = txbTipoHab.Text;
                            abeja.Precio = Convert.ToDouble(txbPrecio.Text);
                            abeja.Status = txbDispo.Text;
                            abeja.FechaEntrada = dtpEntrada.Value;
                            abeja.FechaSalida = dtpSalida.Value;
                            abeja.MontoFinal = Convert.ToDouble(txbMonto.Text);

                            context.SaveChanges();
                            clear();

                        }
                    }
                }
                using (var context = new ApplicationDbContext())
                {
                    var abeja = context.Reservacion4.ToList();
                    dgvabeja.DataSource = abeja;
                    context.SaveChanges(); //aqui

                }


            }
            else
            {
                MessageBox.Show("hay campos sin llenar");

            }











        }

        private void dgvabeja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (var context = new ApplicationDbContext())
            //{
            //    var abeja = context.Reservacion4.ToList();
            //    dgvabeja.DataSource = abeja;
            //    context.SaveChanges(); //aqui
            //}

            txbNombre.Enabled = true;
            txbApellido.Enabled = true;
            txbTelefono.Enabled = true;
            txbTipoHab.Enabled = false;
            txbNumHab.Enabled =false;
            txbPrecio.Enabled = false;
            id = Convert.ToInt32(dgvabeja.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text =   dgvabeja.CurrentRow.Cells[1].Value.ToString();
            txbApellido.Text = dgvabeja.CurrentRow.Cells[2].Value.ToString();
            txbTelefono.Text = dgvabeja.CurrentRow.Cells[3].Value.ToString();
            txbTipoHab.Text = dgvabeja.CurrentRow.Cells[4].Value.ToString();
            txbNumHab.Text= dgvabeja.CurrentRow.Cells[5].Value.ToString();
            txbPrecio.Text= dgvabeja.CurrentRow.Cells[6].Value.ToString();
            txbDispo.Text = dgvabeja.CurrentRow.Cells[7].Value.ToString();
            dtpEntrada.Value = Convert.ToDateTime(dgvabeja.CurrentRow.Cells[8].Value.ToString());
            dtpSalida.Value = Convert.ToDateTime(dgvabeja.CurrentRow.Cells[9].Value.ToString());
            txbMonto.Text = dgvabeja.CurrentRow.Cells[10].Value.ToString();
           
        } //fin de metodo
        
        public void clear() {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbTelefono.Text = "";
            txbTipoHab.Text = "";
            txbNumHab.Text = "";
            txbPrecio.Text = "";
            txbDispo.Text = "";
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today;
            txbMonto.Text="";


        }
        private void dtpSalida_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txbMonto.Text = "";
                if (dtpSalida.Value < dtpEntrada.Value)
                {
                    MessageBox.Show("No puede ser menor la fecha de salida que la de entrada");
                    dtpSalida.Value = DateTime.Today;
                    txbMonto.Text = "";
                }
                else
                {
                    TimeSpan ts = dtpSalida.Value - dtpEntrada.Value;
                    int dias = (int)ts.TotalDays;
                    double monto = dias * (Convert.ToDouble(txbPrecio.Text));
                    //                double monto = dias * (double.Parse(txbPrecio.Text))-(double.Parse(txbPrecio.Text));
                    txbMonto.Text = monto.ToString();
                }
            }
            catch (Exception) {
                MessageBox.Show("LOS CAMPOS ESTAN VACIOS. SELECCIONA UNA RESERVACIÓN");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form_Dashboard form_Dashboard = new Form_Dashboard();
            this.Hide();
            form_Dashboard.Show();
        }

        public Boolean confirmacionDatos()
        {
            if (txbNombre.Text == "" || txbApellido.Text == "" || txbTelefono.Text == "" || txbTipoHab.Text=="" ||txbNumHab.Text==""|| txbMonto.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Modificar la información del huesped, su tiempo de estancia procede a picar la base de datos y sobreescribe la información en los cambios de texto " +
             "\n favor de confirmar los cambios antes de finalizar en el boton de modificar" +
             "\n Cuando se halla cumplido el plazo favor de liberar una ocupacion seleccionando al huesped y borrando el campo en el boton borrar", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    }
    }
