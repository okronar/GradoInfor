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

            //inicializacion de variables

            label_Info.Text = "Elige un numero entre " + Convert.ToString(min) + " y " + Convert.ToString(max);

            label_Intentos.Text = "Intentos: " + tries;

            //establece el valor  del numero a descubrir
            randomNum = rndom_Calc(min, max);

            Label_Debug.Text = Convert.ToString(randomNum);
            Label_Debug.Visible = false;


        }

        private int rndom_Calc(int min, int max)
        {
            var random = new Random();

            int nuevoRand = random.Next(min, max);

            return nuevoRand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAction_Click(object sender, EventArgs e)
        {

            buttonAction.Text = "Pulsar";
            auxiliar = textBoxInput.Text;
            textBoxInput.PlaceholderText = "intentalo de nuevo";

            try
            {
                answer = Convert.ToInt32(auxiliar);

            }
            catch (Exception ex)
            {
                label_Info.Text = "Texto erroneo " + ex.Message;

            }
            if (tries > 0)
            {
                if (auxiliar != "")
                {
                    if (answer == randomNum)
                    {
                        label_Info.Text = " ¡ " + auxiliar + " es correcto !";
                        IsGameWOn = true;
                        resetGame();
                    }
                    else if (answer > randomNum)
                    {
                        label_Info.Text = auxiliar + " es mayor, prueba mas bajo ";
                        textBoxInput.Clear();
                        tries--;
                        label_Intentos.Text = "Intentos: " + tries.ToString();
                    }
                    else
                    {
                        label_Info.Text = auxiliar + " es menor, prueba mas alto ";
                        textBoxInput.Clear();
                        tries--;
                        label_Intentos.Text = "Intentos: " + tries.ToString();

                    }

                }
                else
                { //
                }

            }
            else
            {
                resetGame();
            }

        }

        private void resetGame()
        {
            buttonAction.Text = "nuevo juego?";
            textBoxInput.Clear();
            randomNum = rndom_Calc(min, max);
            tries = 3;
            if (IsGameWOn)
            {
                label_Info.Text = "ganaste! Adivina el numero entre " + min + " y " + max;
                IsGameWOn = false;
                label_Intentos.Text = "Intentos  " + tries.ToString();

            }
            else
            {
                label_Info.Text = "Prueba otra vez. Adivina el número entre " + min + " y " + max;
                label_Intentos.Text = "Intentos  " + tries.ToString();

            }
        }

        private void button_newForm_Click(object sender, EventArgs e)
        {
            Form2 vista = new Form2();
            vista.Show();
        }

        private void button_ocult_Click(object sender, EventArgs e)
        {
            if (!Label_Debug.Visible)

                Label_Debug.Visible = true;
            else
            {
                Label_Debug.Visible = false;
            }
        }

        private void Label_Debug_Click(object sender, EventArgs e)
        {

        }
    }
}