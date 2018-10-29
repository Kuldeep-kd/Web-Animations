using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Collections.Generic;

class Shapes
{

    private Random rnd = new Random();
    private double radius;
    private int index, l;
    public int MaxRadius { get; set; } = 40;
    private readonly List<Brush> Color = new List<Brush>()
            {
                Brushes.DeepSkyBlue,
                Brushes.Red,
                Brushes.Wheat,
                Brushes.Turquoise,
                Brushes.RoyalBlue,
                Brushes.Yellow,
                Brushes.Coral,
                Brushes.Violet
            };
    

    public Ellipse CreateEllipse(double X, double Y)
    {
        index = rnd.Next(6);
        radius = rnd.Next(1, MaxRadius);
        
        l = rnd.Next(-15, 15);

        Ellipse ellipse = new Ellipse { Width = radius, Height = radius, Fill = Color[index] };
        double left = X - (radius / 2) + l;
        double top  = Y - (radius / 2) + l;
        ellipse.Opacity = 0.4;
        ellipse.Margin = new Thickness(left, top, top, left);
        return ellipse;
    }
}
