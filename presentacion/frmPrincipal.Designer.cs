namespace presentacion
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
            menuVertical = new Panel();
            btnProductos = new Button();
            pictureBox1 = new PictureBox();
            barraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnSlide = new PictureBox();
            panelContenedor = new Panel();
            btnCompras = new Button();
            btnVentas = new Button();
            btnInventario = new Button();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            SuspendLayout();
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(0, 122, 204);
            menuVertical.Controls.Add(btnInventario);
            menuVertical.Controls.Add(btnVentas);
            menuVertical.Controls.Add(btnCompras);
            menuVertical.Controls.Add(btnProductos);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(250, 650);
            menuVertical.TabIndex = 0;
            menuVertical.MouseDown += menuVertical_MouseDown;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.productos1;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 173);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(250, 40);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ELPEÑON;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.WhiteSmoke;
            barraTitulo.Controls.Add(btnRestaurar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnSlide);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(250, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1050, 50);
            barraTitulo.TabIndex = 1;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.maximizar;
            btnRestaurar.Location = new Point(994, 0);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestaurar.TabIndex = 4;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.maximizar;
            btnMaximizar.Location = new Point(994, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.DimGray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close_Icon;
            btnCerrar.Location = new Point(1025, 0);
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
            btnMinimizar.BackColor = Color.DimGray;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Minimize_Icon;
            btnMinimizar.Location = new Point(963, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSlide
            // 
            btnSlide.BackColor = Color.DimGray;
            btnSlide.Cursor = Cursors.Hand;
            btnSlide.Image = Properties.Resources.slide;
            btnSlide.Location = new Point(0, 9);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(35, 35);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 0;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.WhiteSmoke;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1050, 600);
            panelContenedor.TabIndex = 2;
            // 
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = Properties.Resources.ventas;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 243);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(250, 40);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.ventas;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 314);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 40);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = Properties.Resources.inventario;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 391);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(250, 40);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(barraTitulo);
            Controls.Add(menuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuVertical;
        private Panel barraTitulo;
        private PictureBox btnSlide;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private Button btnProductos;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnCompras;
    }
}