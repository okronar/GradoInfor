using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TiendaInstrumentos
{
    public partial class Form1 : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        Landing land;
        public Form1(Landing land)
        {
            InitializeComponent();
            this.land = land;
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

                dataGridView1.DataSource = dt;

                MessageBox.Show("Exito");
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
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("SaveProduct", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String codigoProducto = txboxCodigo.Text;
                String nombreProducto = txboxNombre.Text;

                cmd.Parameters.Add(new SqlParameter("@codigoProducto", codigoProducto));
                cmd.Parameters.Add(new SqlParameter("@nombreProducto", nombreProducto));

                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Exito");


            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");
                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            land.Dispose();
        }
    }
}
