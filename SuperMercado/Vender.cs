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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }

        private void Vender_Load(object sender, EventArgs e)
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();



            if (txtMarca.Text == "" && txtTipo.Text == "" && txtPrecio.Text == "" && txtExistencias.Text == "")
            {
                MessageBox.Show("Producto No digitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtCantidad.Text != "")
                {

                    file.CreateCells(dgvLista);
                    file.Cells[0].Value = id;
                    file.Cells[1].Value = txtTipo.Text;
                    file.Cells[2].Value = txtMarca.Text;
                    file.Cells[3].Value = txtPrecio.Text;
                    file.Cells[4].Value = txtCantidad.Text;
                    file.Cells[5].Value = (float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

                    dgvLista.Rows.Add(file);

                }
                else
                {
                    MessageBox.Show("Cantidad no digitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                obtenerTotal();
            }









        }
        private int id = 0;
        public void obtenerTotal()
        {
            float costot = 0;
            int contador;

            contador = dgvLista.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dgvLista.Rows[i].Cells[5].Value.ToString());
            }

            lblTotalPagar.Text = costot.ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }
        float devolucion;
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float total;
                total = float.Parse(txtEfectivo.Text) - float.Parse(lblTotalPagar.Text);




                devolucion = total;


                lblDevolucion.Text = devolucion.ToString();



            }
            catch { }

            if (txtEfectivo.Text == "")
            {
                lblDevolucion.Text = "";
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtTipo.Text == "" || txtPrecio.Text == "" || txtExistencias.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Producto No digitado no digitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (devolucion < 0)
                {
                    MessageBox.Show("Saldo insuciente,Intente otra vez", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

                    Ticket1.TextoCentro("Empresa HyperShop "); //imprime una linea de descripcion
                    Ticket1.TextoCentro("**********************************");

                    Ticket1.TextoIzquierda("");
                    Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                    Ticket1.TextoIzquierda("No Fac: 0120102");
                    Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                    Ticket1.TextoIzquierda("");
                    clsFactura.CreaTicket.LineasGuion();

                    clsFactura.CreaTicket.EncabezadoVenta();
                    clsFactura.CreaTicket.LineasGuion();
                    foreach (DataGridViewRow r in dgvLista.Rows)
                    {
                        //Codigo                                   //Tipo                  //Marca                                   Existencia                         Cantidad                                       
                        Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), r.Cells[1].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[4].Value.ToString()), double.Parse(r.Cells[5].Value.ToString())); //imprime una linea de descripcion
                    }


                    clsFactura.CreaTicket.LineasGuion();
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Total", double.Parse(lblTotalPagar.Text)); // imprime linea con total
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
                    Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


                    // Ticket1.LineasTotales(); // imprime linea 

                    Ticket1.TextoIzquierda(" ");
                    Ticket1.TextoCentro("**********************************");
                    Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                    Ticket1.TextoCentro("**********************************");
                    Ticket1.TextoIzquierda(" ");
                    string impresora = "Microsoft XPS Document Writer";
                    Ticket1.ImprimirTiket(impresora);

                    MessageBox.Show("Gracias por preferirnos");


                }

            }
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
