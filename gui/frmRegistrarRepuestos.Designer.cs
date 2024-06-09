using System.Drawing;
using System.Windows.Forms;

namespace gui
{
    partial class frmRegistrarRepuestos
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
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.cmbAutomoviles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPiezaElectrica = new System.Windows.Forms.RadioButton();
            this.rbtnPiezaMecanica = new System.Windows.Forms.RadioButton();
            this.grBoxMecanica = new System.Windows.Forms.GroupBox();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.lblVoltaje = new System.Windows.Forms.Label();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.lblDurabilidad = new System.Windows.Forms.Label();
            this.txtVoltaje = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.txtDurabilidad = new System.Windows.Forms.TextBox();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grBoxMecanica.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraTitulo.Controls.Add(this.label6);
            this.barraTitulo.Controls.Add(this.iconPictureBox1);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(599, 29);
            this.barraTitulo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(187, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registro Repuesto";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(572, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 27);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(76, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 94);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(116, 135);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(43, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(116, 179);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(185, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio :";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(116, 219);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(185, 20);
            this.txtDetalle.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(22, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(116, 52);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(185, 21);
            this.cmbCategoria.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.Location = new System.Drawing.Point(177, 303);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 36);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(46, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbAutomoviles
            // 
            this.cmbAutomoviles.FormattingEnabled = true;
            this.cmbAutomoviles.Location = new System.Drawing.Point(116, 258);
            this.cmbAutomoviles.Name = "cmbAutomoviles";
            this.cmbAutomoviles.Size = new System.Drawing.Size(185, 21);
            this.cmbAutomoviles.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(22, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Automovil :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPiezaElectrica);
            this.groupBox1.Controls.Add(this.rbtnPiezaMecanica);
            this.groupBox1.Location = new System.Drawing.Point(387, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Producto";
            // 
            // rbtnPiezaElectrica
            // 
            this.rbtnPiezaElectrica.AutoSize = true;
            this.rbtnPiezaElectrica.Location = new System.Drawing.Point(30, 43);
            this.rbtnPiezaElectrica.Name = "rbtnPiezaElectrica";
            this.rbtnPiezaElectrica.Size = new System.Drawing.Size(95, 17);
            this.rbtnPiezaElectrica.TabIndex = 1;
            this.rbtnPiezaElectrica.TabStop = true;
            this.rbtnPiezaElectrica.Text = "Pieza Electrica";
            this.rbtnPiezaElectrica.UseVisualStyleBackColor = true;
            this.rbtnPiezaElectrica.CheckedChanged += new System.EventHandler(this.rbtnPiezaElectrica_CheckedChanged);
            // 
            // rbtnPiezaMecanica
            // 
            this.rbtnPiezaMecanica.AutoSize = true;
            this.rbtnPiezaMecanica.Checked = true;
            this.rbtnPiezaMecanica.Location = new System.Drawing.Point(30, 20);
            this.rbtnPiezaMecanica.Name = "rbtnPiezaMecanica";
            this.rbtnPiezaMecanica.Size = new System.Drawing.Size(101, 17);
            this.rbtnPiezaMecanica.TabIndex = 0;
            this.rbtnPiezaMecanica.TabStop = true;
            this.rbtnPiezaMecanica.Text = "Pieza Mecanica";
            this.rbtnPiezaMecanica.UseVisualStyleBackColor = true;
            this.rbtnPiezaMecanica.CheckedChanged += new System.EventHandler(this.rbtnPiezaMecanica_CheckedChanged);
            // 
            // grBoxMecanica
            // 
            this.grBoxMecanica.Controls.Add(this.lblResistencia);
            this.grBoxMecanica.Controls.Add(this.lblMaterial);
            this.grBoxMecanica.Controls.Add(this.txtResistencia);
            this.grBoxMecanica.Controls.Add(this.lblVoltaje);
            this.grBoxMecanica.Controls.Add(this.lblDimensiones);
            this.grBoxMecanica.Controls.Add(this.lblDurabilidad);
            this.grBoxMecanica.Controls.Add(this.txtVoltaje);
            this.grBoxMecanica.Controls.Add(this.txtMaterial);
            this.grBoxMecanica.Controls.Add(this.txtDimensiones);
            this.grBoxMecanica.Controls.Add(this.txtDurabilidad);
            this.grBoxMecanica.Location = new System.Drawing.Point(321, 132);
            this.grBoxMecanica.Name = "grBoxMecanica";
            this.grBoxMecanica.Size = new System.Drawing.Size(266, 207);
            this.grBoxMecanica.TabIndex = 16;
            this.grBoxMecanica.TabStop = false;
            // 
            // lblResistencia
            // 
            this.lblResistencia.AutoSize = true;
            this.lblResistencia.Location = new System.Drawing.Point(98, 111);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(62, 13);
            this.lblResistencia.TabIndex = 3;
            this.lblResistencia.Text = "Resistencia";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(109, 126);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 5;
            this.lblMaterial.Text = "Material";
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(80, 127);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.Size = new System.Drawing.Size(100, 20);
            this.txtResistencia.TabIndex = 1;
            // 
            // lblVoltaje
            // 
            this.lblVoltaje.AutoSize = true;
            this.lblVoltaje.Location = new System.Drawing.Point(109, 28);
            this.lblVoltaje.Name = "lblVoltaje";
            this.lblVoltaje.Size = new System.Drawing.Size(39, 13);
            this.lblVoltaje.TabIndex = 2;
            this.lblVoltaje.Text = "Voltaje";
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.Location = new System.Drawing.Point(93, 71);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(67, 13);
            this.lblDimensiones.TabIndex = 4;
            this.lblDimensiones.Text = "Dimensiones";
            // 
            // lblDurabilidad
            // 
            this.lblDurabilidad.AutoSize = true;
            this.lblDurabilidad.Location = new System.Drawing.Point(93, 16);
            this.lblDurabilidad.Name = "lblDurabilidad";
            this.lblDurabilidad.Size = new System.Drawing.Size(60, 13);
            this.lblDurabilidad.TabIndex = 3;
            this.lblDurabilidad.Text = "Durabilidad";
            // 
            // txtVoltaje
            // 
            this.txtVoltaje.Location = new System.Drawing.Point(80, 44);
            this.txtVoltaje.Name = "txtVoltaje";
            this.txtVoltaje.Size = new System.Drawing.Size(100, 20);
            this.txtVoltaje.TabIndex = 0;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(80, 142);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial.TabIndex = 2;
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Location = new System.Drawing.Point(80, 87);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(100, 20);
            this.txtDimensiones.TabIndex = 1;
            // 
            // txtDurabilidad
            // 
            this.txtDurabilidad.Location = new System.Drawing.Point(80, 32);
            this.txtDurabilidad.Name = "txtDurabilidad";
            this.txtDurabilidad.Size = new System.Drawing.Size(100, 20);
            this.txtDurabilidad.TabIndex = 0;
            // 
            // frmRegistrarRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 361);
            this.Controls.Add(this.grBoxMecanica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAutomoviles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarRepuestos";
            this.Text = "frmRegistroProducto";
            this.Load += new System.EventHandler(this.frmRegistrarRepuestos_Load);
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grBoxMecanica.ResumeLayout(false);
            this.grBoxMecanica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel barraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private TextBox txtID;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private TextBox txtDetalle;
        private Label label4;
        private Label label5;
        private ComboBox cmbCategoria;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private ComboBox cmbAutomoviles;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton rbtnPiezaElectrica;
        private RadioButton rbtnPiezaMecanica;
        private GroupBox grBoxMecanica;
        private Label lblDurabilidad;
        private TextBox txtMaterial;
        private TextBox txtDimensiones;
        private TextBox txtDurabilidad;
        private Label lblMaterial;
        private Label lblDimensiones;
        private Label lblResistencia;
        private Label lblVoltaje;
        private TextBox txtResistencia;
        private TextBox txtVoltaje;
    }
}