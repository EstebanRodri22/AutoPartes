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
    public partial class frmOptionClientes2 : Form
    {
        Cliente Cliente;
        public frmOptionClientes2()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistroCliente2 frm = new frmRegistroCliente2(Cliente);
            frm.ShowDialog();
        }
    }
}
