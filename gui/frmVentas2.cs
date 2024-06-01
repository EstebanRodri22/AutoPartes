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
    public partial class frmVentas2 : Form
    {
        private PruebasServices bll;
        public frmVentas2()
        {
            InitializeComponent();
            bll = new PruebasServices();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridVentas.DataSource = bll.getVentas("get_ventas");
        }
    }
}
