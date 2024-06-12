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
    public partial class frmRegistroCliente2 : Form
    {
        TipoDocumento tipoDocumento;
        ComboBoxServices comboBoxServices = new ComboBoxServices();
        public Cliente cliente { get; private set; }
        public frmRegistroCliente2(Cliente cliente2 = null)
        {
            InitializeComponent();
            cargarTipoDocumentos();
            tipoDocumento = new TipoDocumento();
            if (cliente != null)
            {
                cliente = cliente2;
                txtIdentificacion.Text = cliente2.identificacion;
                txtNombres.Text = cliente2.primerNombre;
                txtApellidos.Text = cliente2.primerApellido;
                txtTelefono.Text = cliente2.telefono;
                if (cmbTipoDocumento.Items.Count > 0)
                {
                    for (int i = 0; i < cmbTipoDocumento.Items.Count; i++)
                    {
                        TipoDocumento tipoDocumento = (TipoDocumento)cmbTipoDocumento.Items[i];
                        if (tipoDocumento.Id == cliente2.TipoDocumento.Id)
                        {
                            cmbTipoDocumento.SelectedIndex = i;
                            break;
                        }
                    }
                }

            }
        }

        private void cargarTipoDocumentos()
        {
            List<TipoDocumento> ListTiposDocumentos;
            ListTiposDocumentos = comboBoxServices.GetTipoDocumentos();

            cmbTipoDocumento.DisplayMember = "descripcion";
            cmbTipoDocumento.ValueMember = "id_tipodocumento";
            cmbTipoDocumento.DataSource = ListTiposDocumentos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new Cliente();
            }
            cliente.identificacion = txtIdentificacion.Text;
            cliente.primerNombre = txtNombres.Text;
            cliente.primerApellido = txtApellidos.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.TipoDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
