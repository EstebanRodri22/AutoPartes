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
    public partial class frmRegistrarRepuestos : Form
    {
        ComboBoxServices comboBoxServices = new ComboBoxServices();
        AutomovilServices automovilServices = new AutomovilServices();
        RepuestosServices repuestosServices = new RepuestosServices();
        List<Automovil> automoviles;
        public frmRegistrarRepuestos()
        {
            InitializeComponent();
            entornoMecanicoTrue();
            entonoElectricoFalse();
  
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rbtnPiezaElectrica.Checked)
            {
                PiezaElectrica piezaElectrica = new PiezaElectrica();
                piezaElectrica.voltaje = txtVoltaje.Text;
                piezaElectrica.resistencia = txtResistencia.Text;
                piezaElectrica.Precio = int.Parse(txtPrecio.Text);
                piezaElectrica.cantidad = int.Parse(txtCantidad.Text);
                piezaElectrica.Detalles = txtDetalle.Text;
                piezaElectrica.categoria = (Categoria) cmbCategoria.SelectedItem;
                piezaElectrica.automovil = (Automovil)cmbAutomoviles.SelectedItem;
                try
                {
                    var messaje = repuestosServices.registrarPiezaElectrica(piezaElectrica, "INSERTAR_PIEZAELECTRICA");
                    MessageBox.Show(messaje);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (rbtnPiezaMecanica.Checked)
            {
                PiezaMecanica piezaMecanica = new PiezaMecanica();     
                piezaMecanica.Durabilidad = txtDurabilidad.Text;
                piezaMecanica.Dimensiones = txtDimensiones.Text;
                piezaMecanica.Material = txtMaterial.Text;
                piezaMecanica.Precio = int.Parse(txtPrecio.Text);
                piezaMecanica.cantidad = int.Parse(txtCantidad.Text);
                piezaMecanica.Detalles = txtDetalle.Text;
                piezaMecanica.categoria = (Categoria)cmbCategoria.SelectedItem;
                piezaMecanica.automovil = (Automovil)cmbAutomoviles.SelectedItem;

                try
                {
                    MessageBox.Show(repuestosServices.registrarPiezaMecanica(piezaMecanica, "INSERTAR_PIEZA_MECANICA"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rbtnPiezaMecanica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPiezaMecanica.Checked)
            {
                entornoMecanicoTrue();
                entonoElectricoFalse();
            }
            
        }

        private void rbtnPiezaElectrica_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnPiezaElectrica.Checked)
            {
                entornoMecanicoFalse();
                entonoElectricoTrue();      

            }
           
        }
        private void cargarCategrias()
        {
            List<Categoria> categorias;
            categorias = comboBoxServices.GetCategorias();

            cmbCategoria.DisplayMember = "descripcion";
            cmbCategoria.ValueMember = "id_tipodocumento";
            cmbCategoria.DataSource = categorias;
        }

        private void entonoElectricoFalse()
        {
            txtResistencia.Visible = false;
            txtVoltaje.Visible = false;
            lblResistencia.Visible = false;
            lblVoltaje.Visible = false;
        }

        private void entonoElectricoTrue()
        {
            txtResistencia.Visible = true;
            txtVoltaje.Visible = true;
            lblResistencia.Visible = true;
            lblVoltaje.Visible = true;
        }

        private void entornoMecanicoTrue()
        { 
            txtDimensiones.Visible = true;
            txtDurabilidad.Visible = true;
            txtMaterial.Visible = true;
            lblDimensiones.Visible = true;
            lblDurabilidad.Visible = true;
            lblMaterial.Visible = true;
        }

        private void entornoMecanicoFalse()
        {
            txtDimensiones.Visible = false;
            txtDurabilidad.Visible = false;
            txtMaterial.Visible = false;
            lblDimensiones.Visible = false;
            lblDurabilidad.Visible = false;
            lblMaterial.Visible = false;
        }

        private void cargarAutomoviles()
        {
        
            automoviles = automovilServices.GetAutomovils();

            cmbAutomoviles.DisplayMember = "Display";  // Usa la propiedad combinada
            cmbAutomoviles.ValueMember = "Id";  // Usa el ID del vehículo como valor
            cmbAutomoviles.DataSource = automoviles;
        }

        private void frmRegistrarRepuestos_Load(object sender, EventArgs e)
        {
            cargarCategrias();
            cargarAutomoviles();
        }
    }
}
