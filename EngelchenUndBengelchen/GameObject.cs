using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Input;

namespace EngelchenUndBengelchen
{
    class GameObject: Image
    {
        protected MainWindow mw;
        protected int itemScore = 0;
        public GameObject(string filename, MainWindow mw)
        {
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            Uri imageUri = new Uri(Path.Combine(Directory.GetCurrentDirectory(), filename));
            Console.WriteLine(  imageUri.ToString());
            b.UriSource = imageUri;
            b.EndInit();
            this.Source = b;
            Margin = new Thickness(0, 0, 0, 0);
            Width = 50.0;
            this.mw = mw;
        }

        internal void RndPos()
        {
            Random rnd = new Random();
            Margin = new Thickness(rnd.Next(0,500), rnd.Next(0, 500), 0, 0);
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            mw.Heaven.Children.Remove(this);
            mw.score +=itemScore;
            UpdateCounter();
        }

        protected virtual void UpdateCounter()
        {
            // implemented in subclass
        }
    }
}
