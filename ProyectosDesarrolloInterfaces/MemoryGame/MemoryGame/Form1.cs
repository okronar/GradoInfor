namespace MemoryGame
{
    public partial class Form1 : Form
    {
        //1 Establecer un table grid view, 4x4
        /* centrar label, letra webdings, la c es un cuadrado
         replicar la label
                  */
        //definir variables 
        Random random = new Random();
        List<string> icons = new List<string>() {

        "!","!","d","d","e","e","h","h","l","l","s","s","f","f","o","o"

        };
        Label firstClicked, SecondClicked;
        //creamos la funcion asignar imagenes
        int tempojuego;
        private void asignarIconos()
        {
            Label label;
            int rndomNumber;

            for (int i = 0; i < tbl_lout_panel.Controls.Count; i++)
            {

                //verificacion de que sean label 
                if (tbl_lout_panel.Controls[i] is Label)
                {
                    label = (Label)tbl_lout_panel.Controls[i];

                }
                else
                {
                    continue;
                }
                rndomNumber = random.Next(0, icons.Count);
                label.Text = icons[rndomNumber];

                //vamos eliminando los elementos para no repetir
                icons.RemoveAt(rndomNumber);

            }
            timer2.Start();
        }

        //cambio el color d elas labels para ocultarlas
        // vamos a eventos

        public Form1()
        {
            InitializeComponent();
            asignarIconos();


        }

        private void label_Click(object sender, EventArgs e)
        {
            //si has clicado dos, return (para no clicar mas de dos)

            if (firstClicked != null && SecondClicked != null) { return; }
            //verificamos como antes
            Label clickedLabel = sender as Label;


            //si no es label salir
            if (clickedLabel == null)
            {

                return;
            }

            //si ya esta descubierta salir 
            if (clickedLabel.ForeColor == Color.Chocolate)
            {
                return;

            }
            if (firstClicked == null)
            {

                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Chocolate;
                return;
            }
            SecondClicked = clickedLabel;
            SecondClicked.ForeColor = Color.Chocolate;

            //aqui miramos si se ha ganado
            checkForWinner();

            if (firstClicked.Text == SecondClicked.Text)
            {
                firstClicked = null;
                SecondClicked = null;

            }
            else
            {

                timer1.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //pasado el tiempo devolvemos el color para ocultar y dejamos a null las label
            firstClicked.ForeColor = Color.Teal;
            SecondClicked.ForeColor = Color.Teal;

            //limpiamos variables
            firstClicked = null;
            SecondClicked = null;
        }

        private void checkForWinner()
        {
            Label label;

            for (int i = 0; i < tbl_lout_panel.Controls.Count; i++)
            {
                label = tbl_lout_panel.Controls[i] as Label;
                //si en la iteracion encuentra una con el mismo 
                //color de frente y de atras no has terminado 

                if (label != null && label.ForeColor == label.BackColor)
                { return; }


            }
            timer2.Stop();
            //si todo esta cambiado de color

            MessageBox.Show("ganaste  has tardado " + tempojuego + "segundos");
        }

        private void tbl_lout_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tempojuego++;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {   icons.Add("!");
            icons.Add("!");
            icons.Add("d");
            icons.Add("d");
            icons.Add("e");
            icons.Add("e");
            icons.Add("h");
            icons.Add("h");
            icons.Add("l");
            icons.Add("l");
            icons.Add("s");
            icons.Add("s");
            icons.Add("f");
            icons.Add("f");
            icons.Add("o");
            icons.Add("o");

            
            asignarIconosAgain();
        }


        private void asignarIconosAgain()
        {
            Label label;
            int rndomNumber;

            for (int i = 0; i < tbl_lout_panel.Controls.Count; i++)
            {

                //verificacion de que sean label 
                if (tbl_lout_panel.Controls[i] is Label)
                {
                    label = (Label)tbl_lout_panel.Controls[i];
                    label.ForeColor= label.BackColor;

                }
                else
                {
                    continue;
                }
                rndomNumber = random.Next(0, icons.Count);
                label.Text = icons[rndomNumber];

                //vamos eliminando los elementos para no repetir
                icons.RemoveAt(rndomNumber);

            }
            timer2.Start();
        }
    }
}