using EjemploFireBase.Model;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFireBase
{
    public partial class Form2 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            //Info in Firebase Console
            //aqui pegaremos los secretos y el enlance de la base de datos
            AuthSecret = "cdkPFjEKVYsvwK4CXwX55nEUtWiSwIEJ8pNB170X",
            BasePath = "https://ejemplofirebase-9859d-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;
        public Form2()
        {
            InitializeComponent();

  
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }


       

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona imagen";
            ofd.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = img;
            }
        }

        private async void buttoninsertar_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Png);

            byte[] arr = ms.GetBuffer();
            string output = Convert.ToBase64String(arr);

            var data = new Image_model

            {
                Img = output
            };

            SetResponse response = await client.SetTaskAsync("Image/", data);
            Image_model result = response.ResultAs<Image_model>();

            MessageBox.Show("Imagen insertada con exito");
            //vacia la imagen una vez hecho 

            pictureBox1.Image = null;
        }


    }
}
