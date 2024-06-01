using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace gui
{
    partial class frmRegistroProveedor2
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
            btnCargarImage = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
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
            txtIdentificacion.Location = new Point(186, 95);
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
            btnCancelar.Location = new Point(339, 307);
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
            btnGuardar.Location = new Point(186, 307);
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
            cmbTipoDocumento.Location = new Point(186, 59);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(247, 23);
            cmbTipoDocumento.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(99, 219);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 18;
            label5.Text = "Telefono :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(99, 182);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 17;
            label4.Text = "Apellidos :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.Location = new Point(99, 140);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 16;
            label3.Text = "Nombres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(69, 97);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 14;
            label2.Text = "Identificacion :";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(186, 176);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(247, 23);
            txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(186, 134);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(247, 23);
            txtNombres.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(186, 219);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 23);
            txtTelefono.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(49, 61);
            label6.Name = "label6";
            label6.Size = new Size(124, 17);
            label6.TabIndex = 20;
            label6.Text = "Tipo Documento :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(490, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnCargarImage
            // 
            btnCargarImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCargarImage.IconColor = Color.Black;
            btnCargarImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCargarImage.Location = new Point(186, 264);
            btnCargarImage.Name = "btnCargarImage";
            btnCargarImage.Size = new Size(247, 23);
            btnCargarImage.TabIndex = 22;
            btnCargarImage.Text = "Cargar Imagen";
            btnCargarImage.UseVisualStyleBackColor = true;
            btnCargarImage.Click += btnCargarImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F);
            label7.Location = new Point(118, 267);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 23;
            label7.Text = "Firma :";
            label7.Click += label7_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 353);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(665, 22);
            statusStrip1.TabIndex = 24;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmRegistroProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 375);
            Controls.Add(statusStrip1);
            Controls.Add(label7);
            Controls.Add(btnCargarImage);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btnCargarImage;
        private Label label7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}