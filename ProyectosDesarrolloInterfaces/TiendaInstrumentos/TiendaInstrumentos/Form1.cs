using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TiendaInstrumentos
{
    public partial class Form1 : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridProductos.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }





        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            //esto es para hacerlo mediante visual

            //string sqlQuery = "INSERT INTO Productos (codigo,nombre) VALUES (@codigo,@nombre)";


            //    try {

            //    SqlConnection connection = new SqlConnection(connectionString);
            //    connection.Open();

            //    SqlCommand cmd = new SqlCommand(sqlQuery, connection);

            //    var productoCodigoParametro = new SqlParameter("codigo", System.Data.SqlDbType.VarChar);
            //    productoCodigoParametro.Value = txboxCodigo.Text;
            //    cmd.Parameters.Add(productoCodigoParametro);

            //    var productoNombreParametro = new SqlParameter("nombre", System.Data.SqlDbType.VarChar);
            //    productoNombreParametro.Value = txboxNombre.Text;
            //    cmd.Parameters.Add(productoNombreParametro);





            //    cmd.ExecuteNonQuery();

            //    connection.Close();
            //    MessageBox.Show("Exito");


            //}catch (Exception)
            //{
            //    MessageBox.Show("Fallo");
            //    throw;
            //}
            //Ahora lo hacemos con prcedures guardados de sql
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("SaveProduct", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String codigoProducto = txboxCodigo.Text;
                String nombreProducto = txboxNombre.Text;
                String familiaProducto = txboxFamilia.Text;
                String marcaProducto = txboxMarca.Text;
                float precioProducto = float.Parse(txboxPrecio.Text);

                cmd.Parameters.Add(new SqlParameter("@codigoProducto", codigoProducto));
                cmd.Parameters.Add(new SqlParameter("@nombreProducto", nombreProducto));
                cmd.Parameters.Add(new SqlParameter("@familiaProducto", familiaProducto));
                cmd.Parameters.Add(new SqlParameter("@marcaProducto", marcaProducto));
                cmd.Parameters.Add(new SqlParameter("@precioProducto", precioProducto));

                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Exito insertando");


            }
            catch (Exception)
            {
                MessageBox.Show("Fallo, revise si el producto ya existe");

                throw;
            }

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.land.Dispose();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("DeleteProduct", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String codigoProducto = txboxCodigoBorrar.Text;

                cmd.Parameters.Add(new SqlParameter("@codigoProducto", codigoProducto));


                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Exito borrando");


            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");
                throw;
            }

        }

        private void botonVisualizarClientes_Click(object sender, EventArgs e)
        {
            string sqlQuery;
            sqlQuery = "SELECT * FROM Clientes";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridClientes.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }


        }

        private void botonVisualizarFacturas_Click(object sender, EventArgs e)
        {
            string sqlQuery;
            sqlQuery = "SELECT * FROM Facturas";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridFacturas.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("ActualizarProducto", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String codigoProducto = txboxCodigoUpd.Text;
                String nombreProducto = txboxNombreUpd.Text;
                String familiaProducto = txboxFamiliaupd.Text;
                String marcaProducto = txboxMarcaUpd.Text;
                float precioProducto = float.Parse(txboxPrecioUpd.Text);

                cmd.Parameters.Add(new SqlParameter("@codigoProducto", codigoProducto));
                cmd.Parameters.Add(new SqlParameter("@nombreProducto", nombreProducto));
                cmd.Parameters.Add(new SqlParameter("@familiaProducto", familiaProducto));
                cmd.Parameters.Add(new SqlParameter("@marcaProducto", marcaProducto));
                cmd.Parameters.Add(new SqlParameter("@precioProducto", precioProducto));

                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Exito haciendo Update");


            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");

                throw;
            }

        }
    }
}
