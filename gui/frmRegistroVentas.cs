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
    public partial class frmRegistroVentas : Form
    {
        RepuestosServices repuestosServices = new RepuestosServices();
        VentasServices ventasServices = new VentasServices();
        public frmRegistroVentas()
        {
            InitializeComponent();
            txtBuscarRepuesto.KeyDown -= txtBuscarRepuesto_KeyDown;
            txtBuscarRepuesto.KeyDown += txtBuscarRepuesto_KeyDown;
            cargarColumnas();
        }

        private void cargarColumnas()
        {
            if (dgvMostrarRepuestos.Columns.Count == 0)
            {
                dgvMostrarRepuestos.Columns.Add("ID_Repuesto", "ID_Repuesto");
                dgvMostrarRepuestos.Columns.Add("categoria", "categoria");
                dgvMostrarRepuestos.Columns.Add("precio", "precio");
                dgvMostrarRepuestos.Columns.Add("detalle", "detalle");
                dgvMostrarRepuestos.Columns.Add("stock", "stock");

            }
        }
        private void txtBuscarRepuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Cuando el usuario presiona Enter, busca el repuesto y muestra los detalles en el DataGridView
                //string idRepuesto = txtBuscarRepuesto.Text;
                //DataTable dt = repuestosServices.GetRepuestoById(idRepuesto);
                //dgvMostrarRepuestos.DataSource = dt;
                try
                {
                    string idRepuesto = txtBuscarRepuesto.Text; // Reemplaza esto con tu id_repuesto
                    DataTable dt = repuestosServices.GetRepuestoById(idRepuesto);

                    MessageBox.Show($"Filas obtenidas: {dt.Rows.Count}");
                    // Agrega cada fila del DataTable al DataGridView
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = dgvMostrarRepuestos.Rows.Add();
                        DataGridViewRow dataGridViewRow = dgvMostrarRepuestos.Rows[index];
                        dataGridViewRow.Cells["ID_Repuesto"].Value = row["ID_Repuesto"];
                        dataGridViewRow.Cells["categoria"].Value = row["name_categoria"];
                        dataGridViewRow.Cells["precio"].Value = row["Precio"];
                        dataGridViewRow.Cells["Detalle"].Value = row["Detalle"];
                        dataGridViewRow.Cells["Stock"].Value = row["Stock"];   
             
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            try
            {
                // Generar un nuevo número de factura
                string noFactura = ventasServices.obtenerNoFactura();

                // Insertar una nueva venta en la tabla Ventas y obtener el ID de la nueva venta
                venta.NoFactura = noFactura;
                venta.Cantidad = 2;
                venta.ValorFactura = 1200;
                venta.Cliente.identificacion = "1135";
                MessageBox.Show(ventasServices.registrarVentas(venta, "PR_Insertar_ventas") );

                foreach (DataGridViewRow row in dgvMostrarRepuestos.Rows)
                {
                    if (row.Cells["ID_Repuesto"].Value != null)
                    {
                        string idRepuesto = row.Cells["ID_Repuesto"].Value.ToString();

                        // Actualizar la columna VentaID en la tabla Repuestos
                        repuestosServices.actualizarNoFactura(idRepuesto, noFactura);
                    }
                }

                MessageBox.Show("Venta guardada y repuestos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la venta: {ex.Message}");
            }
        }
    }
}
