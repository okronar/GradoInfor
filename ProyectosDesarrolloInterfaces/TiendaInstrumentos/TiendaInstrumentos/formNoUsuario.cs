using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TiendaInstrumentos
{
    public partial class formNoUsuario : Form

    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public formNoUsuario()
        {
            InitializeComponent();
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

                dataGridViewNoUsu.DataSource = dt;

              
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }

        private void botonBajo_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'bass' ";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewNoUsu.DataSource = dt;

             
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }

        private void botonTeclados_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'keyboards' ";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewNoUsu.DataSource = dt;

               
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }

        private void botonBaterias_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'drums' ";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewNoUsu.DataSource = dt;

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }

        private void botonMicros_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'microphones' ";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewNoUsu.DataSource = dt;

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }

        }

        private void formNoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.land.Dispose();
        }
    }
}
