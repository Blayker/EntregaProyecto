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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            GetAllProducts();

        }

        private async void GetAllProducts()
        {

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7213/api/Productos");
                if (response.IsSuccessStatusCode)
                {
                    var students = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<ProductoDto>>(students);
                    dgvProducts.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de Productos {response.StatusCode}");
                }
            }

        }



        private async void AddProduct()
        {
            ProductoCreateDto product = new ProductoCreateDto();
            product.TipoProducto = txtTipo.Text;
            product.Marca = txtMarca.Text;
            product.Precio = double.Parse(txtPrecio.Text);
            product.Existencia = int.Parse(txtExistencias.Text);

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(product);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7213/api/Productos", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado satifastoriamente");
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de productos {response.StatusCode}");
                }
                Clear();
                GetAllProducts();
            }





        }
        private void Clear()
        {
            txtTipo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private int id = 0;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateProducto(id);
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetProductID(id);
                }
            }
        }
        private async void GetProductID(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "https://localhost:7213/api/Productos", id));
                if (response.IsSuccessStatusCode)
                {
                    var product = await response.Content.ReadAsStringAsync();
                    ProductoDto Producto = JsonConvert.DeserializeObject<ProductoDto>(product);
                    txtExistencias.Text = Producto.Existencia.ToString();
                    txtTipo.Text = Producto.TipoProducto.ToString();
                    txtMarca.Text = Producto.Marca.ToString();
                    txtPrecio.Text = Producto.Precio.ToString();
                }
                else
                {
                    MessageBox.Show($"No se pudo obtener el Producto: {response.StatusCode}");
                }
            }
        }

        private async void UpdateProducto(int id)
        {
            ProductoUpdateDto product = new()
            {
                IdProducto = id,
                TipoProducto = txtTipo.Text,
                Marca = txtMarca.Text,
                Precio = double.Parse(txtPrecio.Text),
                Existencia = int.Parse(txtExistencias.Text)

            };
            using (var client = new HttpClient())
            {
                var serializedEmpleado = JsonConvert.SerializeObject(product);
                var content = new StringContent(serializedEmpleado, Encoding.UTF8,
                    "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7213/api/Productos", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Producto {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7213/api/Productos");
                    var response = await client.DeleteAsync(String.Format("{0}/{1}",
                        "https://localhost:7213/api/Productos/6", id));
                    if (response.IsSuccessStatusCode)
                        MessageBox.Show("Producto eliminado con éxito");
                    else
                        MessageBox.Show($"No se pudo eliminar el producto: {response.StatusCode}");
                }
                Clear();
                GetAllProducts();
            }
        }
    }



}

