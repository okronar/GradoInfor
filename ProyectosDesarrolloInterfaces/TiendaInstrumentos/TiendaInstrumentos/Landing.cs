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
        Form1 form1;
        public Landing( )
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void botonGO_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
