using System;

class Program
{
    public static void Main()
    {
        Point A = new Point(2, 3, "A");
        Point B = new Point(5, 3, "B");
        Point C = new Point(5, 7, "C");
        Point D = new Point(2, 7, "D");
        Figure figure = new Figure(A, B, C, D);

        double numSides = figure.points.Length;
        Console.WriteLine($"This figure has {numSides} sides");
        figure.CalculatePerimeter();
    }
}
