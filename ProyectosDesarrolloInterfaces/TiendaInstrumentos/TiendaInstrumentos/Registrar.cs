using AesEncDet;
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
    public partial class Registrar : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Registrar()
        {
            InitializeComponent();
        }

        private void buttonRegistrarReg_Click(object sender, EventArgs e)
        {
            //registro 
            String usuarioExiste = txUsernameReg.Text;
            if (txUsernameReg.Text.Length < 3 || txPasswordReg.Text.Length < 5)
            {
                MessageBox.Show("Username or password no valido , muy corto");

            }
            else if (txPasswordReg.Text == txRepetir.Text)
            {
                if (Directory.Exists("data\\" + usuarioExiste))
                {

                    MessageBox.Show("El usuario ya existe");

                }
                else
                {
                    //creacion del directorio que contendra el fichero
                    string dir = txUsernameReg.Text;
                    Directory.CreateDirectory("data\\" + dir);
                    var sw = new StreamWriter("data\\" + dir + "\\data.ls");
                    //creamos las string del encriptado en nuestra clase AesCrypt
                    string encusr = AesCryp.Encrypt(txUsernameReg.Text);
                    string encpss = AesCryp.Encrypt(txPasswordReg.Text);

                    // una vez llamadas a los metodos estaticos para encriptar, escribimos en el fichero 
                    sw.WriteLine(encusr);
                    sw.WriteLine(encpss);
                    sw.Close();
                    //IMPORTANTE
                    insertarClienteDB();


                    //
                    MessageBox.Show("Usuario creado correctamente");
                    this.Close();

                }


            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void insertarClienteDB()
        {
            //insercion en database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SaveClient", connection);

            //esto es para especificar que es un procedimiento 
            cmd.CommandType = CommandType.StoredProcedure;

            String nombreCliente = txboxNombreReg.Text;
            String apellidoCliente = txboxApellidoReg.Text;
            String emailCliente = txboxEmailReg.Text;
            String clienteId = txUsernameReg.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreCliente", nombreCliente));
            cmd.Parameters.Add(new SqlParameter("@apellidoCliente", apellidoCliente));
            cmd.Parameters.Add(new SqlParameter("@emailCliente", emailCliente));
            cmd.Parameters.Add(new SqlParameter("@clienteId", clienteId));

            cmd.ExecuteNonQuery();

            connection.Close();


        }
        private void Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
