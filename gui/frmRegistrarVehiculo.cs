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
        public Automovil automovil { get; private set; }

        Marca marca = new Marca();

        public frmRegistrarVehiculo(Automovil automovil2 = null)
        {
            InitializeComponent();
            CargarMarcas();
            if (automovil2 != null)
            {
                automovil = automovil2;
                txtPlaca.Text = automovil2.Placa;                            
                txtModelo.Text = automovil2.Modelo;
                txtVin.Text = automovil2.VIN;

                if (cmbMarca.Items.Count > 0)
                {
                    for (int i = 0; i < cmbMarca.Items.Count; i++)
                    {
                        Marca marca = (Marca)cmbMarca.Items[i];
                        if (marca.Id == automovil2.Marca.Id)
                        {
                            cmbMarca.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                automovil = new Automovil();
            }
        
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtVin.Text = "";
            cmbMarca.Text = "";

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
            if (automovil == null)
            {
                automovil = new Automovil();
            }

            automovil.Placa = txtPlaca.Text;
            automovil.Modelo = txtModelo.Text;
            automovil.VIN = txtVin.Text;
            automovil.Marca = (Marca)cmbMarca.SelectedItem;
            this.DialogResult = DialogResult.OK;

            
            LimpiarCampos();

            this.Close();
        }

        private void LimpiarCampos()
        {
            
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtVin.Text = "";
            cmbMarca.SelectedItem = null; 
        }


        private void CargarMarcas()
        {
            // Cargar las marcas desde la base de datos o de donde sea necesario
            List<Marca> marcas = comboBoxServices.GetMarcas();

            // Configurar el ComboBox

            cmbMarca.DisplayMember = "NOMBRE_MARCA";
            cmbMarca.ValueMember = "id_marca";
            cmbMarca.DataSource = marcas;

        }

        private void frmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
