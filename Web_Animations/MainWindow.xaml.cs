using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Web_Animations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            timer.Start();
        }

        Timer timer = new Timer(2000) { AutoReset = true, Enabled = true };
        Shapes shape = new Shapes();
        Random Rand_Color = new Random();
        Random Rand_Radius = new Random();
        private static Animations anims = new Animations();
        private static double radius = 100;
        private static int index;

        List<Brush> Color = new List<Brush>()
            {
                Brushes.DeepSkyBlue,
                Brushes.Red,
                Brushes.Wheat,
                Brushes.Yellow
            };

        private new void MouseMove(object sender, MouseEventArgs e)
        {


            Ellipse x = new Ellipse();

            index = Rand_Color.Next(3);
            radius = Rand_Radius.Next(100);

            x = shape.CreateEllipse(radius, e.GetPosition(this).X, e.GetPosition(this).Y, Color[index]);
            c.Children.Add(x);
            anims.Animate(x);

            Timer t = new Timer(3000) { AutoReset = false };
            t.Start();

            t.Elapsed += (object s, ElapsedEventArgs ee) =>
            {
                try
                {
                    this.Dispatcher.Invoke(() =>
                    {

                        c.Children.Remove(x);

                    });
                }
                catch (Exception w) { }

            };



            //timer.Elapsed += (object s, ElapsedEventArgs args) =>
            //{
            //    this.Dispatcher.Invoke(() => { Draw(sender,e); });
            //};

        }


    }
}
