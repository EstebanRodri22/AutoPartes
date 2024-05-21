using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 600);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen != null)
            {
                LX = this.Location.X;
                LY = this.Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;               
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudo obtener la pantalla principal. Por favor, verifica tu configuración de pantalla.", "Error de Pantalla", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

        private Form? activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProductos());
        }
    }
}
