using BILL;
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
    public partial class frmCompras2 : Form
    {
        PruebasServices bll;
        public frmCompras2()
        {
            InitializeComponent();
            bll = new PruebasServices();
            fecha1.ValueChanged += DateTimePicker_ValueChanged;
            fecha2.ValueChanged += DateTimePicker_ValueChanged;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            gridCompras.DataSource = bll.getCompras("get_compras");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFecha();
        }

        private void FiltrarPorFecha()
        {
            DateTime fechaInicio = fecha1.Value.Date;
            DateTime fechaFin = fecha2.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser después de la fecha de fin.", "Error de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var comprasTable =  bll.getCompras("get_compras");
            var rows = comprasTable.AsEnumerable()
                                .Where(row => (DateTime)row["Fecha_Factura"] >= fechaInicio && (DateTime)row["Fecha_Factura"] <= fechaFin);

            if (rows.Any())
            {
                gridCompras.DataSource = rows.CopyToDataTable();
            }
            else
            {
                gridCompras.DataSource = comprasTable.Clone(); // Clear the grid if no rows match
            }
        }
    
    }
}
