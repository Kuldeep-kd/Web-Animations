using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

class Shapes
{
    public Ellipse CreateEllipse(double radius, double X, double Y, Brush color)
    {
        Random location = new Random();
        int l = location.Next(-50, 50);

        Ellipse ellipse = new Ellipse { Width = radius, Height = radius, Fill = color };
        double left = X - (radius / 2) + l;
        double top  = Y - (radius / 2) + l;
        ellipse.Opacity = 0.8;
        ellipse.Margin = new Thickness(left, top, 0, 0);
        return ellipse;
    }
}
