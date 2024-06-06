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
        public Proveedor proveedor { get; private set; }
        ProveedorServices services = new ProveedorServices();
        ComboBoxServices comboBoxServices = new ComboBoxServices();

        public frmRegistroProveedor(Proveedor proveedor2 = null)
        {
            InitializeComponent();
            cargarTipoDocumentos();
            toolStripStatusLabel1.Visible = false;
            if(proveedor2 != null)
            {
                proveedor = proveedor2;
                txtIdentificacion.Text = proveedor2.identificacion;
                txtNombres.Text = proveedor2.primerNombre;
                txtApellidos.Text = proveedor2.primerApellido;
                txtTelefono.Text = proveedor2.telefono;
                if (cmbTipoDocumento.Items.Count > 0)
                {
                    for (int i = 0; i < cmbTipoDocumento.Items.Count; i++)
                    {
                        TipoDocumento tipoDocumento = (TipoDocumento)cmbTipoDocumento.Items[i];
                        if (tipoDocumento.Id == proveedor2.TipoDocumento.Id)
                        {
                            cmbTipoDocumento.SelectedIndex = i;
                            break;
                        }
                    }
                }

            }
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
            if(proveedor == null)
            {
                proveedor = new Proveedor();
            }
                proveedor.identificacion = txtIdentificacion.Text;
                proveedor.primerNombre = txtNombres.Text;
                proveedor.primerApellido = txtApellidos.Text;
                proveedor.telefono = txtTelefono.Text;
                proveedor.TipoDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void cargarTipoDocumentos()
        {
            List<TipoDocumento> ListTiposDocumentos;
            ListTiposDocumentos = comboBoxServices.GetTipoDocumentos();

            cmbTipoDocumento.DisplayMember = "descripcion";
            cmbTipoDocumento.ValueMember = "id_tipodocumento";
            cmbTipoDocumento.DataSource = ListTiposDocumentos;
        }

        private void frmRegistroProveedor_load(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
