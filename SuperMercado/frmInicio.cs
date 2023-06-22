using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            submenu1.Visible = true;
        }







        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }


        private void btnEmpleadoporID_Click(object sender, EventArgs e)
        {
            submenu1.Visible = false;
            AbrirFormHija(new Empleados());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            submenu1.Visible = false;
            AbrirFormHija(new Productos());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            submenu1.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            submenu2.Visible = true;
        }



        private void btnVerventas_Click(object sender, EventArgs e)
        {
            submenu2.Visible = false;
            AbrirFormHija(new VerVentas());
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            submenu2.Visible = false;
            AbrirFormHija(new Vender());
            label1.Visible = false;
            label2.Visible = false;
            lblBienvenida.Visible = false;
        }

        private void submenu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            Clasinicio clasinicio = new Clasinicio();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
            lblBienvenida.Text = "Bienvenido de nuevo" + clasinicio.dato;
        }
    }
}
