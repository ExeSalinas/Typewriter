using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Typewriter
{
    /// <summary>
    /// Lógica de interacción para Box.xaml
    /// </summary>
    public partial class Box : UserControl
    {
        // VARIABLES DELEFECTO DE TYPEO
        private DispatcherTimer timer = new DispatcherTimer();
        private string stringToDisplay;
        private Random rand;
        //Property para el control de la velocidad
        public int milisVelocidadTipeo { get; set; }
        //Contador de letra actual.
        private int whichLetter = 0;


        // RECIBE POR PARAMETRO EL TIEMPO SETEADO EN MAIN , QUE LUEGO PASA A PRES.
        public Box(int milis)
        {           
            InitializeComponent();

            rand = new Random(System.DateTime.Now.Millisecond);
            this.timer.Interval = new TimeSpan(0, 0, 0, 0, milis);// INTERVALO  , BASADO EN LA VELOCIDAD QUE RECIBIO POR PARAM 
            this.timer.Tick += new EventHandler(timerTick);
        }

        public void SetString(string s)

        {

            whichLetter = 0;

            this.stringToDisplay = s;

            this.timer.Start();

        }
        void timerTick(object sender, EventArgs e)

        {

            //Let's change the time that the following letter will last to appear (just to simulate not-synchronous-writing) 

            this.timer.Stop();

            this.timer.Interval = new TimeSpan(0, 0, 0, 0, rand.Next(0, 200)); //the following letter will appear in a period between the next 0 and 200 milliseconds.

            if (whichLetter < this.stringToDisplay.Length)

            {

                AddFollowingLetter();

                timer.Start();

            }

        }

        void AddFollowingLetter()

        {

            txtContent.Text += this.stringToDisplay.Substring(whichLetter, 1);

            whichLetter++;

        }
    }
}
