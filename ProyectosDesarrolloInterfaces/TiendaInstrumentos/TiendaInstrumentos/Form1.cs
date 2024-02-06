using Microsoft.Data.SqlClient;
using System.Data;

namespace TiendaInstrumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-F7EQIKK; Initial Catalog=Tienda_instrumentos; Encrypt=False; Integrated Security=true";

            string sqlQuery;
            sqlQuery = "SELECT * FROM Producto";

            try {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Exito");
            }
            catch(Exception)
            {
                MessageBox.Show("Fallo");
                throw;


            }





        }
    }
}
