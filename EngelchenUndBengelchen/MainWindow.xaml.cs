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

namespace EngelchenUndBengelchen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {

        DispatcherTimer gameTimer;
        public int countE = 0;
        public int countB = 0;
        public int score = 0;
        public int remainTime = 50;
        public MainWindow()
        {
            InitializeComponent();

            gameTimer = new DispatcherTimer();
            gameTimer.Interval = new TimeSpan(5000000);
            gameTimer.Tick += new EventHandler(gameTick);
            gameTimer.Start();
            Score.Content = score.ToString("000");

        }

        private void gameTick(object sender, EventArgs e)
        {
            remainTime -= 1;
            RemainTime.Content = remainTime.ToString("000");
            if (remainTime <= 0) {
                gameTimer.Stop();
                return;
            }
            if (countB < 10 || countE < 10)
            {
                Random rnd = new Random();
                GameObject go = null;
                  // check which object to create

                int st = 1;
                int end = 1;
                if (countE < 10)
                {
                    st = 0;
                }
                if (countB < 10)
                {
                    end = 3;
                }
                                
                int zufall = rnd.Next(st, end);

                if (zufall == 1)
                {
                    go = new Engel(this);
                    countE++;
                }
                else if (zufall == 2)
                {
                    go = new Bengel(this);
                    countB++;
                }
                if (go != null) {
                    go.RndPos();
                    Heaven.Children.Add(go);
                }
                Score.Content = score.ToString("000");

            }

        }

    }
}
