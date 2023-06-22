namespace SuperMercado
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            submenu2 = new Panel();
            panel10 = new Panel();
            btnVender = new Button();
            panel12 = new Panel();
            submenu1 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            btnProductos = new Button();
            btnEmpleados = new Button();
            btnApagar = new PictureBox();
            panel4 = new Panel();
            btnCompras = new Button();
            panel1 = new Panel();
            btnRegistro = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            lblBienvenida = new Label();
            label2 = new Label();
            label1 = new Label();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            submenu2.SuspendLayout();
            submenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnApagar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(2574, 98);
            BarraTitulo.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(2297, 22);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(81, 69);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(2140, 22);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(81, 69);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(2297, 22);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(81, 69);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Visible = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(2442, 22);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(81, 69);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.BorderStyle = BorderStyle.FixedSingle;
            MenuVertical.Controls.Add(submenu2);
            MenuVertical.Controls.Add(submenu1);
            MenuVertical.Controls.Add(btnApagar);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnCompras);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnRegistro);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 98);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(452, 1001);
            MenuVertical.TabIndex = 1;
            // 
            // submenu2
            // 
            submenu2.Controls.Add(panel10);
            submenu2.Controls.Add(btnVender);
            submenu2.Controls.Add(panel12);
            submenu2.Location = new Point(16, 453);
            submenu2.Name = "submenu2";
            submenu2.Size = new Size(435, 114);
            submenu2.TabIndex = 21;
            submenu2.Visible = false;
            submenu2.Paint += submenu2_Paint;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 80, 200);
            panel10.Location = new Point(24, 21);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 68);
            panel10.TabIndex = 16;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(26, 32, 40);
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.ForeColor = SystemColors.Control;
            btnVender.Location = new Point(21, 24);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(398, 65);
            btnVender.TabIndex = 19;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click_1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(0, 80, 200);
            panel12.Location = new Point(24, 24);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 65);
            panel12.TabIndex = 20;
            // 
            // submenu1
            // 
            submenu1.Controls.Add(panel8);
            submenu1.Controls.Add(panel7);
            submenu1.Controls.Add(btnProductos);
            submenu1.Controls.Add(btnEmpleados);
            submenu1.Location = new Point(25, 666);
            submenu1.Name = "submenu1";
            submenu1.Size = new Size(426, 168);
            submenu1.TabIndex = 10;
            submenu1.Visible = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(15, 16);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 59);
            panel8.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(15, 96);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 56);
            panel7.TabIndex = 3;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(26, 32, 40);
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = SystemColors.Control;
            btnProductos.Location = new Point(12, 19);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(306, 56);
            btnProductos.TabIndex = 13;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(26, 32, 40);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = SystemColors.Control;
            btnEmpleados.Location = new Point(12, 96);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(306, 56);
            btnEmpleados.TabIndex = 11;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleadoporID_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.Image = (Image)resources.GetObject("btnApagar.Image");
            btnApagar.Location = new Point(197, 888);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(81, 69);
            btnApagar.SizeMode = PictureBoxSizeMode.Zoom;
            btnApagar.TabIndex = 4;
            btnApagar.TabStop = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(-4, 360);
            panel4.Name = "panel4";
            panel4.Size = new Size(21, 87);
            panel4.TabIndex = 8;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.FromArgb(26, 32, 40);
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = SystemColors.Control;
            btnCompras.Location = new Point(-7, 360);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(452, 87);
            btnCompras.TabIndex = 7;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(3, 573);
            panel1.Name = "panel1";
            panel1.Size = new Size(21, 87);
            panel1.TabIndex = 2;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(26, 32, 40);
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = SystemColors.Control;
            btnRegistro.Location = new Point(-1, 573);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(452, 87);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-51, -61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Controls.Add(lblBienvenida);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(452, 98);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(2122, 1001);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Century Gothic", 27.9000015F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenida.ForeColor = Color.DodgerBlue;
            lblBienvenida.Location = new Point(637, 72);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(556, 112);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Bienvenida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.1F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(1141, 281);
            label2.Name = "label2";
            label2.Size = new Size(241, 81);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.9000015F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(302, 256);
            label1.Name = "label1";
            label1.Size = new Size(258, 112);
            label1.TabIndex = 0;
            label1.Text = "hora";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2574, 1099);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicio";
            Text = "frmInicio";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            submenu2.ResumeLayout(false);
            submenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnApagar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox pictureBox1;
        private Button btnRegistro;
        private Panel panel4;
        private Button btnCompras;
        private Panel submenu1;
        private PictureBox btnApagar;
        private Button btnEmpleados;
        private Button btnProductos;
        private Panel panel8;
        private Panel panel7;
        private Panel submenu2;
        private Panel panel10;
        private Button btnVender;
        private Panel panel12;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblBienvenida;
    }
}