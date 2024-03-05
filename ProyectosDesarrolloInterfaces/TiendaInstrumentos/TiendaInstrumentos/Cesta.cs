using AesEncDet;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
       // añadimos producto
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
                    txboxCodProdAñadir.Text = null;


                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el código especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al agregar el producto al pedido, revise el codigo ");
            }
        }

        //borrar el ultimo producto
        private void buttonBorrarUltimo_Click(object sender, EventArgs e)
        {
            pedido.BorrarUltimoProducto();
            ActualizarLabelCarro();
            labelCarro.Refresh();
        }
        private void ActualizarLabelCarro()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------SU PEDIDO-------------");
            if (pedido.getCount() > 0)
            {

                foreach (Producto producto in pedido.getList())
                {
                    sb.AppendLine($"- {producto.Nombre} - {producto.Precio}€");
                }

                // Limpiar el contenido anterior del LabelCarro.Text
                labelCarro.Text = string.Empty;

                // Agregar el nuevo contenido al LabelCarro.Text
                labelCarro.Text = sb.ToString();
            }
            else
            {
                // Limpiar el contenido anterior del LabelCarro.Text
                labelCarro.Text = string.Empty;

               }
        }
        // Declarar una variable global para el número de factura
       
        //comprar significa introducir la factura en la tabla facturas y sacar como archivo de texto en un directorio del cliente los datos de la factura
        private void buttonComprar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha actual como parte del nombre del directorio
            string fechaActual = DateTime.Now.ToString("yyyyMMdd");
            DateTime dateTime = DateTime.Now;
            // Solicitar al usuario que introduzca su ID de cliente
            string clienteId = Microsoft.VisualBasic.Interaction.InputBox("Introduce de nuevo tu nombre de Usuario:", "ClienteId");

            // Comprobar si hay productos en el carrito
            if (!string.IsNullOrEmpty(labelCarro.Text))
            {
                // Comprobar si se proporcionó el ID de cliente
                if (!string.IsNullOrEmpty(clienteId))
                {
                    try
                    {
                        // Insertar factura en la base de datos
                        insertarFacturaDb(clienteId,dateTime);

                        //busco el id de la factura que acabo de introducir(es la ultima)

                        int numeroFactura = obtenerUltimoFacturaID();

                        // Crear el directorio que contendrá el archivo
                        string directorioCliente = Path.Combine("data", clienteId, fechaActual);
                        Directory.CreateDirectory(directorioCliente);

                        // Crear el nombre del archivo usando el número de factura
                        string nombreArchivo = $"{numeroFactura}.ls";
                        string rutaArchivo = Path.Combine(directorioCliente, nombreArchivo);

                        // Escribir el contenido del carrito en el archivo
                        File.WriteAllText(rutaArchivo, labelCarro.Text);

                        // Incrementar el número de factura para la próxima compra
                        numeroFactura++;

                        MessageBox.Show("Pedido guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Introduce tu ID de cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Añade productos al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //insertar la factura en sql
        private void insertarFacturaDb(string ClienteId,DateTime Fecha)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("InsertarFactura", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;
                
                


                cmd.Parameters.Add(new SqlParameter("@ClienteId", ClienteId));
                cmd.Parameters.Add(new SqlParameter("@Fecha", Fecha));


                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Exito insertando Factura");




            }
            catch (Exception)
            {
                MessageBox.Show("Fallo, revise si el ClienteId esta bien escrito");

                throw;
            }

        }

        //coge el id de la ultima factura
        private int obtenerUltimoFacturaID()
        {
            int ultimoFacturaID = 0;

            try
            {
                string sqlQuery = "SELECT MAX(FacturaID) AS UltimoFacturaID FROM Facturas";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0]["UltimoFacturaID"] != DBNull.Value)
                {
                    ultimoFacturaID = Convert.ToInt32(dt.Rows[0]["UltimoFacturaID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último FacturaID: " + ex.Message);
            }

            return ultimoFacturaID;
        }

        //select disponibles
        private void botonGuitarras_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'guitar' AND disponible = 1 ";

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
        //select disponibles
        private void botonBajo_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'bass'  AND disponible = 1 ";

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
        //select disponibles
        private void botonTeclados_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'keyboards'  AND disponible = 1 ";

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
        //select disponibles
        private void botonBaterias_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'drums'  AND disponible = 1 ";

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
        //select disponibles
        private void botonMicros_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            sqlQuery = "SELECT * FROM Productos WHERE Familia = 'microphones'  AND disponible = 1 ";

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

    }
}
