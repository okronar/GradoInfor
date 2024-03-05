using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using AesEncDet;

namespace TiendaInstrumentos
{
    public partial class Form1 : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();

        }
        //visualizar productos
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
        //insert Producto
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
                MessageBox.Show("Exito insertando Producto");


            }
            catch (Exception)
            {
                MessageBox.Show("Fallo, revise si el producto ya existe");

                throw;
            }

        }

        //insert cliente
        private void buttonInsertClie_Click(object sender, EventArgs e)
        {
            insertarCliente();

        }

        //update cliente db
        private void buttonUpdateCliente_Click(object sender, EventArgs e)
        {
            updatearClienteDb();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.land.Dispose();
        }
        //Borrar Producto
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

        //select clientes
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

        //borrar clientes, borrare tambien los datos de facturas o saltara excepcion por ser relacion foranea
        private void buttonBorrarCli_Click(object sender, EventArgs e)
        {
                try
                {

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DeleteClienteYFactura", connection);

                    //esto es para especificar que es un procedimiento 
                    cmd.CommandType = CommandType.StoredProcedure;

                    String clienteBorrar = txboxClientBorrar.Text;

                    cmd.Parameters.Add(new SqlParameter("@ClienteID", clienteBorrar));


                    cmd.ExecuteNonQuery();

                    connection.Close();

                    //borramos directorio tambien
                    EliminarDirectorioCliente(txboxClientBorrar.Text);

                    MessageBox.Show("Exito borrando cliente e historial");

                    txboxClientBorrar.Text = null;

                }
                catch (Exception)
                {
                    MessageBox.Show("Fallo al borrar cliente y su historial");
                    throw;
                }

            }

        //select facturas
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


        //update producto
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateProducto();

        }
        //Update de Producto en DB
        private void UpdateProducto()
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

        //insercion en usuarios en el sistema y DB
        private void insertarCliente()
        {
            try
            {


                String usuarioExiste = txboxInsertCliId.Text;
                if (txboxInsertCliId.Text.Length < 3 || txboxInsertCliId.Text.Length < 5)
                {
                    MessageBox.Show("Username or password no valido , muy corto");

                }
                else if (textBoxPasswordInsert.Text == RepetirPassInsert.Text)
                {
                    if (Directory.Exists("data\\" + usuarioExiste))
                    {

                        MessageBox.Show("El Id de usuario ya existe");

                    }
                    else
                    {
                        //creacion del directorio que contendra el fichero
                        string dir = txboxInsertCliId.Text;
                        Directory.CreateDirectory("data\\" + dir);
                        var sw = new StreamWriter("data\\" + dir + "\\data.ls");
                        //creamos las string del encriptado en nuestra clase AesCrypt
                        string encusr = AesCryp.Encrypt(txboxInsertCliId.Text);
                        string encpss = AesCryp.Encrypt(textBoxPasswordInsert.Text);

                        // una vez llamadas a los metodos estaticos para encriptar, escribimos en el fichero 
                        sw.WriteLine(encusr);
                        sw.WriteLine(encpss);
                        sw.Close();
                        //IMPORTANTE
                        insertarClienteDB();

                        //
                        MessageBox.Show("Usuario creado correctamente");







                    }


                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }






            }
            catch (Exception)
            {
                MessageBox.Show("Fallo, revise si el cliente ya existe");

                throw;
            }
        }

        //encapsulacion metodo insertar cliente
        private void insertarClienteDB()
        {
            //insercion en database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SaveClient", connection);

            //esto es para especificar que es un procedimiento 
            cmd.CommandType = CommandType.StoredProcedure;

            String nombreCliente = txboxNombreCliInsert.Text;
            String apellidoCliente = txboxApeInsert.Text;
            String emailCliente = txboxEmailInser.Text;
            String clienteId = txboxInsertCliId.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreCliente", nombreCliente));
            cmd.Parameters.Add(new SqlParameter("@apellidoCliente", apellidoCliente));
            cmd.Parameters.Add(new SqlParameter("@emailCliente", emailCliente));
            cmd.Parameters.Add(new SqlParameter("@clienteId", clienteId));

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        private void EliminarDirectorioCliente(string clienteId)
        {
            try
            {
                string directorioCliente = "data\\" + clienteId;

                if (Directory.Exists(directorioCliente))
                {
                    Directory.Delete(directorioCliente, true); // true para eliminar subdirectorios y archivos
                    MessageBox.Show("Directorio del cliente eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("El directorio del cliente no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el directorio del cliente: " + ex.Message);
            }
        }
        private void updatearClienteDb()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("UpdateCliente", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String clienteId = txboxClienteUpd.Text;
                String nombreCliente = txboxNombreCliUpd.Text;
                String apellidoCliente = txboxApellidoUpd.Text;
                String emailCliente = txboxEmailUpd.Text;


                cmd.Parameters.Add(new SqlParameter("@ClienteID", clienteId));
                cmd.Parameters.Add(new SqlParameter("@Nombre", nombreCliente));
                cmd.Parameters.Add(new SqlParameter("@Apellido", apellidoCliente));
                cmd.Parameters.Add(new SqlParameter("@Email", emailCliente));







                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Exito haciendo Update cliente");


            }
            catch (Exception)
            {
                MessageBox.Show("Fallo, compruebe los campos bien");

                throw;
            }
        }


        private void buttonFactura_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y convertir la fecha
                DateTime fechaFactura;
                if (!DateTime.TryParse(txboxFechaFact.Text, out fechaFactura))
                {
                    MessageBox.Show("La fecha debe estar en formato válido (dd/mm/aaaa).", "Formato de Fecha Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear el comando para el procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand("InsertarFactura", connection))
                    {
                        // Especificar que es un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;

                        String clienteID = txboxclienteFactu.Text;
                        String fecha = txboxFechaFact.Text;

                        // Asignar parámetros
                        cmd.Parameters.Add(new SqlParameter("@ClienteId", clienteID));
                        cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Factura insertada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar factura: " + "El cliente ha de existir para poder facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.land.Show();
        }
    }
}
