namespace SuperMercado
{
    partial class Empleados
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
            btnDelete = new Button();
            BtnModificar = new Button();
            txtNombre = new TextBox();
            txtEmpleadoID = new TextBox();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            btnAgregar = new Button();
            dgvEmpleados = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumSlateBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1686, 758);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(217, 58);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Borrar(Delete)";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.MediumSlateBlue;
            BtnModificar.Cursor = Cursors.Hand;
            BtnModificar.ForeColor = Color.White;
            BtnModificar.Location = new Point(1686, 624);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(217, 58);
            BtnModificar.TabIndex = 27;
            BtnModificar.Text = "Actualizar(Put)";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += btnModificar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.Hand;
            txtNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(527, 296);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 44);
            txtNombre.TabIndex = 26;
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Cursor = Cursors.Hand;
            txtEmpleadoID.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpleadoID.Location = new Point(527, 178);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(250, 44);
            txtEmpleadoID.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(1099, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 44);
            txtPassword.TabIndex = 24;
            // 
            // txtUser
            // 
            txtUser.Cursor = Cursors.Hand;
            txtUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(1099, 178);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(250, 44);
            txtUser.TabIndex = 23;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSlateBlue;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1686, 500);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(217, 58);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar(Post)";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.Fixed3D;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Cursor = Cursors.Hand;
            dgvEmpleados.Location = new Point(187, 457);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 102;
            dgvEmpleados.RowTemplate.Height = 49;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1368, 420);
            dgvEmpleados.TabIndex = 21;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(852, 292);
            label5.Name = "label5";
            label5.Size = new Size(187, 37);
            label5.TabIndex = 20;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(879, 185);
            label4.Name = "label4";
            label4.Size = new Size(123, 37);
            label4.TabIndex = 19;
            label4.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(257, 178);
            label2.Name = "label2";
            label2.Size = new Size(205, 37);
            label2.TabIndex = 18;
            label2.Text = "Empleado ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Century Gothic", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(818, 36);
            label1.Name = "label1";
            label1.Size = new Size(323, 65);
            label1.TabIndex = 17;
            label1.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(143, 299);
            label3.Name = "label3";
            label3.Size = new Size(341, 37);
            label3.TabIndex = 29;
            label3.Text = "Nombre de Empleado";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(2090, 913);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(BtnModificar);
            Controls.Add(txtNombre);
            Controls.Add(txtEmpleadoID);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnAgregar);
            Controls.Add(dgvEmpleados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button BtnModificar;
        private TextBox txtNombre;
        private TextBox txtEmpleadoID;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnAgregar;
        private DataGridView dgvEmpleados;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}