

class Figure
{
    public Point[] points;

    public Figure(params Point[] points)
    {
        if(points.Length <3 || points.Length > 5) 
        { Console.WriteLine("Invalid input. A figure needs to have at least 3 to 5 points."); return; }
        this.points = points;
    }
    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int j = (i + 1) % points.Length;
            perimeter += GetSideLength(points[i], points[j]);
        }
        Console.WriteLine($"And perimeter: {perimeter}");
    }
}