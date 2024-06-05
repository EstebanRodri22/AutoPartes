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
        TipoDocServices tipoDocServices = new TipoDocServices();

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
            try
            {
                proveedor.identificacion = txtIdentificacion.Text;
                proveedor.primerNombre = txtNombres.Text;
                proveedor.primerApellido = txtApellidos.Text;
                proveedor.telefono = txtTelefono.Text;
                proveedor.TipoDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;

                var resultado = services.insertarProveedor(proveedor, "insertar_proveedor");
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmRegistroProveedor_load(object sender, EventArgs e)
        {
            List<TipoDocumento> ListTiposDocumentos = new List<TipoDocumento>();
            ListTiposDocumentos = tipoDocServices.GetTipoDocumentos();

            cmbTipoDocumento.DisplayMember = "descripcion";
            cmbTipoDocumento.ValueMember = "id_tipodocumento";
            cmbTipoDocumento.DataSource = ListTiposDocumentos;
        }
    }
}
