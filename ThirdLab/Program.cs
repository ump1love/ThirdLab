using System;

class Program
{
    public static void Main()
    {
        double side1;
        double side2;

        try
        {
            Console.Write("First side of the rectangle: ");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Second side of the rectangle: ");
            side2 = double.Parse(Console.ReadLine());
        }catch(Exception) { Console.WriteLine("Wrong input"); return; }

        Rectangle rectangle = new Rectangle(side1, side2);
        double area = rectangle.Area;
        double perimeter = rectangle.Perimeter;

        Console.WriteLine($"Rectangle area: {area}\n" +
                          $"Rectangle perimeter: {perimeter}");
    }
}