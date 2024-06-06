using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BILL;

namespace gui
{
    public partial class frmRegistrarVehiculo : Form
    {
        ComboBoxServices comboBoxServices = new ComboBoxServices();
        AutomovilServices automovilServices = new AutomovilServices();
        Automovil automovil = new Automovil();
        Marca marca = new Marca();

        public frmRegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarImage_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta del archivo seleccionado
                    string rutaImagen = openFileDialog.FileName;

                    // Carga la imagen en un PictureBox o en otro control según tus necesidades
                   // toolStripStatusLabel1.Text = "Imagen cargada: " + Path.GetFileName(rutaImagen);
                    toolStripStatusLabel1.Visible = true;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                automovil.Placa = txtPlaca.Text;
                automovil.Modelo = txtModelo.Text;
                automovil.VIN = txtVin.Text;
                automovil.Marca = (Marca)cmbMarca.SelectedItem;

                var resultado = automovilServices.insertarAutomovil(automovil);
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
            List<Marca> MarcasList;
            MarcasList = comboBoxServices.GetMarcas();

            cmbMarca.DisplayMember = "NOMBRE_MARCA";
            cmbMarca.ValueMember = "id_marca";
            cmbMarca.DataSource = MarcasList;
        }
    }
}
