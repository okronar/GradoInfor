using System.Data.SQLite;
using System.Data;
using Microsoft.Reporting.WinForms;

namespace Informes
{
    public partial class Form1 : Form
    {

        public Form2 ventana2 = new Form2();
        public Form1()
        {
            InitializeComponent();

       

        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            //conexion
            SQLiteConnection conn = new SQLiteConnection("Data source = D:\\Sergio\\Interfaces-trabajos\\provider_sqlite.db");

            string query = "SELECT * from Cliente ";
            //comand object 
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            //datatable
            DataTable dt = new DataTable();
            //adapter 
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            //enlace datable con datagridview
            dgv_DB.DataSource = dt;





        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            ventana2.Show();
        }
    }
}
