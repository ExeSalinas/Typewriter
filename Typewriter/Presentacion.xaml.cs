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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Typewriter
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Presentacion : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();

        //Sin Uso. Solo para test. Ahora Mando el parametro cuando se invoca al metodo 
        private string stringToDisplay = "CADENA PRUEBA"  ;

        private Random rand;

        //Property para el control de la velocidad
        public int milisVelocidadTipeo { get; set; }

        //Contador de letra.
        private int whichLetter = 0;

        public Presentacion(int milis)

        {


            InitializeComponent();


            rand = new Random(System.DateTime.Now.Millisecond);

            this.timer.Interval = new TimeSpan(0, 0, 0, 0,milis ); //initially it will trigger at 200 milliseconds

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
            
           txtbSample.Text += this.stringToDisplay.Substring(whichLetter, 1);

            whichLetter++;

        }

        private void TxtbSample_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
