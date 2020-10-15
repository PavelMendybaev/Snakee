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
        int speed = 3;
        int posx = 250;
        int posy = 250;
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = TimeSpan.FromSeconds(0.5f);
            timer.Start();
        }
        void timer_tick( object render, EventArgs e)
        {
            if(move == 0)
            {
                Canvas.SetLeft(alement, posx);
                posx += speed;
            }
        }
    }
}
