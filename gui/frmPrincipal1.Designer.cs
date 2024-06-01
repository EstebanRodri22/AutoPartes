using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace presentacion
{
    partial class frmPrincipal1 
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
            this.components = new System.ComponentModel.Container();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelProductoSubMenu = new System.Windows.Forms.Panel();
            this.btnRegistrarProducto = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.panelVentaSubMenu = new System.Windows.Forms.Panel();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.btnBuscarVentas = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelCompraSubMenu = new System.Windows.Forms.Panel();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCompras = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelProductoSubMenu.SuspendLayout();
            this.menuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelVentaSubMenu.SuspendLayout();
            this.panelCompraSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(814, 33);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(764, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(21, 22);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.ErrorImage = null;
            this.btnMaximizar.Location = new System.Drawing.Point(764, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(21, 22);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(790, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.ErrorImage = null;
            this.btnMinimizar.Location = new System.Drawing.Point(737, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(212, 33);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(602, 487);
            this.panelContenedor.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(422, 411);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(151, 39);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "21:49:45";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(405, 452);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "sabado, 25 de Mayo 2024";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(238, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelProductoSubMenu
            // 
            this.panelProductoSubMenu.Controls.Add(this.btnRegistrarProducto);
            this.panelProductoSubMenu.Controls.Add(this.btnBuscarProducto);
            this.panelProductoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductoSubMenu.Location = new System.Drawing.Point(0, 49);
            this.panelProductoSubMenu.Name = "panelProductoSubMenu";
            this.panelProductoSubMenu.Size = new System.Drawing.Size(195, 73);
            this.panelProductoSubMenu.TabIndex = 7;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarProducto.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnRegistrarProducto.IconColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarProducto.IconSize = 40;
            this.btnRegistrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(0, 36);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Padding = new System.Windows.Forms.Padding(30, 0, 17, 0);
            this.btnRegistrarProducto.Size = new System.Drawing.Size(195, 36);
            this.btnRegistrarProducto.TabIndex = 4;
            this.btnRegistrarProducto.Text = "Registrar";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 40;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Padding = new System.Windows.Forms.Padding(30, 0, 17, 0);
            this.btnBuscarProducto.Size = new System.Drawing.Size(195, 36);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Consultar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.AutoScroll = true;
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.panel2);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 33);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(212, 487);
            this.menuVertical.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.panelVentaSubMenu);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.panelCompraSubMenu);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Controls.Add(this.panelProductoSubMenu);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 360);
            this.panel1.TabIndex = 1;
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 40;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 381);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnInventario.Size = new System.Drawing.Size(195, 49);
            this.btnInventario.TabIndex = 12;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // panelVentaSubMenu
            // 
            this.panelVentaSubMenu.Controls.Add(this.btnRegistrarVenta);
            this.panelVentaSubMenu.Controls.Add(this.btnBuscarVentas);
            this.panelVentaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentaSubMenu.Location = new System.Drawing.Point(0, 293);
            this.panelVentaSubMenu.Name = "panelVentaSubMenu";
            this.panelVentaSubMenu.Size = new System.Drawing.Size(195, 88);
            this.panelVentaSubMenu.TabIndex = 11;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.IconSize = 40;
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(0, 36);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Padding = new System.Windows.Forms.Padding(30, 0, 17, 0);
            this.btnRegistrarVenta.Size = new System.Drawing.Size(195, 36);
            this.btnRegistrarVenta.TabIndex = 4;
            this.btnRegistrarVenta.Text = "REGISTRAR";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarVentas.FlatAppearance.BorderSize = 0;
            this.btnBuscarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVentas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVentas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarVentas.IconColor = System.Drawing.Color.White;
            this.btnBuscarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarVentas.IconSize = 40;
            this.btnBuscarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVentas.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Padding = new System.Windows.Forms.Padding(30, 0, 17, 0);
            this.btnBuscarVentas.Size = new System.Drawing.Size(195, 36);
            this.btnBuscarVentas.TabIndex = 3;
            this.btnBuscarVentas.Text = "CONSULTAR";
            this.btnBuscarVentas.UseVisualStyleBackColor = true;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 40;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 244);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnVentas.Size = new System.Drawing.Size(195, 49);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelCompraSubMenu
            // 
            this.panelCompraSubMenu.Controls.Add(this.btnRegistrarCompra);
            this.panelCompraSubMenu.Controls.Add(this.btnBuscarCompras);
            this.panelCompraSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompraSubMenu.Location = new System.Drawing.Point(0, 171);
            this.panelCompraSubMenu.Name = "panelCompraSubMenu";
            this.panelCompraSubMenu.Size = new System.Drawing.Size(195, 73);
            this.panelCompraSubMenu.TabIndex = 9;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 40;
            this.btnRegistrarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(0, 36);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Padding = new System.Windows.Forms.Padding(30, 0, 17, 0);
            this.btnRegistrarCompra.Size = new System.Drawing.Size(195, 36);
            this.btnRegistrarCompra.TabIndex = 4;
            this.btnRegistrarCompra.Text = "REGISTRAR";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnBuscarCompras
            // 
            this.btnBuscarCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarCompras.FlatAppearance.BorderSize = 0;
            this.btnBuscarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCompras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCompras.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCompras.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCompras.IconColor = System.Drawing.Color.White;
            this.btnBuscarCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCompras.IconSize = 40;
            this.btnBuscarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCompras.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarCompras.Name = "btnBuscarCompras";
            this.btnBuscarCompras.Padding = new System.Windows.Forms.Padding(30, 0, 17, 0);
            this.btnBuscarCompras.Size = new System.Drawing.Size(195, 36);
            this.btnBuscarCompras.TabIndex = 3;
            this.btnBuscarCompras.Text = "CONSULTAR";
            this.btnBuscarCompras.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 40;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 122);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnCompras.Size = new System.Drawing.Size(195, 49);
            this.btnCompras.TabIndex = 8;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 40;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnProductos.Size = new System.Drawing.Size(195, 49);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Repuestos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 127);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelContenedor);
            this.panelPrincipal.Controls.Add(this.menuVertical);
            this.panelPrincipal.Controls.Add(this.barraTitulo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(814, 520);
            this.panelPrincipal.TabIndex = 3;
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            // 
            // frmPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 520);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(814, 520);
            this.Name = "frmPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelProductoSubMenu.ResumeLayout(false);
            this.menuVertical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelVentaSubMenu.ResumeLayout(false);
            this.panelCompraSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

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