using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    public class Clasinicio
    {


        private int count;

        private string userName;
        private string password;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public string dato { get; set; }

        

        public void Loguer()
        {
           

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Por favor ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool credentialsValid = false;

            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Empleados WHERE UserName = @UserName AND Password = @Password", sc);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    credentialsValid = true;
                }
            }

            if (credentialsValid)
            {
                MessageBox.Show($"Bienvenido: {userName}, Acceso concedido", "Display", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmInicio fm = new frmInicio();
                fm.ShowDialog();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta. \nIntente nuevamente. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count += 1;

            }
            if (count >= 3)
            {
                MessageBox.Show("Usuario bloqueado. \nIntente de nuevo mas tarde. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Cerradno Appliacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

    }
}
