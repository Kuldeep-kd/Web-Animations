using System;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Timers;


class Animations
{
    public void Animate(Ellipse e)
    {
        DoubleAnimation anim = new DoubleAnimation { From = e.Height, To = 0, Duration = TimeSpan.FromSeconds(1) };
        e.BeginAnimation(Ellipse.HeightProperty, anim);
        e.BeginAnimation(Ellipse.WidthProperty, anim);
        
    }

}
