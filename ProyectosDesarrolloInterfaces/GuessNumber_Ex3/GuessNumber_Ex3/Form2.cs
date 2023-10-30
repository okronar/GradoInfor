using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber_Ex3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            ////cargar imagen de manera directa a picture box
            //picBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //string ruta = "D:\\Sergio\\ProyectosDesarrolloInterfaces\\GuessNumber_Ex3\\GuessNumber_Ex3\\recursos\\imagenes\\doggo.jpg";
            ////esto carga la imagen 
            //var MyImage = new Bitmap(ruta);
            //picBox1.Image = MyImage;


            //cargar imagen desde openfiledialog
            picBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                //esto carga la imagen 
                var MyImage = new Bitmap(ruta);
                picBox1.Image = MyImage;
            }
            else { 
            
            }
            
        }
    }
}
