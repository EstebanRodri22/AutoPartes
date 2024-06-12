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
        
        DataTable dt;
        int cantidadRepuestos = 0;
        int sumarPrecios = 0;
        private Cliente cliente;
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
                dgvMostrarRepuestos.Columns.Add("cantidad", "cantidad");
                dgvMostrarRepuestos.Columns.Add("categoria", "categoria");
                dgvMostrarRepuestos.Columns.Add("precio", "precio");
                dgvMostrarRepuestos.Columns.Add("detalle", "detalle");

            }
        }
        private void txtBuscarRepuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string idRepuesto = txtBuscarRepuesto.Text; 
                    dt = repuestosServices.GetRepuestoById(idRepuesto, "obtener_repuesto");

                    cantidadRepuestos++;
                    // Agrega cada fila del DataTable al DataGridView
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = dgvMostrarRepuestos.Rows.Add();
                        DataGridViewRow dataGridViewRow = dgvMostrarRepuestos.Rows[index];
                        dataGridViewRow.Cells["ID_Repuesto"].Value = row["ID_Repuesto"];
                        dataGridViewRow.Cells["cantidad"].Value = row["cantidad"];
                        dataGridViewRow.Cells["categoria"].Value = row["name_categoria"];
                        dataGridViewRow.Cells["precio"].Value = row["Precio"];
                        dataGridViewRow.Cells["Detalle"].Value = row["Detalle"];

                        sumarPrecios += int.Parse(row["Precio"].ToString());

                        lblValorTotal.Text = sumarPrecios.ToString(); 
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
            if (cliente == null)
            {
                MessageBox.Show("Debe registrar un proveedor y un vehículo antes de guardar la compra.");
                return;
            }
            Ventas venta = new Ventas();
            List<RepuestoVendido> repuestos = new List<RepuestoVendido>();
            try
            {
                foreach (DataGridViewRow row in dgvMostrarRepuestos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        RepuestoVendido repuestoVendido = new RepuestoVendido
                        {
                            idRepuesto = Convert.ToString(row.Cells["Id_Repuesto"].Value),
                            cantidad = 1 // Aquí podrías obtener la cantidad según tu lógica
                        };

                        repuestos.Add(repuestoVendido);
                    }
                }
                // Insertar una nueva venta en la tabla Ventas y obtener el ID de la nueva venta
                venta.ValorFactura = sumarPrecios;
                venta.Cantidad = cantidadRepuestos;
                venta.Cliente.identificacion = cliente.identificacion;
                venta.InfoGarantia.FechaFin = DateTime.Now;
                venta.InfoGarantia.detalles = "probar 2";


                MessageBox.Show(ventasServices.registrarVentas(venta,repuestos, "PR_Insertar_ventas") );


                limpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la venta: {ex.Message}");
            }
        }

       public void limpiarTodo()
        {
            sumarPrecios = 0;
            cantidadRepuestos = 0;
            txtBuscarRepuesto.Clear();
            cliente = null;
            dt.Clear();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            frmRegistroCliente2 registrarCliente = new frmRegistroCliente2(cliente);
            if (registrarCliente.ShowDialog() == DialogResult.OK)
            {
                cliente = registrarCliente.cliente;
            }
        }


    }
}
