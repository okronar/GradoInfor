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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //respuesta al boton
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txUsername.Text.Length < 3 || txPassword.Text.Length < 5)
            {
                MessageBox.Show("Username or password no valido , muy corto");

            }
            else
            {

                string dir = txUsername.Text;
                //verificacion de usuario registrado 
                if (!Directory.Exists("data\\" + dir))
                {
                    MessageBox.Show("usuario no registrado");
                }
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if (decusr == txUsername.Text && decpss == txPassword.Text && txUsername.Text != "admin")
                    {
                        MessageBox.Show("Bienvenido");
                        formUsuariocs formUsu = new formUsuariocs();
                        formUsu.Show(); 
                        this.Hide();
                    }
                                        else if (decusr == txUsername.Text && decpss == txPassword.Text && txUsername.Text == "admin")
                    {
                        MessageBox.Show("Bienvenido administrador");
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("error");
                    }
                   






                }

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.land.Dispose();
        }
    }
}
