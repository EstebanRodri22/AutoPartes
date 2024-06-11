using BILL;
using presentacion;
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
    public partial class frmRepuestos : Form
    {

        private PruebasServices bll;

        public frmRepuestos()
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
            gridRepuestos.DataSource = bll.getRepuestos("get_repuestos");
        }
    }
}
