using BILL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaServices marcaServices = new MarcaServices();
                var marcas = marcaServices.ConsultarMarcas();

                dataGridView1.DataSource = marcas;

                MessageBox.Show("Conexión y recuperación de datos exitosas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error en la capa de presentación
                MessageBox.Show("Ocurrió un error: " + ex.Message + "\nDetalles: " + ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

