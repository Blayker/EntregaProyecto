using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuperMercado
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }




        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



       
        private int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 7)
            {
                i = 1;
            }
            string f = @"C:\Users\Mikel Parrales\source\repos\SuperMercado\Imagenes\" + i.ToString() + ".png";
            Carrusel.Image = Image.FromFile(f);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("En verdad desea salir de la aplicacion", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {

                MessageBox.Show("Cancelado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Clasinicio clasinicio = new Clasinicio();
            clasinicio.UserName=txtUsuario.Text;
            clasinicio.Password=txtContraseña.Text;

            
           clasinicio.Loguer();

           
        }

    }
}
