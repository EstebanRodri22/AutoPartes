namespace presentacion
{
    partial class frmRegistroProveedor
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
            barraTitulo = new Panel();
            btnCerrar = new Button();
            label1 = new Label();
            txtIdentificacion = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbTipoDocumento = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(26, 32, 40);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Controls.Add(label1);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(665, 38);
            barraTitulo.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(627, -3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(38, 38);
            btnCerrar.TabIndex = 10;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 9;
            label1.Text = "Registro Proveedor";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(187, 65);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(247, 23);
            txtIdentificacion.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 122, 204);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F);
            btnCancelar.Location = new Point(453, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F);
            btnGuardar.Location = new Point(251, 289);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 34);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "CEDULA", "TARGETA IDENTIDAD", "CEDULA EXTRANGERA" });
            cmbTipoDocumento.Location = new Point(187, 229);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(247, 23);
            cmbTipoDocumento.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(53, 191);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 18;
            label5.Text = "TELEFONO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(50, 152);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 17;
            label4.Text = "APELLIDOS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.Location = new Point(50, 110);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 16;
            label3.Text = "NOMBRES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(50, 67);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 14;
            label2.Text = "IDENTIFICACION:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(187, 150);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(247, 23);
            txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(187, 104);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(247, 23);
            txtNombres.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(187, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 23);
            txtTelefono.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(50, 231);
            label6.Name = "label6";
            label6.Size = new Size(127, 17);
            label6.TabIndex = 20;
            label6.Text = "TIPO DOCUMENTO:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icono_cliente;
            pictureBox1.Location = new Point(470, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // frmRegistroProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 349);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(txtIdentificacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistroProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegistroProveedor";
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel barraTitulo;
        private TextBox txtIdentificacion;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbTipoDocumento;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtTelefono;
        private Label label6;
        private Button btnCerrar;
        private PictureBox pictureBox1;
    }
}