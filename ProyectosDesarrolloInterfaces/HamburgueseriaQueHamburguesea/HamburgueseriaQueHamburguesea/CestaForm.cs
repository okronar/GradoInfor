using Hamburger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaQueHamburguesea
{
    public partial class CestaForm : Form
    {
        Form2 form2;
        public CestaForm(Form2 formu2)
        {
            InitializeComponent();
            form2 = formu2;
            string listaObjetos = ObtenerListaObjetos(Form2.Cesta);
            LabelPedido.Text = listaObjetos;
            labelAnotaciones.Text = Form2.anotaciones;

        }



        private void botonVolverCesta_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void CestaForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            form2.Close();
        }

        static string ObtenerListaObjetos(Pedido pedido)
        {
            // Inicializar una cadena vacía para almacenar la lista de objetos
            string listaObjetos = "";

            // Obtener la lista de objetos del pedido
            List<Item> items = pedido.getItems();

            // Recorrer la lista de objetos y generar la representación de cadena para cada uno
            foreach (Item item in items)
            {
                listaObjetos += item.ToString() + "\n";
            }

            return listaObjetos;
        }

        private void botonPagarCesta_Click(object sender, EventArgs e)
        {
            // Obtener la lista de objetos del pedido actual
            List<Item> items = Form2.Cesta.getItems();

            // Generar el contenido del archivo de texto
            StringBuilder contenidoPedido = new StringBuilder();
            contenidoPedido.AppendLine("Último pedido:");
            contenidoPedido.AppendLine("--------------------------");
            foreach (Item item in items)
            {
                contenidoPedido.AppendLine(item.ToString());
            }
            contenidoPedido.AppendLine("--------------------------");

            // Guardar el contenido en un archivo de texto
            string nombreArchivo = "ultimo_pedido.txt";
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);
            File.WriteAllText(rutaArchivo, contenidoPedido.ToString());

            MessageBox.Show("Pedido pagado, espero, o te rajo. gracias por su visita");
            this.Hide();
            form2.Close();



        }

        private void buttonUlt_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del archivo de texto del escritorio
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ultimo_pedido.txt");

                // Leer el contenido del archivo de texto
                string contenidoPedido = File.ReadAllText(rutaArchivo);

                // Mostrar el contenido del pedido en un cuadro de mensaje
                MessageBox.Show(contenidoPedido, "Último Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al leer el archivo
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }


}
