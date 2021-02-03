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
        private string stringToDisplay ;
        private List<string> stringList;
        private int velocidad;
        private Random rand;

        //Property para el control de la velocidad
        public int milisVelocidadTipeo { get; set; }


        public Presentacion(int milis, string s )

        {
            this.stringToDisplay = s;
            this.velocidad = milis;
            InitializeComponent();
            SplitString();

        }

        private List<string> SplitString()
        {
            stringList = stringToDisplay.Split('|').ToList();
            return stringList;

        }


       
    }
}
