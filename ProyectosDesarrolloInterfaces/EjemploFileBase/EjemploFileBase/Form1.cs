using EjemploFireBase.Model;
using EjemploFireBase.Service;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Data;
using System.Net.Sockets;

namespace EjemploFileBase
{
    public partial class Form1 : Form
    {

        //exportar valores al datagridview
        DataTable dt = new DataTable();



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

            //creamos columnas
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Edad");

            dgv1.DataSource = dt;

        }










        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = textBoxId.Text,
                Name = textBoxNombre.Text,
                Address = textBoxDireccion.Text,
                Age = textBoxEdad.Text
            };
            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + textBoxId.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Datos actualizados con id : " + result.Id);


        }

        private async void buttonInsertar_Click(object sender, EventArgs e)
        {

            FirebaseResponse resp = await client.GetTaskAsync("Contador/node");
            Counter_class get = resp.ResultAs<Counter_class>();

            //preparamos el dato a insertar en la DB
            var data = new Data
            {
                Id = ((Convert.ToInt32(get.Cnt) + 1)).ToString(),
                Name = textBoxNombre.Text,
                Address = textBoxDireccion.Text,
                Age = textBoxEdad.Text


            };
            var obj = new Counter_class
            {
                Cnt = data.Id
            };

            SetResponse response = await client.SetTaskAsync("Information/" + data.Id, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Insercion realizada con id:" + result.Id);
            MessageBox.Show("El número de elementos actual es " + get.Cnt);

            SetResponse response2 = await client.SetTaskAsync("Contador/node", obj);
            limpiar();

        }
        //coger datos de la base
        private async void buttonRecuperar_Click(object sender, EventArgs e)
        {
            //le pasamos el nodo padre y el subnodo
            FirebaseResponse response = await client.GetTaskAsync("Information/" + textBoxId.Text);


            Data obj = response.ResultAs<Data>();

            textBoxId.Text = obj.Id;
            textBoxNombre.Text = obj.Name;
            textBoxDireccion.Text = obj.Address;
            textBoxEdad.Text = obj.Age;

        }
        public void limpiar()
        {
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxEdad.Text = "";
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + textBoxId.Text);


            MessageBox.Show("Datos eliminados con id : " + textBoxId.Text);
            limpiar();
        }
        //llevar al data grid
        private async void bringData()
        {
            dt.Rows.Clear();

            FirebaseResponse resp1 = await client.GetTaskAsync("Contador/node");
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            int cont = Convert.ToInt32(obj1.Cnt);
            int i = 0;
            while (true)
            {
                if (i == cont)
                {

                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/" + i);
                    Data obj2 = resp2.ResultAs<Data>();
                    DataRow row = dt.NewRow();
                    row["Id"] = obj2.Id;
                    row["Nombre"] = obj2.Name;
                    row["Direccion"] = obj2.Address;
                    row["Edad"] = obj2.Age;
                    dt.Rows.Add(row);

                }
                catch
                {
                    MessageBox.Show("Algo ha fallado ");
                }

            }
            MessageBox.Show("todo bien ");


        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bringData();
        }
    }
}

