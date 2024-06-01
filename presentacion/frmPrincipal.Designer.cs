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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            barraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            panelContenedor = new Panel();
            lblHora = new Label();
            lblFecha = new Label();
            pictureBox2 = new PictureBox();
            panelProductoSubMenu = new Panel();
            btnRegistrarProducto = new FontAwesome.Sharp.IconButton();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            menuVertical = new Panel();
            panel1 = new Panel();
            btnInventario = new FontAwesome.Sharp.IconButton();
            panelVentaSubMenu = new Panel();
            btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            btnBuscarVentas = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            panelCompraSubMenu = new Panel();
            btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            btnBuscarCompras = new FontAwesome.Sharp.IconButton();
            btnCompras = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelProductoSubMenu.SuspendLayout();
            menuVertical.SuspendLayout();
            panel1.SuspendLayout();
            panelVentaSubMenu.SuspendLayout();
            panelCompraSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
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
            btnRestaurar.Location = new Point(891, 7);
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
            btnMaximizar.Location = new Point(891, 7);
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
            btnCerrar.Location = new Point(922, 7);
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
            btnMinimizar.Location = new Point(860, 7);
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
            panelContenedor.Controls.Add(lblHora);
            panelContenedor.Controls.Add(lblFecha);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(247, 38);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(703, 562);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.FromArgb(49, 66, 82);
            lblHora.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.LightGray;
            lblHora.Location = new Point(496, 482);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(151, 39);
            lblHora.TabIndex = 0;
            lblHora.Text = "21:49:45";
            lblHora.Click += lblHora_Click;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(474, 521);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(173, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "sabado, 25 de Mayo 2024";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(278, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panelProductoSubMenu
            // 
            panelProductoSubMenu.Controls.Add(btnRegistrarProducto);
            panelProductoSubMenu.Controls.Add(btnBuscarProducto);
            panelProductoSubMenu.Dock = DockStyle.Top;
            panelProductoSubMenu.Location = new Point(0, 57);
            panelProductoSubMenu.Name = "panelProductoSubMenu";
            panelProductoSubMenu.Size = new Size(230, 84);
            panelProductoSubMenu.TabIndex = 7;
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.Dock = DockStyle.Top;
            btnRegistrarProducto.FlatAppearance.BorderSize = 0;
            btnRegistrarProducto.FlatStyle = FlatStyle.Flat;
            btnRegistrarProducto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarProducto.ForeColor = Color.White;
            btnRegistrarProducto.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnRegistrarProducto.IconColor = Color.White;
            btnRegistrarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarProducto.IconSize = 40;
            btnRegistrarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarProducto.Location = new Point(0, 41);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Padding = new Padding(35, 0, 20, 0);
            btnRegistrarProducto.Size = new Size(230, 41);
            btnRegistrarProducto.TabIndex = 4;
            btnRegistrarProducto.Text = "Registrar";
            btnRegistrarProducto.UseVisualStyleBackColor = true;
            btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Dock = DockStyle.Top;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarProducto.IconColor = Color.White;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 40;
            btnBuscarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarProducto.Location = new Point(0, 0);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Padding = new Padding(35, 0, 20, 0);
            btnBuscarProducto.Size = new Size(230, 41);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Consultar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // menuVertical
            // 
            menuVertical.AutoScroll = true;
            menuVertical.BackColor = Color.FromArgb(26, 32, 40);
            menuVertical.Controls.Add(panel1);
            menuVertical.Controls.Add(panel2);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 38);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(247, 562);
            menuVertical.TabIndex = 1;
            menuVertical.Paint += menuVertical_Paint;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(panelVentaSubMenu);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(panelCompraSubMenu);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(panelProductoSubMenu);
            panel1.Controls.Add(btnProductos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 416);
            panel1.TabIndex = 1;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 11.25F);
            btnInventario.ForeColor = Color.White;
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnInventario.IconColor = Color.White;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.IconSize = 40;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 440);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(10, 0, 20, 0);
            btnInventario.Size = new Size(230, 57);
            btnInventario.TabIndex = 12;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // panelVentaSubMenu
            // 
            panelVentaSubMenu.Controls.Add(btnRegistrarVenta);
            panelVentaSubMenu.Controls.Add(btnBuscarVentas);
            panelVentaSubMenu.Dock = DockStyle.Top;
            panelVentaSubMenu.Location = new Point(0, 339);
            panelVentaSubMenu.Name = "panelVentaSubMenu";
            panelVentaSubMenu.Size = new Size(230, 101);
            panelVentaSubMenu.TabIndex = 11;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Dock = DockStyle.Top;
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarVenta.ForeColor = Color.White;
            btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnRegistrarVenta.IconColor = Color.White;
            btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarVenta.IconSize = 40;
            btnRegistrarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarVenta.Location = new Point(0, 41);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Padding = new Padding(35, 0, 20, 0);
            btnRegistrarVenta.Size = new Size(230, 41);
            btnRegistrarVenta.TabIndex = 4;
            btnRegistrarVenta.Text = "REGISTRAR";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarVentas
            // 
            btnBuscarVentas.Dock = DockStyle.Top;
            btnBuscarVentas.FlatAppearance.BorderSize = 0;
            btnBuscarVentas.FlatStyle = FlatStyle.Flat;
            btnBuscarVentas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarVentas.ForeColor = Color.White;
            btnBuscarVentas.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarVentas.IconColor = Color.White;
            btnBuscarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarVentas.IconSize = 40;
            btnBuscarVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarVentas.Location = new Point(0, 0);
            btnBuscarVentas.Name = "btnBuscarVentas";
            btnBuscarVentas.Padding = new Padding(35, 0, 20, 0);
            btnBuscarVentas.Size = new Size(230, 41);
            btnBuscarVentas.TabIndex = 3;
            btnBuscarVentas.Text = "CONSULTAR";
            btnBuscarVentas.UseVisualStyleBackColor = true;
            btnBuscarVentas.Click += btnBuscarVentas_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 11.25F);
            btnVentas.ForeColor = Color.White;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnVentas.IconColor = Color.White;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.IconSize = 40;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 282);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 20, 0);
            btnVentas.Size = new Size(230, 57);
            btnVentas.TabIndex = 10;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelCompraSubMenu
            // 
            panelCompraSubMenu.Controls.Add(btnRegistrarCompra);
            panelCompraSubMenu.Controls.Add(btnBuscarCompras);
            panelCompraSubMenu.Dock = DockStyle.Top;
            panelCompraSubMenu.Location = new Point(0, 198);
            panelCompraSubMenu.Name = "panelCompraSubMenu";
            panelCompraSubMenu.Size = new Size(230, 84);
            panelCompraSubMenu.TabIndex = 9;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Dock = DockStyle.Top;
            btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            btnRegistrarCompra.FlatStyle = FlatStyle.Flat;
            btnRegistrarCompra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarCompra.ForeColor = Color.White;
            btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnRegistrarCompra.IconColor = Color.White;
            btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarCompra.IconSize = 40;
            btnRegistrarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarCompra.Location = new Point(0, 41);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Padding = new Padding(35, 0, 20, 0);
            btnRegistrarCompra.Size = new Size(230, 41);
            btnRegistrarCompra.TabIndex = 4;
            btnRegistrarCompra.Text = "REGISTRAR";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnBuscarCompras
            // 
            btnBuscarCompras.Dock = DockStyle.Top;
            btnBuscarCompras.FlatAppearance.BorderSize = 0;
            btnBuscarCompras.FlatStyle = FlatStyle.Flat;
            btnBuscarCompras.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarCompras.ForeColor = Color.White;
            btnBuscarCompras.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarCompras.IconColor = Color.White;
            btnBuscarCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCompras.IconSize = 40;
            btnBuscarCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarCompras.Location = new Point(0, 0);
            btnBuscarCompras.Name = "btnBuscarCompras";
            btnBuscarCompras.Padding = new Padding(35, 0, 20, 0);
            btnBuscarCompras.Size = new Size(230, 41);
            btnBuscarCompras.TabIndex = 3;
            btnBuscarCompras.Text = "CONSULTAR";
            btnBuscarCompras.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 11.25F);
            btnCompras.ForeColor = Color.White;
            btnCompras.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnCompras.IconColor = Color.White;
            btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompras.IconSize = 40;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 141);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(10, 0, 20, 0);
            btnCompras.Size = new Size(230, 57);
            btnCompras.TabIndex = 8;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F);
            btnProductos.ForeColor = Color.White;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Automobile;
            btnProductos.IconColor = Color.White;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.IconSize = 40;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(10, 0, 20, 0);
            btnProductos.Size = new Size(230, 57);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Repuestos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 146);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ELPEÑON;
            pictureBox1.Location = new Point(36, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(panelContenedor);
            panelPrincipal.Controls.Add(menuVertical);
            panelPrincipal.Controls.Add(barraTitulo);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(950, 600);
            panelPrincipal.TabIndex = 3;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelProductoSubMenu.ResumeLayout(false);
            menuVertical.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelVentaSubMenu.ResumeLayout(false);
            panelCompraSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel barraTitulo;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private Panel menuVertical;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private Panel panelPrincipal;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private Panel panelProductoSubMenu;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnRegistrarProducto;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnInventario;
        private Panel panelVentaSubMenu;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnBuscarVentas;
        private FontAwesome.Sharp.IconButton btnVentas;
        private Panel panelCompraSubMenu;
        private FontAwesome.Sharp.IconButton btnRegistrarCompra;
        private FontAwesome.Sharp.IconButton btnBuscarCompras;
    }
}