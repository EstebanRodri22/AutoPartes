namespace presentacion
{
    partial class frmRepuestos
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
            btnCerrar = new Label();
            dataGridView1 = new DataGridView();
            btnVenta = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(287, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "REPUESTOS";
            // 
            // btnCerrar
            // 
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.WhiteSmoke;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCerrar.Location = new Point(12, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(17, 19);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(573, 353);
            dataGridView1.TabIndex = 4;
            // 
            // btnVenta
            // 
            btnVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVenta.IconColor = Color.Black;
            btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVenta.Location = new Point(562, 489);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(114, 33);
            btnVenta.TabIndex = 5;
            btnVenta.Text = "Vender";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(126, 489);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(124, 33);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "eliminar";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(12, 489);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(108, 33);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "Editar";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(428, 489);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(105, 33);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "añadir";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "FILTRO";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(703, 562);
            Controls.Add(textBox1);
            Controls.Add(iconButton1);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(btnVenta);
            Controls.Add(dataGridView1);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label btnCerrar;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnVenta;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
    }
}