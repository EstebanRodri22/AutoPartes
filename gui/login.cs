using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BILL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "USERNAME")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "USERNAME";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "USERNAME")
            {
                if (txtPassword.Text != "PASSWORD")
                {
                    LoginServices loginServices = new LoginServices();
                    var validLogin = loginServices.loginUser(txtUsername.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        frmPrincipal1 frmPrincipal1 = new frmPrincipal1();
                        frmPrincipal1.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        txtPassword.Text = "PASSWORD";
                        txtPassword.UseSystemPasswordChar = false;
                        txtUsername.Focus();
                    }
                }
                else msgError("Please enter password.");


            }
            else msgError("Please enter username.");
            
           
        }

        public void msgError(string msg)
        {
            lblErrorMessage.Text = "       " + msg;
            lblErrorMessage.Visible = true;
        }

        

    }

    }

