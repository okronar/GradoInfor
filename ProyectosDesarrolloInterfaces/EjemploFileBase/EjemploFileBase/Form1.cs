using EjemploFireBase.Model;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net.Sockets;

namespace EjemploFileBase
{
    public partial class Form1 : Form
    {




        //2.auth and config
        IFirebaseConfig config = new FirebaseConfig
        {
            //Info in Firebase Console
            //aqui pegaremos los secretos y el enlance de la base de datos
            AuthSecret = "cdkPFjEKVYsvwK4CXwX55nEUtWiSwIEJ8pNB170X",
            BasePath = "https://ejemplofirebase-9859d-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Conexion establecida");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private async void buttonInsertar_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = textBoxId.Text,
                Name = textBoxNombre.Text,
                Address = textBoxDireccion.Text,
                Age = textBoxEdad.Text


            };
            SetResponse response = await client.SetTaskAsync( "Information/" + textBoxId.Text, data );
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Insercion realizada con id:" + result.Id);

        }
    }
}
    
