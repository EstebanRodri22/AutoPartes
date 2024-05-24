namespace presentacion
{
    partial class frmRegistroCliente
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
            barraTitulo = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(26, 32, 40);
            barraTitulo.Controls.Add(iconPictureBox1);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(482, 35);
            barraTitulo.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(26, 32, 40);
            iconPictureBox1.ForeColor = Color.DimGray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconPictureBox1.IconColor = Color.DimGray;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 23;
            iconPictureBox1.Location = new Point(455, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(24, 23);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F);
            label1.Location = new Point(37, 104);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "IDENTIFICACION:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(37, 145);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 3;
            label2.Text = "NOMBRES:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.Location = new Point(37, 189);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 5;
            label3.Text = "APELLIDOS:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 23);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(37, 232);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 7;
            label4.Text = "TELEFONO:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(37, 62);
            label5.Name = "label5";
            label5.Size = new Size(127, 17);
            label5.TabIndex = 10;
            label5.Text = "TIPO DOCUMENTO:";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(105, 281);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(116, 41);
            iconButton1.TabIndex = 11;
            iconButton1.Text = "REGISTRAR";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(265, 281);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(116, 41);
            iconButton2.TabIndex = 12;
            iconButton2.Text = "ELIMINAR";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // frmRegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 343);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistroCliente";
            Text = "frmRegistroVentas";
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel barraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}