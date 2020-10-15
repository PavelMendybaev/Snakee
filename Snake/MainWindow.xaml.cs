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
using System.Threading;
using System.Windows.Threading;


namespace Snake
{

    public partial class MainWindow : Window
    {

        int speedx = 3;
        int speedy = 0;
        int posx = 250;
        int posy = 250;


        int appleposx = 250;
        int appleposy = 250;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = TimeSpan.FromSeconds(0.05f);
            timer.Start();
        }
        
        void timer_tick( object sender, EventArgs e)
        {
          
            Canvas.SetLeft(snake , posx);
            Canvas.SetTop(snake, posy);
            posx += speedx;
            posy += speedy;


            Canvas.SetLeft(apple, appleposx);
            Canvas.SetTop(apple, appleposy);

            int distx = posx - appleposx;
            int disty = posy - appleposy;

            scoretext.Content = distx + "  " + disty; 
            if(distx < 15 & distx > -15 & disty < 15 & disty > -15)
            {
                Random rndx = new Random();
                Random rndy = new Random();

                appleposx = rndx.Next(20, 450);
                appleposy = rndy.Next(20, 450);

            }
        }
        private void Keydown(object sender,KeyEventArgs  e)
        {
            if(e.Key == Key.A)
            {
                speedx = -3;
                speedy = 0;
            }
            else if (e.Key == Key.D)
            {
                speedx = 3;
                speedy = 0;
            }
            else if (e.Key == Key.W)
            {
                speedx = 0;
                speedy = -3;
            }
            else if (e.Key == Key.S)
            {
                speedx = 0;
                speedy = 3;
            }

        }

    
    }
}
