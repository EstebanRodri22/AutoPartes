using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BILL;
using ENTITY;

namespace gui
{
    public partial class frmAuromoviles : Form
    {
        AutomovilServices services = new AutomovilServices();
        InventarioServices inventarioServices = new InventarioServices();

        public frmAuromoviles()
        {
            InitializeComponent();
            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (dgvAutomov.SelectedRows.Count > 0)
            {
                if (dgvAutomov.CurrentRow.Cells["inventario"].Value.ToString() == "No se ha registrado")
                {
                    try
                    {
                        InventarioAutomovil inventario = new InventarioAutomovil();
                        inventario.placa = dgvAutomov.CurrentRow.Cells["Placa"].Value.ToString();
                        inventario.estadoInventario.EstadoDesmontaje = "en proceso";
                        inventario.estadoInventario.PiezaRecuperadas = 0;
                        var messaje = inventarioServices.registrarInventario(inventario, "insertar_inventario");
                        MessageBox.Show(messaje);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"problemas al ingresar el inventario{ex}");
                    }

                    

                }
                else
                {
                    MessageBox.Show("Ya esta en el inventario");
                }
            }
            else
            {
                MessageBox.Show("Seleecione una fila ");
            }
        }
        private void cargarAutomoviles()
        {
            var automovilesList = services.GetAutomovils();

           dgvAutomov.DataSource = automovilesList;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarAutomoviles();
        }
    }
}
