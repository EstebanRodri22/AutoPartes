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

namespace presentacion
{
    public partial class frmVentas : Form
    {
        //private PruebasServices bll;
        public frmVentas()
        {
            InitializeComponent();
         //   bll = new PruebasServices();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   gridVentas.DataSource = bll.getVentas();
        }
    }
}
