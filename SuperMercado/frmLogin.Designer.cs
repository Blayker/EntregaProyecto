namespace SuperMercado
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Carrusel = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnIniciar = new CustomControls.RJControls.RJButton();
            btnSalir = new CustomControls.RJControls.RJButton();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Carrusel).BeginInit();
            SuspendLayout();
            // 
            // Carrusel
            // 
            Carrusel.Image = (Image)resources.GetObject("Carrusel.Image");
            Carrusel.Location = new Point(3, 4);
            Carrusel.Name = "Carrusel";
            Carrusel.Size = new Size(843, 954);
            Carrusel.SizeMode = PictureBoxSizeMode.StretchImage;
            Carrusel.TabIndex = 8;
            Carrusel.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1006, 97);
            label1.Name = "label1";
            label1.Size = new Size(572, 57);
            label1.TabIndex = 11;
            label1.Text = "Bienvenido a HiperShop";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1050, 198);
            label4.Name = "label4";
            label4.Size = new Size(429, 44);
            label4.TabIndex = 12;
            label4.Text = "Por favor, Identifiquese";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(992, 492);
            label3.Name = "label3";
            label3.Size = new Size(227, 44);
            label3.TabIndex = 15;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(992, 353);
            label2.Name = "label2";
            label2.Size = new Size(150, 44);
            label2.TabIndex = 14;
            label2.Text = "Usuario";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.MediumSlateBlue;
            btnIniciar.BackgroundColor = Color.MediumSlateBlue;
            btnIniciar.BorderColor = Color.PaleVioletRed;
            btnIniciar.BorderRadius = 20;
            btnIniciar.BorderSize = 0;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(957, 707);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(334, 91);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextColor = Color.White;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MediumSlateBlue;
            btnSalir.BackgroundColor = Color.MediumSlateBlue;
            btnSalir.BorderColor = Color.PaleVioletRed;
            btnSalir.BorderRadius = 20;
            btnSalir.BorderSize = 0;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1327, 707);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(334, 91);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.TextColor = Color.White;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += rjButton2_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(995, 571);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(296, 48);
            txtContraseña.TabIndex = 19;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(995, 431);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 48);
            txtUsuario.TabIndex = 20;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(20F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1749, 943);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Carrusel);
            Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)Carrusel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox Carrusel;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private CustomControls.RJControls.RJButton btnIniciar;
        private CustomControls.RJControls.RJButton btnSalir;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}