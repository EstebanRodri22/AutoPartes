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
using System.Windows.Media.Media3D;

namespace gui
{
    public partial class frmRegistrarCompra : Form
    {
        private Proveedor proveedor;
        private Automovil automovil;

        ProveedorServices proveedorServices;
        AutomovilServices automovilServices;

        public frmRegistrarCompra()
        {
            InitializeComponent();
            proveedorServices = new ProveedorServices();
            automovilServices = new AutomovilServices();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            frmRegistrarVehiculo registrarVehiculo = new frmRegistrarVehiculo(automovil);
            if (registrarVehiculo.ShowDialog() == DialogResult.OK)
            {
                automovil = registrarVehiculo.automovil;
            }
        }



        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmRegistroProveedor registrarProveedor = new frmRegistroProveedor(proveedor);
            if (registrarProveedor.ShowDialog() == DialogResult.OK)
            {
                proveedor = registrarProveedor.proveedor;
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (proveedor == null || automovil == null)
            {
                MessageBox.Show("Debe registrar un proveedor y un vehículo antes de guardar la compra.");
                return;
            }

            // Crear una instancia de compra
            var compra = new Compras();
            compra.proveedor = proveedor;
            compra.automovil = automovil;
            compra.observaciones = txtObservaciones.Text;
            compra.ValorFactura = double.Parse(txtValor.Text);
            // Llamar al método para guardar en la base de datos
            ComprasServices services = new ComprasServices();

            try
            {
                automovilServices.insertarAutomovil(automovil);
                proveedorServices.insertarProveedor(proveedor, "insertar_proveedor");
                services.InsertarCompra(compra, "insertar_compras");

                MessageBox.Show("Compra registrada exitosamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al insertar la compra {ex}");
            }

            
        }

        private void frmRegistrarCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
