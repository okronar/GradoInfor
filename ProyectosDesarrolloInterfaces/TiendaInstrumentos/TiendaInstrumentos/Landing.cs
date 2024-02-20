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
    public partial class Landing : Form
    {

        public Landing()
        {
            InitializeComponent();

        }

        private void botonGO_Click(object sender, EventArgs e)

        {
            
        }

        private void Landing_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Dispose();
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
