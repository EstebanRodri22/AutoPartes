using System.Drawing;
using System.Windows.Forms;

namespace gui
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel1 = new Panel();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            linkContraseña = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnMinimizar
            // 

            btnMinimizar.Location = new Point(561, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(15, 15);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 

            btnCerrar.Location = new Point(582, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(15, 15);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 7;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 316);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(246, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(281, 20);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(246, 143);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(281, 20);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 11;
            label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(229, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(311, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkContraseña
            // 
            linkContraseña.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkContraseña.AutoSize = true;
            linkContraseña.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkContraseña.LinkColor = Color.DimGray;
            linkContraseña.Location = new Point(287, 281);
            linkContraseña.Name = "linkContraseña";
            linkContraseña.Size = new Size(199, 17);
            linkContraseña.TabIndex = 0;
            linkContraseña.TabStop = true;
            linkContraseña.Text = "¿Ha olvidado su contraseña?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(597, 316);
            Controls.Add(linkContraseña);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Button btnLogin;
        private LinkLabel linkContraseña;
    }
}