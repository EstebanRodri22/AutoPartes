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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           gridCompras.DataSource = bll.getCompras("get_compras");
        }
    }
}
