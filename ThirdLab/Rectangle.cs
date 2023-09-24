﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    private double side1;
    private double side2;


    public Rectangle(double side1, double side2) 
    { this.side1=side1; this.side2 = side2; }

    public double CalculateArea() { return side1 * side2; }
    public double CalculatePerimeter() { return (side1 + side2) * 2; }

    public double Area
    {
        get { return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}