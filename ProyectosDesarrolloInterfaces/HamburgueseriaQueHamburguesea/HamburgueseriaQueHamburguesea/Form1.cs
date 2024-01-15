


using Hamburger;

namespace HamburgueseriaQueHamburguesea
{
    public partial class Form1 : Form
    {

     
      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form2 formi = new Form2(this);
            formi.Show();
            this.Hide();

            
        }
    }
}