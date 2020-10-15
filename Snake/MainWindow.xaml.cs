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
        int move = 0;
        int speedx = 3;
        int speedy = 0;
        int posx = 250;
        int posy = 250;
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
          
            Canvas.SetLeft(alement , posx);
            Canvas.SetTop(alement, posy);
            posx += speedx;
            posy += speedy;
            
            
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
