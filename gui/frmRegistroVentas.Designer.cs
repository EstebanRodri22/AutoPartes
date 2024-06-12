﻿namespace gui

{
    partial class frmRegistroVentas
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
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarRepuesto = new System.Windows.Forms.TextBox();
            this.dgvMostrarRepuestos = new System.Windows.Forms.DataGridView();
            this.btnCobrar = new FontAwesome.Sharp.IconButton();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarRepuestos)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrar.ErrorImage = global::gui.Properties.Resources.cancelar;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnCerrar.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 39;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            // 
            // txtBuscarRepuesto
            // 
            this.txtBuscarRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarRepuesto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBuscarRepuesto.Location = new System.Drawing.Point(41, 109);
            this.txtBuscarRepuesto.Name = "txtBuscarRepuesto";
            this.txtBuscarRepuesto.Size = new System.Drawing.Size(201, 20);
            this.txtBuscarRepuesto.TabIndex = 1;
            // 
            // dgvMostrarRepuestos
            // 
            this.dgvMostrarRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarRepuestos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMostrarRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarRepuestos.Location = new System.Drawing.Point(41, 147);
            this.dgvMostrarRepuestos.Name = "dgvMostrarRepuestos";
            this.dgvMostrarRepuestos.Size = new System.Drawing.Size(485, 166);
            this.dgvMostrarRepuestos.TabIndex = 3;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnCobrar.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCobrar.IconSize = 32;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.Location = new System.Drawing.Point(229, 341);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(95, 43);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(493, 351);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(70, 22);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "$ 00.0";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // barraTitulo
            // 
            this.barraTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraTitulo.Controls.Add(this.label4);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(593, 63);
            this.barraTitulo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(224, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Auto Partes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Digite ID repuesto a buscar :";
            // 
            // btnCliente
            // 
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCliente.IconColor = System.Drawing.Color.Black;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.Location = new System.Drawing.Point(460, 82);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(103, 37);
            this.btnCliente.TabIndex = 13;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // frmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(593, 414);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.dgvMostrarRepuestos);
            this.Controls.Add(this.txtBuscarRepuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroVentas";
            this.Text = "frmRegistroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarRepuestos)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtBuscarRepuesto;
        private System.Windows.Forms.DataGridView dgvMostrarRepuestos;
        private FontAwesome.Sharp.IconButton btnCobrar;

        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCliente;
    }
}