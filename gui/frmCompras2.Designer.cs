using System.Drawing;
using System.Windows.Forms;

namespace gui
{
    partial class frmCompras2
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
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCompras
            // 
            this.gridCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCompras.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Location = new System.Drawing.Point(43, 188);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.Size = new System.Drawing.Size(483, 220);
            this.gridCompras.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnCerrar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 30;
            this.btnCerrar.Location = new System.Drawing.Point(3, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraTitulo.Controls.Add(this.label3);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(589, 63);
            this.barraTitulo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Historial De Compras";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargar.Location = new System.Drawing.Point(105, 414);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(83, 39);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // fecha1
            // 
            this.fecha1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fecha1.Location = new System.Drawing.Point(44, 140);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(205, 20);
            this.fecha1.TabIndex = 13;
            // 
            // fecha2
            // 
            this.fecha2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fecha2.Location = new System.Drawing.Point(325, 140);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(212, 20);
            this.fecha2.TabIndex = 14;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.btnFiltrar.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltrar.IconSize = 25;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(364, 414);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 39);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(322, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de inicio:";
            // 
            // frmCompras2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(589, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.gridCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompras2";
            this.Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridCompras;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private Panel barraTitulo;
        private Label label3;
        private Button btnCargar;
        private DateTimePicker fecha1;
        private DateTimePicker fecha2;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private Label label1;
        private Label label2;
    }
}