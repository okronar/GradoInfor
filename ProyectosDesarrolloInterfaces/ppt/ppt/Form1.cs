using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace ppt
{
    public partial class Form1 : Form
    {
        // Temporizador para la cuenta atrás
        Timer countdownTimer;
        // Duración de la cuenta atrás en segundos
        int countdownSeconds = 3;
        // Generador de números aleatorios
        Random random = new Random();
        // Contadores de partidas ganadas y perdidas
        int numeroGanadas = 0;
        int numeroPerdidas = 0;
        // Total de partidas jugadas
        int partidasTotales = 0;
        // Opciones de la PC
        List<string> EleccionPC = new List<string>() { "Piedra", "Papel", "Tijera" };
        // Elección del jugador
        String eleccionJugador;

        //tienes que crear un txt en c que se llame asi y darle permisos sino los tienes

        string filePath = @"C:\datos.txt";
        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
           
        CargarDatos();
            // Inicializar el temporizador
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // Intervalo de 1 segundo
            countdownTimer.Tick += CountdownTimer_Tick;
        }
        private void CargarDatos()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Leer datos desde el archivo
                    string[] lines = File.ReadAllLines(filePath);

                    // Actualizar variables con los datos cargados
                    if (lines.Length >= 3)
                    {
                        numeroGanadas = int.Parse(lines[0]);
                        partidasTotales = int.Parse(lines[1]);
                        double media = double.Parse(lines[2]);
                        labelMedia.Text = $"Jugador({media})";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        // Método para guardar los datos
        private void GuardarDatos()
        {
            try
            {
                // Crear o sobrescribir el archivo con los nuevos datos
                File.WriteAllText(filePath, $"{numeroGanadas}\n{partidasTotales}\n{(partidasTotales == 0 ? 0 : (double)numeroGanadas / partidasTotales)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }
        }

        // Evento cargado al inicio del formulario (no tiene código actualmente)
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Evento clic del botón "Juego"
        private void btnJuego_Click(object sender, EventArgs e)
        {
            // Verificar si al menos un RadioButton está seleccionado
            if (rbPiedra.Checked || rbPapel.Checked || rbTijera.Checked)
            {
                // Iniciar la cuenta atrás y el juego
                StartCountdown();
                elegirPc();
                elegirJugador();
                jugar();
                // Calcular y mostrar la media de victorias del jugador
                double media = partidasTotales == 0 ? 0 : (double)numeroGanadas / partidasTotales;
                labelMedia.Text = "Jugador(" + media + ")";
                GuardarDatos();
            }
            else
            {
                // Mostrar mensaje si no se selecciona ninguna opción
                labelResultado.Text = "INTRODUCE UNA ELECCION";
            }
        }

        // Lógica del juego
        private void jugar()
        {
            // Comparar elecciones y determinar el resultado
            if (lblMaq.Text == "Piedra" && lblJug.Text == "Piedra")
            {
                labelResultado.Text = "Empate";
                partidasTotales++;
            }
            else if (lblMaq.Text == "Piedra" && lblJug.Text == "Tijera")
            {
                labelResultado.Text = "Pierdes";
                numeroPerdidas++;
                partidasTotales++;
            }
            else if (lblMaq.Text == "Piedra" && lblJug.Text == "Papel")
            {
                labelResultado.Text = "Ganaaas";
                numeroGanadas++;
                partidasTotales++;
            }
            else if (lblMaq.Text == "Papel" && lblJug.Text == "Piedra")
            {
                labelResultado.Text = "pierdes";
                partidasTotales++;
                numeroPerdidas++;
            }
            else if (lblMaq.Text == "Papel" && lblJug.Text == "Tijera")
            {
                labelResultado.Text = "ganaas";
                numeroGanadas++;
                partidasTotales++;
            }
            else if (lblMaq.Text == "Papel" && lblJug.Text == "Papel")
            {
                labelResultado.Text = "empate";
               
                partidasTotales++;
            }
           else if (lblMaq.Text == "Tijeras" && lblJug.Text == "Piedra")
            {
                labelResultado.Text = "ganaas";
                partidasTotales++;
                numeroGanadas++;
            }
            else if (lblMaq.Text == "Tijeras" && lblJug.Text == "Tijera")
            {
                labelResultado.Text = "empate";
                partidasTotales++;
            }
            else if (lblMaq.Text == "Tijeras" && lblJug.Text == "Papel")
            {
                labelResultado.Text = "pierdees";
                numeroPerdidas++;
                partidasTotales++;
            }
            
        }

        // Iniciar la cuenta atrás
        private void StartCountdown()
        {
            // Deshabilitar controles durante la cuenta atrás
            btnJuego.Enabled = false;
            rbPiedra.Enabled = false;
            rbPapel.Enabled = false;
            rbTijera.Enabled = false;

            // Configurar el temporizador y comenzar la cuenta atrás
            countdownSeconds = 3;
            countdownTimer.Start();
        }

        // Evento del temporizador (cuenta atrás)
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto con el valor actual de la cuenta atrás
            contador.Text = "Siguiente Ronda en: " + countdownSeconds.ToString();

            // Decrementar el contador
            countdownSeconds--;

            // Comprobar si la cuenta atrás ha llegado a cero
            if (countdownSeconds < 0)
            {
                // Detener el temporizador
                countdownTimer.Stop();

                // Restablecer el texto y habilitar controles después de la cuenta atrás
                contador.Text = "Listo";
                btnJuego.Enabled = true;
                rbPiedra.Enabled = true;
                rbPapel.Enabled = true;
                rbTijera.Enabled = true;
            }
        }

        // Elección del jugador según el RadioButton seleccionado
        private void elegirJugador()
        {
            if (rbPapel.Checked)
            {
                eleccionJugador = "Papel";
                lblJug.Text = eleccionJugador;
            }
            else if (rbTijera.Checked)
            {
                eleccionJugador = "Tijera";
                lblJug.Text = eleccionJugador;
            }
            else if (rbPiedra.Checked)
            {
                eleccionJugador = "Piedra";
                lblJug.Text = eleccionJugador;
            }
        }

        // Elección aleatoria de la PC
        private void elegirPc()
        {
            int rndomNumber;
            rndomNumber = random.Next(0, 3);
            lblMaq.Text = EleccionPC[rndomNumber];
        }
    }
}
