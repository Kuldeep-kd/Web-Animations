using System;
using System.Timers;
using System.Windows;
using System.Windows.Input;

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
            TxtSpeed.Text = shape.MaxRadius.ToString();
            Sldr_Speed.Maximum = 40;
            Sldr_Speed.Value = shape.MaxRadius;
        }

        private static Shapes shape = new Shapes();
        private static Animations anims = new Animations();




        private new void MouseMove(object sender, MouseEventArgs e)
        {
            Timer dest = new Timer(1000) { AutoReset = false };
            Ellipse x = new Ellipse();

            x = shape.CreateEllipse(e.GetPosition(this).X, e.GetPosition(this).Y);

            c.Children.Add(x);
            anims.Animate(x);

            dest.Start();
            dest.Elapsed += (object s, ElapsedEventArgs ee) =>
            {
                try
                {
                    this.Dispatcher.Invoke(() =>
                    {

                        c.Children.Remove(x);
                        dest.Dispose();

                    });
                }
                catch (Exception w) { }

            };
        }



        private void Sldr_Speed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TxtSpeed.Text = ((int)e.NewValue).ToString();
            shape.MaxRadius = (int)e.NewValue;
        }

        private void WrapPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
