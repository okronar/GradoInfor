using AesEncDet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                if (Directory.Exists("data\\" + usuarioExiste)){

                    MessageBox.Show("El usuario ya existe");

                }
                else { 
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


                //
                MessageBox.Show("Usuario creado correctamente");
                this.Close();

            }


            }
            else {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
