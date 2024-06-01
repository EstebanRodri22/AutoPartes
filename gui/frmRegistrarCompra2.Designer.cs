using System.Drawing;
using System.Windows.Forms;

namespace gui
{
    partial class frmRegistrarCompra2
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
            label1 = new Label();
            label2 = new Label();
            txtValor = new TextBox();
            txtCantidad = new TextBox();
            btnVehiculo = new Button();
            btnProveedor = new Button();
            btnRegistrar = new Button();
            btnCerrar = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.Location = new Point(107, 105);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(93, 201);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "cantidad";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(212, 105);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(381, 23);
            txtValor.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(212, 202);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(381, 23);
            txtCantidad.TabIndex = 1;
            // 
            // btnVehiculo
            // 
            btnVehiculo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVehiculo.ForeColor = SystemColors.ActiveCaptionText;
            btnVehiculo.ImageAlign = ContentAlignment.BottomRight;
            btnVehiculo.Location = new Point(416, 292);
            btnVehiculo.Name = "btnVehiculo";
            btnVehiculo.Size = new Size(159, 59);
            btnVehiculo.TabIndex = 3;
            btnVehiculo.Text = "VEHICULO";
            btnVehiculo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehiculo.UseVisualStyleBackColor = true;
            btnVehiculo.Click += btnVehiculo_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedor.Location = new Point(139, 292);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(159, 59);
            btnProveedor.TabIndex = 2;
            btnProveedor.Text = "PROVEEDOR";
            btnProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(261, 410);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(201, 37);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.AppWorkspace;
            btnCerrar.Location = new Point(12, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(34, 31);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 35);
            label3.Name = "label3";
            label3.Size = new Size(202, 22);
            label3.TabIndex = 6;
            label3.Text = "REGISTRAR COMPRA";
            // 
            // frmRegistrarCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 523);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnProveedor);
            Controls.Add(btnVehiculo);
            Controls.Add(txtCantidad);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarCompras";
            Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private TextBox txtCantidad;
        private Button btnVehiculo;
        private Button btnProveedor;
        private Button btnRegistrar;
        private PictureBox btnCerrar;
        private Label label3;
    }
}