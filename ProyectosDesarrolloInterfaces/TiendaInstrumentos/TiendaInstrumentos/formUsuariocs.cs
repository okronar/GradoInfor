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
    public partial class formUsuariocs : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public formUsuariocs()
        {
            InitializeComponent();
            
            Landing lnd =new Landing(); ;
            lnd.Show();
            
        }

        private void botonGuitarras_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'guitar' ";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewUsu.DataSource = dt;

                MessageBox.Show("Exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }
    }
}
