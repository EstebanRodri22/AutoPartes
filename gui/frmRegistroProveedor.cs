using BILL;
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

namespace gui
{
    public partial class frmRegistroProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        ProveedorServices services = new ProveedorServices();

        public frmRegistroProveedor()
        {
            InitializeComponent();
            toolStripStatusLabel1.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    //toolStripStatusLabel1.Text = "Imagen cargada: " + Path.GetFileName(rutaImagen);
                    toolStripStatusLabel1.Visible = true;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
              

            proveedor.identificacion = txtIdentificacion.Text;
            proveedor.primerNombre = txtNombres.Text;
            proveedor.primerApellido = txtApellidos.Text;
            proveedor.telefono = txtTelefono.Text;

            var message = services.insertarProveedor(proveedor, "insertar_proveedor");

            MessageBox.Show(message);


        }
    }
}
