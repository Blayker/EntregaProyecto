using Newtonsoft.Json;
using ProyectoFinalAPI.Models.Dto;
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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            GetAllEmpleados();

        }

        private async void GetAllEmpleados()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7213/api/Empleados");
                if (response.IsSuccessStatusCode)
                {
                    var empleado = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<EmpleadooDto>>(empleado);
                    dgvEmpleados.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de Empleados {response.StatusCode}");
                }
            }
        }

        private async void AddEmpleado()
        {
            EmpleadoCreateDto empleado = new EmpleadoCreateDto();

            empleado.Nombre = txtNombre.Text;
            empleado.UserName = txtUser.Text;
            empleado.Password = txtPassword.Text;

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(empleado);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7213/api/Empleados", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Empleado agregado sactisfactoriamente");
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de Empleado {response.StatusCode}");
                }
                Clear();
                GetAllEmpleados();
            }
        }
        private void Clear()
        {
            txtEmpleadoID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUser.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddEmpleado();
        }

        private int id = 0;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateEmpleadoID(id);
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetEmpleadoID(id);
                }
            }
        }
        private async void GetEmpleadoID(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "https://localhost:7213/api/Empleados", id));
                if (response.IsSuccessStatusCode)
                {
                    var empleado = await response.Content.ReadAsStringAsync();
                    EmpleadooDto Empleado = JsonConvert.DeserializeObject<EmpleadooDto>(empleado);
                    txtEmpleadoID.Text = Empleado.Id.ToString();
                    txtNombre.Text = Empleado.Nombre;
                    txtUser.Text = Empleado.UserName;
                    txtPassword.Text = Empleado.Password;
                }
                else
                {
                    MessageBox.Show($"No se pudo obtener el Empleado: {response.StatusCode}");
                }
            }
        }
        private async void UpdateEmpleadoID(int id)
        {
            EmpleadoUpdateDto empleado = new()
            {
                Id = int.Parse(txtEmpleadoID.Text),
                Nombre = txtNombre.Text,
                UserName = txtUser.Text,
                Password = txtPassword.Text

            };
            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(empleado);
                var content = new StringContent(serializedStudent, Encoding.UTF8,
                    "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7213/api/Empleados", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Empleado {response.StatusCode}");
            }
            Clear();
            GetAllEmpleados();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7213/api/Empleados");
                    var response = await client.DeleteAsync(String.Format("{0}/{1}",
                        "https://localhost:7213/api/Empleados", id));
                    if (response.IsSuccessStatusCode)
                        MessageBox.Show("empleado eliminado con éxito");
                    else
                        MessageBox.Show($"No se pudo eliminar el empleado: {response.StatusCode}");
                }
                Clear();
                GetAllEmpleados();
            }
        }
    }
}
