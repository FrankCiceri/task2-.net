using System;

public class Circle:Shape
{
    private double _radius;

    public Circle(double radius)
    {
        this._radius = radius;
    }


    public override double CalcArea()
    {
        double area = Math.PI * Math.Pow(_radius,2);
        Console.WriteLine(area);
        return area;
    }

    public override double CalcPerimeter()
    {
        double perimeter = 2 * Math.PI * _radius;
        Console.WriteLine(perimeter);
        return perimeter;
    }
}
