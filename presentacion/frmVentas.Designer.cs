namespace presentacion
{
    partial class frmVentas
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
            gridVentas = new DataGridView();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            txtFiltro = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // gridVentas
            // 
            gridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVentas.Location = new Point(78, 51);
            gridVentas.Name = "gridVentas";
            gridVentas.Size = new Size(486, 324);
            gridVentas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.ForeColor = SystemColors.ControlText;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = SystemColors.ControlText;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 31;
            btnCerrar.Location = new Point(3, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 31);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 2;
            label1.Text = "HISTORIAL VENTAS";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(214, 399);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(238, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.Text = "BUSCAR";
            txtFiltro.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(78, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(button1);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(gridVentas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVentas";
            Text = "frmVentas";
            ((System.ComponentModel.ISupportInitialize)gridVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridVentas;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Button button1;
    }
}