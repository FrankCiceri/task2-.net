using System;

public class Square:Shape
{
    private double _side;
    public override double CalcArea()
    {
        double area = Math.Pow(_side,2);
        Console.WriteLine(area);
        return area;
    }

    public override double CalcPerimeter()
    {
        double perimeter = 4 * _side;
        Console.WriteLine(perimeter);
        return perimeter;
    }
}
