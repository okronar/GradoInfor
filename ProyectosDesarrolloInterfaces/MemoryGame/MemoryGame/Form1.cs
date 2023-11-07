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
            //verificamos como antes
            Label clickedLabel = sender as Label;

            //si no es nada salir
            if (clickedLabel != null) { return; }

            //si ya esta descubierta salir 
            if(clickedLabel.ForeColor == Color.Chocolate)
            {
                return;

            }
            if(firstClicked == null) {

                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Chocolate;
                return;
            }
            SecondClicked = clickedLabel;
            SecondClicked.ForeColor = Color.Chocolate;  



        }
    }
}