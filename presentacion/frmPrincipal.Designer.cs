﻿namespace presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            barraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            menuVertical = new Panel();
            pictureBox1 = new PictureBox();
            btnInventario = new Button();
            btnVentas = new Button();
            btnCompras = new Button();
            btnProductos = new Button();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            barraTitulo.Controls.Add(btnRestaurar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(950, 38);
            barraTitulo.TabIndex = 1;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.res;
            btnRestaurar.Location = new Point(882, 7);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 4;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.ErrorImage = null;
            btnMaximizar.Image = Properties.Resources.maxi;
            btnMaximizar.Location = new Point(882, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(0, 80, 200);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(913, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(0, 80, 200);
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.ErrorImage = null;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(851, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Controls.Add(menuVertical);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 38);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(950, 562);
            panelContenedor.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(577, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // menuVertical
            // 
            menuVertical.AutoScroll = true;
            menuVertical.BackColor = Color.FromArgb(26, 32, 40);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Controls.Add(btnInventario);
            menuVertical.Controls.Add(btnVentas);
            menuVertical.Controls.Add(btnCompras);
            menuVertical.Controls.Add(btnProductos);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(253, 562);
            menuVertical.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 391);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(250, 40);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 314);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 40);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(3, 243);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(244, 40);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(3, 173);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(244, 40);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(panelContenedor);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel barraTitulo;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private Panel menuVertical;
        private PictureBox pictureBox1;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnCompras;
        private Button btnProductos;
        private PictureBox pictureBox2;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
    }
}