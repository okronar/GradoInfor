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

                dataGridViewUsu.DataSource = dt;


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

                dataGridViewUsu.DataSource = dt;


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

                dataGridViewUsu.DataSource = dt;


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

                dataGridViewUsu.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }

        }

        private void formUsuariocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.land.Dispose();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void botonCesta_Click(object sender, EventArgs e)
        {
            Cesta cesta = new Cesta();  
            cesta.Show();
            this.Hide();
        }
    }
}
