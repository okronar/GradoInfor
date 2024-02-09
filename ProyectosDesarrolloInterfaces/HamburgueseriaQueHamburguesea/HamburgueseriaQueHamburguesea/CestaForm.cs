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
        }

        private void LabelPedido_Click(object sender, EventArgs e)
        {

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
    }
}
