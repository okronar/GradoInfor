using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaInstrumentos
{
    public partial class Cesta : Form
    {
        Pedido pedido = new Pedido();
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Cesta()
        {
            InitializeComponent();

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE disponible = 1"; // Filtrar por productos disponibles

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridProductosDisp.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");
                throw;
            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            formUsuariocs formUsu = new formUsuariocs();
            formUsu.Show();
            this.Hide();
        }

        private void Cesta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.land.Dispose();
        }



        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            string codigoProducto = txboxCodProdAñadir.Text;
            string sqlQuery = $"SELECT * FROM Productos WHERE Codigo = '{codigoProducto}'";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    Producto producto = new Producto(
                        row["Codigo"].ToString(),
                        row["Nombre"].ToString(),
                        row["Familia"].ToString(),
                        row["Marca"].ToString(),
                        Convert.ToSingle(row["Precio"]),
                        Convert.ToBoolean(row["disponible"])
                    );

                    pedido.AgregarProducto(producto);
                    ActualizarLabelCarro();
                    MessageBox.Show("Producto añadido al pedido correctamente.");


                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el código especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al agregar el producto al pedido: " + ex.Message);
            }
        }

        private void ActualizarLabelCarro()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------SU PEDIDO-------------");
            if (pedido.getCount() > 0)
            {

                foreach (Producto producto in pedido.getList())
                {
                    sb.AppendLine($"- {producto.Nombre} - {producto.Precio}");
                }

                labelCarro.Text = sb.ToString();
            }
        }

    }
}
