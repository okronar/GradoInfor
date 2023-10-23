using System.DirectoryServices;

namespace GuessNumber_Ex3
{
    public partial class Form1 : Form
    {

        private string auxiliar = "";
        private int min = 0;
        private int max = 10;
        private int tries = 3;
        private int answer = 0;
        private Boolean IsGameWOn = false;
        private int randomNum;




        public Form1()
        {
            InitializeComponent();
            auxiliar = "";
            label_Info.Text = "Elige un numero entre " + Convert.ToString(min) +" y " + Convert.ToString(max);
            label_Intentos.Text = "Intentos: " + tries;

            Label_Debug.Text = Convert.ToString(randomNum);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAction_Click(object sender, EventArgs e)
        {


        }
    }
}