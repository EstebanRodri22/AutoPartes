namespace presentacion
{
    partial class frmOpcionClientes
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Century Gothic", 9.75F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(74, 45);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(169, 86);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "NUEVO CLIENTE";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Font = new Font("Century Gothic", 9.75F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(308, 45);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(169, 86);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "CLIENTE EXISTENTE";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.ForeColor = SystemColors.ControlText;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = SystemColors.ControlText;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 19;
            btnCerrar.Location = new Point(530, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 19);
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmOpcionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 186);
            Controls.Add(btnCerrar);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOpcionClientes";
            Text = "frmOpcionClientes";
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
    }
}