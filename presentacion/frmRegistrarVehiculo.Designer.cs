namespace presentacion
{
    partial class frmRegistrarVehiculo
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
            txtModelo = new TextBox();
            txtVin = new TextBox();
            txtPlaca = new TextBox();
            barraTitulo = new Panel();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbMarca = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(192, 106);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(269, 23);
            txtModelo.TabIndex = 1;
            // 
            // txtVin
            // 
            txtVin.Location = new Point(192, 150);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(269, 23);
            txtVin.TabIndex = 2;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(194, 63);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(269, 23);
            txtPlaca.TabIndex = 0;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(38, 45, 53);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Controls.Add(label1);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(705, 38);
            barraTitulo.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(664, -3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(38, 38);
            btnCerrar.TabIndex = 1;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(259, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 0;
            label1.Text = "Registro Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(82, 69);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 4;
            label2.Text = "PLACA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.Location = new Point(69, 108);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 5;
            label3.Text = "MODELO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(103, 150);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 6;
            label4.Text = "VIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(77, 194);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 7;
            label5.Text = "MARCA:";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "MAZDA", "TOYOTA" });
            cmbMarca.Location = new Point(192, 192);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(271, 23);
            cmbMarca.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F);
            btnGuardar.Location = new Point(192, 296);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 122, 204);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F);
            btnCancelar.Location = new Point(345, 296);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car;
            pictureBox1.Location = new Point(508, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(192, 254);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(271, 23);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "cargar imagen";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(34, 254);
            label6.Name = "label6";
            label6.Size = new Size(137, 17);
            label6.TabIndex = 13;
            label6.Tag = "";
            label6.Text = "Targeta Propiedad :";
            // 
            // frmRegistrarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 357);
            Controls.Add(label6);
            Controls.Add(iconButton1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbMarca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(barraTitulo);
            Controls.Add(txtPlaca);
            Controls.Add(txtVin);
            Controls.Add(txtModelo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarVehiculo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegistrarVehiculo";
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelo;
        private TextBox txtVin;
        private TextBox txtPlaca;
        private Panel barraTitulo;
        private Label label1;
        private Button btnCerrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbMarca;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
    }
}